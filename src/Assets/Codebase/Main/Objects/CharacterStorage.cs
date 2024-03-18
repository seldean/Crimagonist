using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using OutputController;

public class CharacterStorage
{
    #region Declerations
    public static List<Player> Players = new List<Player>();
    public static List<NPC> NPCs = new List<NPC>();
    #endregion

    #region Declerations:Min-Max
    private static ushort LevelMin = 0; 
    private static ushort LevelMax = 0; //25.000
    private static ushort RenownMin = 0; 
    private static ushort RenownMax = 0; // 1000
    private static ushort DependabilityMin = 0; 
    private static ushort DependabilityMax = 0; //1000

    //These stats are between 0 and 250
    private static byte OperatingLevelMin = 0;
    private static byte OperatingLevelMax = 0;
    private static byte BusinessLevelMin = 0; 
    private static byte BusinessLevelMax = 0; 
    private static byte CharmLevelMin = 0; 
    private static byte CharmLevelMax = 0; 
    private static byte PowerLevelMin = 0; 
    private static byte PowerLevelMax = 0; 
    private static byte StealthLevelMin = 0; 
    private static byte StealthLevelMax = 0; 
    private static byte IntelligenceLevelMin = 0; 
    private static byte IntelligenceLevelMax = 0; 
    private static byte HandinessLevelMin = 0; 
    private static byte HandinessLevelMax = 0; 
    private static byte TechLevelMin = 0; 
    private static byte TechLevelMax = 0; 
    private static byte FarmerLevelMin = 0; 
    private static byte FarmerLeveLMax = 0; 
    private static byte ProduceMethLevelMin = 0; 
    private static byte ProduceMethLevelMax = 0; 
    private static byte ProduceCocainLevelMin = 0; 
    private static byte ProduceCocainLevelMax = 0; 
    private static byte ProduceWeedLevelMin = 0; 
    private static byte ProduceWeedLevelMax = 0; 
    private static byte ProduceMDMALevelMin = 0; 
    private static byte ProduceMDMALevelMax = 0; 
    private static byte LabLevelMin = 0; 
    private static byte LabLevelMax = 0; 
    private static byte ConnectionsLevelMin = 0; 
    private static byte ConnectionsLevelMax = 0; 
    private static byte TransporterLevelMin = 0; 
    private static byte TransporterLevelMax = 0; 
    private static byte MoneyLaunderingLevelMin = 0; 
    private static byte MoneyLaunderingLevelMax = 0; 
    private static byte LawyeringLevelMin = 0; 
    private static byte LawyeringLevelMax = 0; 
    #endregion

    #region Creation:Player (INCOMPLETE)
    public void CreatePlayer(string name, string nickname, bool ismale, Country motherland, City currentlocation, byte operating, bool likesloud, byte business, byte charm, byte power, byte stealth, byte intelligence, byte handiness, byte tech, byte transport)
    {
        Player player = new Player();
        Players.Add(player);
    }
    #endregion

    #region NPC Creation Tools
    //NPC Focus
    private byte FocusDecider(uint NPCIndex)
    {
        byte focusIndex = 0;
        //0 = ALL, 1 = Business, 2 = Robber, 3 = Hitman, 4 = Worker, 5 = Dealer, 6 = Transporter, 7 = Accountant, 8 = Attorney, 9 = Connector

        if (
            NPCIndex <= CharacterCreationSettings.ALL_FOCUSED_NPC_AMOUNT
            )
        {
            focusIndex = 0;
        }
        else if (
            NPCIndex <= CharacterCreationSettings.ALL_FOCUSED_NPC_AMOUNT + 
            CharacterCreationSettings.BUSINESS_OWNER_AMOUNT
            )
        {
            focusIndex = 1;
        }
        else if (
            NPCIndex <= CharacterCreationSettings.ALL_FOCUSED_NPC_AMOUNT +
            CharacterCreationSettings.BUSINESS_OWNER_AMOUNT +
            CharacterCreationSettings.ROBBER_AMOUNT
            )
        {
            focusIndex = 2;
        }
        else if (
            NPCIndex <= CharacterCreationSettings.ALL_FOCUSED_NPC_AMOUNT +
            CharacterCreationSettings.BUSINESS_OWNER_AMOUNT +
            CharacterCreationSettings.ROBBER_AMOUNT +
            CharacterCreationSettings.HITMAN_AMOUNT
            )
        {
            focusIndex = 3;
        }
        else if (
            NPCIndex <= CharacterCreationSettings.ALL_FOCUSED_NPC_AMOUNT +
            CharacterCreationSettings.BUSINESS_OWNER_AMOUNT +
            CharacterCreationSettings.ROBBER_AMOUNT +
            CharacterCreationSettings.HITMAN_AMOUNT +
            CharacterCreationSettings.WORKER_AMOUNT
            )
        {
            focusIndex = 4;
        }
        else if (
            NPCIndex <= CharacterCreationSettings.ALL_FOCUSED_NPC_AMOUNT +
            CharacterCreationSettings.BUSINESS_OWNER_AMOUNT +
            CharacterCreationSettings.ROBBER_AMOUNT +
            CharacterCreationSettings.HITMAN_AMOUNT +
            CharacterCreationSettings.WORKER_AMOUNT +
            CharacterCreationSettings.DEALER_AMOUNT
            )
        {
            focusIndex = 5;
        }
        else if (
            NPCIndex <= CharacterCreationSettings.ALL_FOCUSED_NPC_AMOUNT +
            CharacterCreationSettings.BUSINESS_OWNER_AMOUNT +
            CharacterCreationSettings.ROBBER_AMOUNT +
            CharacterCreationSettings.HITMAN_AMOUNT +
            CharacterCreationSettings.WORKER_AMOUNT +
            CharacterCreationSettings.DEALER_AMOUNT +
            CharacterCreationSettings.TRANSPORTER_AMOUNT
            )
        {
            focusIndex = 6;
        }
        else if (
            NPCIndex <= CharacterCreationSettings.ALL_FOCUSED_NPC_AMOUNT +
            CharacterCreationSettings.BUSINESS_OWNER_AMOUNT +
            CharacterCreationSettings.ROBBER_AMOUNT +
            CharacterCreationSettings.HITMAN_AMOUNT +
            CharacterCreationSettings.WORKER_AMOUNT +
            CharacterCreationSettings.DEALER_AMOUNT +
            CharacterCreationSettings.TRANSPORTER_AMOUNT +
            CharacterCreationSettings.ACCOUNTANT_AMOUNT
            )
        {
            focusIndex = 7;
        }
        else if (
            NPCIndex <= CharacterCreationSettings.ALL_FOCUSED_NPC_AMOUNT +
            CharacterCreationSettings.BUSINESS_OWNER_AMOUNT +
            CharacterCreationSettings.ROBBER_AMOUNT +
            CharacterCreationSettings.HITMAN_AMOUNT +
            CharacterCreationSettings.WORKER_AMOUNT +
            CharacterCreationSettings.DEALER_AMOUNT +
            CharacterCreationSettings.TRANSPORTER_AMOUNT +
            CharacterCreationSettings.ACCOUNTANT_AMOUNT +
            CharacterCreationSettings.ATTORNEY_AMOUNT
            )
        {
            focusIndex = 8;
        }
        else if (
            NPCIndex <= CharacterCreationSettings.ALL_FOCUSED_NPC_AMOUNT +
            CharacterCreationSettings.BUSINESS_OWNER_AMOUNT +
            CharacterCreationSettings.ROBBER_AMOUNT +
            CharacterCreationSettings.HITMAN_AMOUNT +
            CharacterCreationSettings.WORKER_AMOUNT +
            CharacterCreationSettings.DEALER_AMOUNT +
            CharacterCreationSettings.TRANSPORTER_AMOUNT +
            CharacterCreationSettings.ACCOUNTANT_AMOUNT +
            CharacterCreationSettings.ATTORNEY_AMOUNT +
            CharacterCreationSettings.CONNECTOR_AMOUNT
            )
        {
            focusIndex = 9;
        }

        return focusIndex;
    }
    //NPC Stats
    private void MakeStatsForNPCs(string Rarity, byte focusIndex)
    {
        #region Default Stats
        //Main
        LevelMin = 0;
        LevelMax = 1000;
        RenownMin = 0;
        RenownMax = 250;
        DependabilityMin = 0;
        DependabilityMax = 250;
        //Special
        OperatingLevelMin = 0;
        OperatingLevelMax = 25;
        BusinessLevelMin = 0;
        BusinessLevelMax = 90;
        CharmLevelMin = 0;
        CharmLevelMax = 90;
        PowerLevelMin = 0;
        PowerLevelMax = 90;
        StealthLevelMin = 0;
        StealthLevelMax = 90;
        IntelligenceLevelMin = 0;
        IntelligenceLevelMax = 90;
        HandinessLevelMin = 0;
        HandinessLevelMax = 90;
        TechLevelMin = 0;
        TechLevelMax = 90;
        FarmerLevelMin = 0;
        FarmerLeveLMax = 90;
        ProduceMethLevelMin = 0;
        ProduceMethLevelMax = 90;
        ProduceCocainLevelMin = 0;
        ProduceCocainLevelMax = 90;
        ProduceWeedLevelMin = 0;
        ProduceWeedLevelMax = 90;
        ProduceMDMALevelMin = 0;
        ProduceMDMALevelMax = 90;
        ConnectionsLevelMin = 0;
        ConnectionsLevelMax = 150;
        TransporterLevelMin = 0;
        TransporterLevelMax = 90;
        MoneyLaunderingLevelMin = 0;
        MoneyLaunderingLevelMax = 90;
        LawyeringLevelMax = 0;
        LawyeringLevelMin = 90;
        LabLevelMin = 0;
        LabLevelMax = 90;
        #endregion

        if (focusIndex == 0)
        {
            Rarity = "";
        }

        switch (Rarity)
        {
            case "Ultra Rare":
                LevelMin = 25000;
                LevelMax = 30000;
                RenownMin = 900;
                RenownMax = 1000;
                DependabilityMin = 975;
                DependabilityMax = 1000;
                ConnectionsLevelMin = 200;
                ConnectionsLevelMax = 250;
                OperatingLevelMin = 100;
                OperatingLevelMax = 250;
                if (focusIndex == 1)
                {
                    BusinessLevelMin = 200;
                    BusinessLevelMax = 250;
                    CharmLevelMin = 200;
                    CharmLevelMax = 250;
                    IntelligenceLevelMin = 200;
                    IntelligenceLevelMax = 250;
                }
                if (focusIndex == 2)
                {
                    PowerLevelMin = 150;
                    PowerLevelMax = 200;
                    StealthLevelMin = 150;
                    StealthLevelMax = 250;
                    HandinessLevelMin = 150;
                    HandinessLevelMax = 250;
                    TechLevelMin = 150;
                    TechLevelMax = 250;
                }
                if (focusIndex == 3)
                {
                    PowerLevelMin = 200;
                    PowerLevelMax = 250;
                    StealthLevelMin = 200;
                    StealthLevelMax = 250;
                }
                if (focusIndex == 4)
                {
                    FarmerLevelMin = 200;
                    FarmerLeveLMax = 250;
                    ProduceMethLevelMin = 200;
                    ProduceMethLevelMax = 250;
                    ProduceCocainLevelMin = 200;
                    ProduceCocainLevelMax = 250;
                    ProduceWeedLevelMin = 200;
                    ProduceWeedLevelMax = 250;
                    ProduceMDMALevelMin = 200;
                    ProduceMDMALevelMax = 250;
                    LabLevelMin = 200;
                    LabLevelMax = 250;
                }
                if (focusIndex == 5)
                {
                    PowerLevelMin = 200;
                    PowerLevelMax = 250;
                    StealthLevelMin = 200;
                    StealthLevelMax = 250;
                }
                if (focusIndex == 6)
                {
                    StealthLevelMin = 200;
                    StealthLevelMax = 250;
                    TransporterLevelMin = 200;
                    TransporterLevelMax = 250;
                }
                if (focusIndex == 7)
                {
                    MoneyLaunderingLevelMin = 200;
                    MoneyLaunderingLevelMax = 250;
                }
                if (focusIndex == 8)
                {
                    LawyeringLevelMax = 200;
                    LawyeringLevelMin = 250;
                }
                if (focusIndex == 9)
                {
                    LawyeringLevelMax = 240;
                    LawyeringLevelMin = 250;
                }
                break;
            case "Rare":
                LevelMin = 20000;
                LevelMax = 25000;
                RenownMin = 800;
                RenownMax = 1000;
                DependabilityMin = 900;
                DependabilityMax = 1000;
                ConnectionsLevelMin = 200;
                ConnectionsLevelMax = 225;
                OperatingLevelMin = 50;
                OperatingLevelMax = 200;
                if (focusIndex == 1)
                {
                    BusinessLevelMin = 185;
                    BusinessLevelMax = 225;
                    CharmLevelMin = 185;
                    CharmLevelMax = 225;
                    IntelligenceLevelMin = 185;
                    IntelligenceLevelMax = 225;
                }
                if (focusIndex == 2)
                {
                    PowerLevelMin = 125;
                    PowerLevelMax = 175;
                    StealthLevelMin = 125;
                    StealthLevelMax = 175;
                    HandinessLevelMin = 125;
                    HandinessLevelMax = 175;
                    TechLevelMin = 125;
                    TechLevelMax = 175;
                }
                if (focusIndex == 3)
                {
                    PowerLevelMin = 185;
                    PowerLevelMax = 225;
                    StealthLevelMin = 185;
                    StealthLevelMax = 225;
                }
                if (focusIndex == 4)
                {
                    FarmerLevelMin = 185;
                    FarmerLeveLMax = 225;
                    ProduceMethLevelMin = 185;
                    ProduceMethLevelMax = 225;
                    ProduceCocainLevelMin = 185;
                    ProduceCocainLevelMax = 225;
                    ProduceWeedLevelMin = 185;
                    ProduceWeedLevelMax = 225;
                    ProduceMDMALevelMin = 185;
                    ProduceMDMALevelMax = 225;
                    LabLevelMin = 185;
                    LabLevelMax = 225;
                }
                if (focusIndex == 5)
                {
                    PowerLevelMin = 185;
                    PowerLevelMax = 225;
                    StealthLevelMin = 185;
                    StealthLevelMax = 225;
                }
                if (focusIndex == 6)
                {
                    StealthLevelMin = 185;
                    StealthLevelMax = 225;
                    TransporterLevelMin = 185;
                    TransporterLevelMax = 225;
                }
                if (focusIndex == 7)
                {
                    MoneyLaunderingLevelMin = 185;
                    MoneyLaunderingLevelMax = 225;
                }
                if (focusIndex == 8)
                {
                    LawyeringLevelMax = 185;
                    LawyeringLevelMin = 225;
                }
                if (focusIndex == 9)
                {
                    LawyeringLevelMax = 200;
                    LawyeringLevelMin = 240;
                }
                break;
            case "Uncommon":
                LevelMin = 5000;
                LevelMax = 20000;
                RenownMin = 400;
                RenownMax = 800;
                DependabilityMin = 600;
                DependabilityMax = 800;
                ConnectionsLevelMin = 20;
                ConnectionsLevelMax = 200;
                OperatingLevelMin = 0;
                OperatingLevelMax = 100;
                if (focusIndex == 1)
                {
                    BusinessLevelMin = 100;
                    BusinessLevelMax = 175;
                    CharmLevelMin = 100;
                    CharmLevelMax = 175;
                    IntelligenceLevelMin = 100;
                    IntelligenceLevelMax = 175;
                }
                if (focusIndex == 2)
                {
                    PowerLevelMin = 50;
                    PowerLevelMax = 125;
                    StealthLevelMin = 50;
                    StealthLevelMax = 125;
                    HandinessLevelMin = 50;
                    HandinessLevelMax = 125;
                    TechLevelMin = 50;
                    TechLevelMax = 125;
                }
                if (focusIndex == 3)
                {
                    PowerLevelMin = 100;
                    PowerLevelMax = 175;
                    StealthLevelMin = 100;
                    StealthLevelMax = 175;
                }
                if (focusIndex == 4)
                {
                    FarmerLevelMin = 100;
                    FarmerLeveLMax = 175;
                    ProduceMethLevelMin = 100;
                    ProduceMethLevelMax = 175;
                    ProduceCocainLevelMin = 100;
                    ProduceCocainLevelMax = 175;
                    ProduceWeedLevelMin = 100;
                    ProduceWeedLevelMax = 175;
                    ProduceMDMALevelMin = 100;
                    ProduceMDMALevelMax = 175;
                    LabLevelMin = 100;
                    LabLevelMax = 175;
                }
                if (focusIndex == 5)
                {
                    PowerLevelMin = 100;
                    PowerLevelMax = 175;
                    StealthLevelMin = 100;
                    StealthLevelMax = 175;
                }
                if (focusIndex == 6)
                {
                    StealthLevelMin = 100;
                    StealthLevelMax = 175;
                    TransporterLevelMin = 100;
                    TransporterLevelMax = 175;
                }
                if (focusIndex == 7)
                {
                    MoneyLaunderingLevelMin = 100;
                    MoneyLaunderingLevelMax = 175;
                }
                if (focusIndex == 8)
                {
                    LawyeringLevelMax = 100;
                    LawyeringLevelMin = 175;
                }
                if (focusIndex == 9)
                {
                    LawyeringLevelMax = 100;
                    LawyeringLevelMin = 175;
                }
                break;
            default:
                break;
        }

        //If NPC focuses on Robbery, gonna take a bonus to one of RObbery related skill
        if (focusIndex == 2)
        {
            int RandomizedRobberSkillIndex = Random.Range(0, 4);
            switch (RandomizedRobberSkillIndex)
            {
                case 0:
                    if (PowerLevelMin + 100 >= 250) {
                        PowerLevelMin = 250;
                    }
                    else {
                        PowerLevelMin += 100;
                    }
                    if (PowerLevelMax + 100 >= 250) {
                        PowerLevelMax = 250;
                    }
                    else {
                        PowerLevelMax += 100;
                    }
                    break;
                case 1:
                    if (StealthLevelMin + 100 >= 250) {
                        StealthLevelMin = 250;
                    }
                    else {
                        StealthLevelMin += 100;
                    }
                    if (StealthLevelMax + 100 >= 250) {
                        StealthLevelMax = 250;
                    }
                    else {
                        StealthLevelMax += 100;
                    }
                    break;
                case 2:
                    if (HandinessLevelMin + 100 >= 250) {
                        HandinessLevelMin = 250;
                    }
                    else {
                        HandinessLevelMin += 100;
                    }
                    if (HandinessLevelMax + 100 >= 250) {
                        HandinessLevelMax = 250;
                    }
                    else {
                        HandinessLevelMax += 100;
                    }
                    break;
                case 3:
                    if (TechLevelMin + 100 >= 250) {
                        TechLevelMin = 250;
                    }
                    else {
                        TechLevelMin += 100;
                    }
                    if (TechLevelMax + 100 >= 250) {
                        TechLevelMax = 250;
                    }
                    else {
                        TechLevelMax += 100;
                    }
                    break;
                default:
                    break;
            }
        }
    }
    private ushort SelectUShortStatForNPCs(int min, int max)
    {
        ushort finalvalue = 0;
        finalvalue = Convert.ToUShort(Random.Range(min, max));
        return finalvalue;
    }
    private byte SelectByteStatForNPCs(int min, int max)
    {
        byte finalvalue = 0;
        finalvalue = Convert.ToByte(Random.Range(min, max));
        return finalvalue;
    }
    private void CheckRarity(byte focusIndex)
    {
        byte RarityScore = Convert.ToByte(Random.Range(CharacterCreationSettings.RARITY_RANDOMIZER_MIN, CharacterCreationSettings.RARITY_RANDOMIZER_MAX));

        if (RarityScore >= CharacterCreationSettings.ULTRA_RARE_LIMIT)
        {
            MakeStatsForNPCs("Ultra Rare", focusIndex);
        }
        else if (RarityScore >= CharacterCreationSettings.RARE_LIMIT)
        {
            MakeStatsForNPCs("Rare", focusIndex);
        }
        else if (RarityScore >= CharacterCreationSettings.UNCOMMON_LIMIT)
        {
            MakeStatsForNPCs("Uncommon", focusIndex);
        }
        else
        {
            MakeStatsForNPCs("", focusIndex);
        }
    }
    //NPC Gender
    private bool GenderDecider(byte focusIndex)
    {
        switch (focusIndex)
        {
            case 1:
                return GenderDeciderSubMethod(CharacterCreationSettings.BUSINESS_WOMAN_PERCENTAGE);
            case 2:
                return GenderDeciderSubMethod(CharacterCreationSettings.ROBBER_WOMAN_PERCENTAGE);
            case 3:
                return GenderDeciderSubMethod(CharacterCreationSettings.HITMAN_WOMAN_PERCENTAGE);
            case 4:
                return GenderDeciderSubMethod(CharacterCreationSettings.WORKER_WOMAN_PERCENTAGE);
            case 5:
                return GenderDeciderSubMethod(CharacterCreationSettings.DEALER_WOMAN_PERCENTAGE);
            case 6:
                return GenderDeciderSubMethod(CharacterCreationSettings.TRANSPORTER_WOMAN_PERCENTAGE);
            case 7:
                return GenderDeciderSubMethod(CharacterCreationSettings.ACCOUNTANT_WOMAN_PERCENTAGE);
            case 8:
                return GenderDeciderSubMethod(CharacterCreationSettings.ATTORNEY_WOMAN_PERCENTAGE);
            case 9:
                return GenderDeciderSubMethod(CharacterCreationSettings.CONNECTOR_WOMAN_PERCENTAGE);
            default:
                return GenderDeciderSubMethod(CharacterCreationSettings.DEFAULT_WOMAN_PERCENTAGE);
        }
    }
    private bool GenderDeciderSubMethod(byte womanPercentage)
    {
        int randomnumber = Random.Range(1, 101);
        if (randomnumber <= womanPercentage)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    //Age Decider
    private byte AgeRandomizer(ushort npcLevel)
    {
        if (npcLevel >= 30000)
        {
            return Convert.ToByte(Random.Range(40, 71));
        }
        else if (npcLevel >= 25000)
        {
            return Convert.ToByte(Random.Range(40, 66));
        }
        else if (npcLevel >= 20000)
        {
            return Convert.ToByte(Random.Range(30, 51));
        }
        else if (npcLevel >= 15000)
        {
            return Convert.ToByte(Random.Range(20, 41));
        }
        else if (npcLevel >= 10000)
        {
            return Convert.ToByte(Random.Range(20, 31));
        }
        else if (npcLevel >= 5000)
        {
            return Convert.ToByte(Random.Range(18, 26));
        }
        else
        {
            return Convert.ToByte(Random.Range(16, 20));
        }
    }
    //NPC Motherland and Current Location
    private Country MotherlandSelector(List<Country> countries)
    {
        return countries[Random.Range(0, countries.Count)];
    }
    private City CurrentLocationSelector(List<City> cities)
    {
        return cities[Random.Range(0, cities.Count)];
    }
    //NPC name selector
    private string NameSelector(string motherland, bool isMale)
    {
        return CharacterNamesAndSurnames.GetRandomNameSurname(motherland, isMale);
    }
    //NPC Prison
    private bool SelectNPCInPrison()
    {
        float ChanceToBeImprisoned = Random.Range(0, 101);
        if (ChanceToBeImprisoned <= CharacterCreationSettings.NPC_IMPRISONED_CHANCE)
        {
            return true;
        }

        return false;
    }
    //NPC Running
    private bool SelectNPCIsRunning()
    {
        float ChanceToRun = Random.Range(0, 101);
        if (ChanceToRun <= CharacterCreationSettings.NPC_RUNNING_CHANCE)
        {
            return true;
        }

        return false;
    }
    #endregion

    #region Creation:NPC
    private void CreateNPCsForNewSave(bool isSingularCreation)
    {
        //Store the amount of npcs from settings
        uint amount = 1;

        //Store the countries and cities temporarily
        List<Country> tempCountries = LocationStorage.TakeTempCountries();
        List<City> tempCities = LocationStorage.TakeTempCities();

        if (!isSingularCreation)
        {
            amount = CharacterCreationSettings.TOTAL_NPC_AMOUNT;
        }

        for (uint i = 0; i < amount; i++)
        {
            NPC npc = new NPC();

            //NPCs Focus
            npc.FocusIndex = FocusDecider(i);

            //Checking the rarity of the NPC
            CheckRarity(npc.FocusIndex);

            //Main
            npc.IsMale = GenderDecider(npc.FocusIndex);
            npc.Level = SelectUShortStatForNPCs(LevelMin, LevelMax);
            npc.Age = AgeRandomizer(npc.Level);
            npc.Renown = SelectUShortStatForNPCs(RenownMin, RenownMax);
            npc.Dependability = SelectUShortStatForNPCs(DependabilityMin, DependabilityMax);
            npc.WantedLevel = Convert.ToByte(Random.Range(0, 2));
            npc.Motherland = MotherlandSelector(tempCountries);
            npc.CurrentLocation = CurrentLocationSelector(tempCities);
            npc.Name = NameSelector(npc.Motherland.Name, npc.IsMale);
            npc.InPrison = SelectNPCInPrison();
            npc.IsOnARun = SelectNPCIsRunning();

            //Skills
            npc.OperatingLevel = SelectByteStatForNPCs(OperatingLevelMin, OperatingLevelMax);
            npc.BusinessLevel = SelectByteStatForNPCs(BusinessLevelMin, BusinessLevelMax);
            npc.CharmLevel = SelectByteStatForNPCs(CharmLevelMin, CharmLevelMax);
            npc.IntelligenceLevel = SelectByteStatForNPCs(IntelligenceLevelMin, IntelligenceLevelMax);
            npc.PowerLevel = SelectByteStatForNPCs(PowerLevelMin, PowerLevelMax);
            npc.StealthLevel = SelectByteStatForNPCs(StealthLevelMin, StealthLevelMax);
            npc.HandinessLevel = SelectByteStatForNPCs(HandinessLevelMin, HandinessLevelMax);
            npc.TechLevel = SelectByteStatForNPCs(TechLevelMin, TechLevelMax);
            npc.LikesLoudStyle = System.Convert.ToBoolean(Random.Range(0, 2));
            if (npc.Level >= CharacterCreationSettings.WORKER_BECOMES_SCIENTIST_LEVEL_THRESHOLD && npc.FocusIndex == 4)
            {
                npc.IsScientist = true;
            }
            if (npc.IsScientist)
            {
                npc.LabLevel = SelectByteStatForNPCs(LabLevelMin, LabLevelMax);
            }
            else
            {
                npc.LabLevel = 0;
            }
            npc.FarmerLevel = SelectByteStatForNPCs(FarmerLevelMin, FarmerLeveLMax);
            if (npc.FocusIndex == 4)
            {
                npc.ProduceMethLevel = SelectByteStatForNPCs(ProduceMethLevelMin, ProduceMethLevelMax);
                npc.ProduceCocainLevel = SelectByteStatForNPCs(ProduceCocainLevelMin, ProduceCocainLevelMax);
                npc.ProduceWeedLevel = SelectByteStatForNPCs(ProduceWeedLevelMin, ProduceWeedLevelMax);
                npc.ProduceMDMALevel = SelectByteStatForNPCs(ProduceMDMALevelMin, ProduceMDMALevelMax);
            }
            else
            {
                npc.ProduceMethLevel = 0;
                npc.ProduceCocainLevel = 0;
                npc.ProduceWeedLevel = 0;
                npc.ProduceMDMALevel = 0;
            }
            npc.ConnectionsLevel = SelectByteStatForNPCs(ConnectionsLevelMin, ConnectionsLevelMax);
            npc.TransporterLevel = SelectByteStatForNPCs(TransporterLevelMin, TransporterLevelMax);
            if (npc.FocusIndex == 7)
            {
                npc.IsAccountant = true;
                npc.MoneyLaunderingLevel = SelectByteStatForNPCs(MoneyLaunderingLevelMin, MoneyLaunderingLevelMax);
            }
            else
            {
                npc.IsAccountant = false;
                npc.MoneyLaunderingLevel = 0;
            }
            if (npc.FocusIndex == 8)
            {
                npc.BarPass = true;
                npc.LawyeringLevel = SelectByteStatForNPCs(LawyeringLevelMin, LawyeringLevelMax);
            }
            else
            {
                npc.BarPass = false;
                npc.LawyeringLevel = 0;
            }

            NPCs.Add(npc);
        }
    }
    public static void CreateCustomNPC()
    {
        //The code of custom npc's will be here
    }
    #endregion

    #region Executions
    public void ExecuteNPCStartUp()
    {
        CreateNPCsForNewSave(false);
    }
    #endregion
}
