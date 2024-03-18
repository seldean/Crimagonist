using UnityEngine;
using System.Collections.Generic;
using OutputController;

public static class TrialRules
{
    public const byte BASE_IMPRISONMENT_CHANCE = 100;

    public const byte MIN_WANTED_LEVEL_TO_BECOME_UNPAYABLE = 4;
}

public class Crime
{
    public string CrimeName { get; set; }
    public string CrimeDescription { get; set; }
    public bool Prisonable { get; set; }
    public byte SentenceLength { get; set; }
    public uint Fee { get; set; }
    public bool DeathSentence { get; set; }

    public Crime(string name, string description, bool prisonable, byte sentenceLength, uint fee, bool deathSentence)
    {
        CrimeName = name;
        CrimeDescription = description;
        Prisonable = prisonable;
        SentenceLength = sentenceLength;
        Fee = fee;
        DeathSentence = deathSentence;
    }
}

public class Trial
{
    public bool IsArchived { get; set; }
    public string Name { get; set; }
    public Country Country { get; set; }
    public GameDate ExecuteDate { get; set; }
    public Dictionary<Crime, uint> ListOfCrimes { get; set; }
    public bool IsPayable { get; set; }
    public List<Player> OwnerPlayers { get; set; }
    public List<NPC> OwnerNPCs { get; set; }
    public Player AttachedLawyerPlayer { get; set; }
    public NPC AttachedLawyerNPC { get; set; }

    public Trial(string name, Country country, GameDate executeDate, List<Player> ownerPlayers, List<NPC> ownerNPCs)
    {
        IsArchived = false;
        Name = name;
        Country = country;
        ExecuteDate = executeDate;
        OwnerPlayers = ownerPlayers;
        OwnerNPCs = ownerNPCs;
        AttachedLawyerPlayer = null;
        AttachedLawyerNPC = null;
        IsPayable = true;

        //Fill crimes
        ListOfCrimes = new Dictionary<Crime, uint>();
        List<Crime> Crimes = CrimeStorage.GetAllCrimes();
        foreach (Crime item in Crimes)
        {
            ListOfCrimes.Add(item, 0);
        }

        GameMessageScript.Notification("New case in " + Country.Name + ". Case name: " + Name + ".", OwnerPlayers, Color.yellow, false);
    }

    public void ExecuteTrial()
    {
        //Key variables
        byte LawyerLevel = 0;
        if (AttachedLawyerPlayer != null) { LawyerLevel = AttachedLawyerPlayer.LawyeringLevel; }
        else if (AttachedLawyerNPC != null) { LawyerLevel = AttachedLawyerNPC.LawyeringLevel; }

        //Creating the lists of characters that in prison and have to come to trials.
        List<Player> AttendandPlayers = new List<Player>();
        List<NPC> AttendandNPCs = new List<NPC>();

        //Filling lists with prisoned characters
        foreach (Player pl in OwnerPlayers)
        {
            if (pl.InPrison)
            {
                AttendandPlayers.Add(pl);
            }
        }
        foreach (NPC npc in OwnerNPCs)
        {
            if (npc.InPrison)
            {
                AttendandNPCs.Add(npc);
            }
        }

        //Calculation of imprisonment chance
        uint CrimeAmount = 0;
        foreach (KeyValuePair<Crime, uint> item in ListOfCrimes) { CrimeAmount += item.Value; } //Fills CrimeAmount
        byte ImprisonmentChance = Convert.ToByte((TrialRules.BASE_IMPRISONMENT_CHANCE - (LawyerLevel / 5)) + (CrimeAmount / 2)); ;
        byte LawyerDelayChance = 0;
        if (LawyerLevel != 0)
        {
            LawyerDelayChance = Convert.ToByte(LawyerLevel / 50);
        }

        //Decide if they are imprisoned
        if (Random.Range(0, 101) <= ImprisonmentChance)
        {
            //Lawyer can delay the trial
            if (Random.Range(0, 101) >= LawyerDelayChance)
            {
                GameDate newExecuteDate = GameController.gameDate;
                newExecuteDate.AddDay(7);
                ExecuteDate = newExecuteDate;

                GameMessageScript.Notification("Trial " + Name + " postponed by lawyer. New execution date: " + ExecuteDate.ToString() + ".", OwnerPlayers, Color.blue, false);
            }
            else
            {
                //Imprisonment codes
                uint SentenceLength = 0;
                GameDate prisonmentEndDate = GameController.gameDate;

                foreach (KeyValuePair<Crime, uint> crime in ListOfCrimes) //Calculate Sentence length
                {
                    SentenceLength += Convert.ToUInt(crime.Key.SentenceLength * crime.Value);
                }

                foreach (Player pl in AttendandPlayers)
                {
                    pl.SetPrisonState(true);
                    pl.SetPrisonEndDate(prisonmentEndDate);
                }
                foreach (NPC npc in AttendandNPCs)
                {
                    npc.SetPrisonState(true);
                    npc.SetPrisonEndDate(prisonmentEndDate);
                }

                //Death sentence codes
                if (Country.DeathSentenceAllowed)
                {
                    foreach (KeyValuePair<Crime, uint> crime in ListOfCrimes)
                    {
                        if (crime.Key.DeathSentence && crime.Value > 0)
                        {
                            if (Random.Range(0, 101) >= LawyerLevel / 2)
                            {
                                GameDate executionDate = GameController.gameDate;
                                executionDate.AddMonth(1);

                                foreach (Player pl in AttendandPlayers)
                                {
                                    pl.SetDeathSentenced(true);
                                    pl.SetExecutionDate(executionDate);
                                }
                                foreach (NPC npc in AttendandNPCs)
                                {
                                    npc.SetDeathSentenced(true);
                                    npc.SetExecutionDate(executionDate);
                                }
                            }
                        }
                    }
                }
            }
        }
        else
        {
            //Trial won by attendands
            SetIsArchived(true);
        }
    }
    public bool PayTrial(Player player = null)
    {
        if (IsPayable)
        {
            uint TotalDebt = 0;
            bool Successful = false;

            //See if any character is above the "unpayable wanted level" threshold
            foreach (Player pl in OwnerPlayers)
            {
                if (pl.WantedLevel >= TrialRules.MIN_WANTED_LEVEL_TO_BECOME_UNPAYABLE)
                {
                    IsPayable = false;
                    return false;
                }
            }
            foreach (NPC npc in OwnerNPCs)
            {
                if (npc.WantedLevel >= TrialRules.MIN_WANTED_LEVEL_TO_BECOME_UNPAYABLE)
                {
                    IsPayable = false;
                    return false;
                }
            }

            //Check if npc's are paying
            if (player == null)
            {
                GameMessageScript.Notification("The fee of " + Name + " case is now paid and going to be archived.", OwnerPlayers, Color.green, true);
                SetIsArchived(true);
                return true;
            }

            //Sum of total debt
            foreach (KeyValuePair<Crime, uint> item in ListOfCrimes)
            {
                TotalDebt += Convert.ToUInt(item.Key.Fee * item.Value);
            }

            //Check if player can afford it, if it is then payment and arrangement codes
            if (player.MoneyDollar >= TotalDebt)
            {
                player.MoneyDollar -= TotalDebt;
                Successful = true;

                GameMessageScript.Notification("The fee of " + Name + " case has been paid by " + player.Name + ".", OwnerPlayers, Color.green, true);

                SetIsArchived(true);
            }

            return Successful;
        }
        else
        {
            return false;
        }
    }

    public void SetIsArchived(bool isArchived)
    {
        IsArchived = isArchived;

        if (IsArchived)
        {
            GameMessageScript.Notification("The " + Name + " trial is complete and archived.", OwnerPlayers, Color.green, false);
        }
        else
        {
            GameMessageScript.Notification("The " + Name + " trial is no longer in archived.", OwnerPlayers, Color.red, false);
        }
    }

    public void SetName(string newName) { Name = newName; }

    public void SetExecuteDate(GameDate newExecuteDate)
    {
        ExecuteDate = newExecuteDate;

        GameMessageScript.Notification("Trial " + Name + "'s new execution date is: " + ExecuteDate.ToString(), OwnerPlayers, Color.blue, true);
    }

    public void AddCrime(Crime crime, uint amount)
    {
        if (ListOfCrimes.ContainsKey(crime))
        {
            ListOfCrimes[crime] += amount;
        }
    }
    public void RemoveCrime(Crime crime, uint amount)
    {
        if (ListOfCrimes.ContainsKey(crime))
        {
            ListOfCrimes[crime] -= amount;
        }
    }

    public void AddOwnerPlayer(Player player)
    {
        OwnerPlayers.Add(player);

        GameMessageScript.Notification("You are now a participant in " + Name + " case.", new List<Player> { player }, Color.red, false);
    }
    public void RemoveOwnerPlayer(Player player)
    {
        OwnerPlayers.Remove(player);

        GameMessageScript.Notification("You are no longer participant in " + Name + " case.", new List<Player> { player }, Color.green, false);
    }
    public void AddOwnerNPC(NPC npc) {  OwnerNPCs.Add(npc); }
    public void RemoveOwnerNPC(NPC npc) { OwnerNPCs.Remove(npc); }
    public void ChangeLawyerPlayer(Player newLawyer = null)
    {
        AttachedLawyerPlayer = newLawyer;
        AttachedLawyerNPC = null;

        GameMessageScript.Notification("You are now the lawyer of " + Name + " case.", new List<Player> { AttachedLawyerPlayer }, Color.blue, false);
        GameMessageScript.Notification("The lawyer of " + Name + " case has changed. New lawyer is " + AttachedLawyerPlayer.Name, OwnerPlayers, Color.blue, true);
    }
    public void ChangeLawyerNPC(NPC newLawyer = null)
    {
        AttachedLawyerNPC = newLawyer;
        GameMessageScript.Notification("The lawyer of " + Name + " case has changed. New lawyer is " + AttachedLawyerNPC.Name, OwnerPlayers, Color.blue, true);

        if (AttachedLawyerPlayer != null)
        {
            GameMessageScript.Notification("You are no longer lawyer of the " + Name + " case.", new List<Player> { AttachedLawyerPlayer }, Color.blue, false);
        }

        AttachedLawyerPlayer = null;
    }
}
