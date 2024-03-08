using System.Collections.Generic;
using UnityEngine;
using OutputController;

#region Rules
public static class OrganizationCreationSettings
{
    public const uint COUNT_OF_ORGANIZATIONS_FOR_LARGE_CITY = 5;
    public const uint COUNT_OF_LARGE_ORGANIZATIONS_FOR_LARGE_CITY = COUNT_OF_ORGANIZATIONS_FOR_LARGE_CITY / 5;
    public const uint COUNT_OF_ORGANIZATIONS_FOR_SMALL_CITY = 1;
    public const ushort MIN_LEVEL_OF_OWNER_NPC_AT_STARTUP = 10000;
}
public static class OrganizationSettings
{
    public const byte THRESHOLD_FOR_ORG_MANIFEST = 10;
}
public static class OrganizationLayerSettings
{
    public const string Top = "Top";
    public const string Middle = "Middle";
    public const string Bottom = "Bottom";
    public const string Free = "Free";
}
#endregion

#region Declerations
public class Organization
{
    #region Declerations
    public string Name { get; set; }
    //Base variables of organizations.
    public byte Authority { get; set; }
    public byte Loyalty { get; set; }
    public byte PullForce { get; set; }

    //Perk
    public uint PerkPoints { get; set; }
    public List<OrganizationPerk> Perks { get; set; }

    //Management
    public bool IsOneManSystem { get; set; }
    public Player PlayerLeader { get; set; }
    public NPC NPCLeader { get; set; }
    public bool isLeaderAPlayer { get; set; }
    public List<Player> CouncilMemberPlayers { get; set; }
    public List<NPC> CouncilMemberNPCs { get; set; }
    public Player HeadConnectorPlayer { get; set; }
    public NPC HeadConnectorNPC { get; set; }
    public Player HeadPlannerPlayer { get; set; }
    public NPC HeadPlannerNPC { get; set; }
    public Player HeadLawyerPlayer { get; set; }
    public NPC HeadLawyerNPC { get; set; }
    public Player HeadAccountantPlayer { get; set; }
    public NPC HeadAccountantNPC { get; set; }
    public bool IsCentralized { get; set; }
    public string OrganizationLayer { get; set; }

    //The cities this organization is manifested itself in.
    public List<City> ManifestedCities { get; set; }

    //Policies. Note: If you added a new policy, please modify it's effect to PullForce in "CalculatePullForceAtCreation" method.
    public bool IsCiviliansAreNotImportant { get; set; }
    public bool IsOkayWithOrganizedRobberies { get; set; }
    public bool IsOkayWithDrugTrafficking { get; set; }
    public bool IsOkayWithHumanTrafficking { get; set; }
    public bool IsOkayWithOrganTrafficking { get; set; }
    public bool IsOkayWithExtortioning { get; set; }
    public bool IsOkayWithAssassinationJobs { get; set; }
    public bool IsOkayWithArmsTrafficking { get; set; }
    public bool IsOkayWithFraud { get; set; }
    public bool IsOkayWithRacketeering { get; set; }
    public bool IsOkayWithProstitution { get; set; }
    public bool IsOkayWithIllegalGambling { get; set; }

    public ushort LevelLimitation { get; set; }
    public List<Player> InvolvedPlayers { get; set; }
    public List<NPC> InvolvedNPCs { get; set; }

    //Pyramid structure of organizations. Also known as "Layers" and "Floors".
    public Organization UmbrellaOrganization { get; set; }
    public List<Organization> SubOrganizations { get; set; }
    public List<Organization> FriendlyOrganizations { get; set; }
    public List<Organization> EnemyOrganizations { get; set; }
    #endregion

    #region Constructor
    public Organization(string name, bool isOneManSystem, bool isBuilderPlayer, Player playerBuilder, NPC npcBuilder, bool isCentralized, string organizationLayer, bool isCiviliansAreNotImportant, bool isRobberiesOK, bool isDrugsOK, bool isHumanTraffickingOK, bool isOrganTraffickingOK, bool isExtortioningOK, bool isAssassinJobsOK, bool isArmsTraffickingOK, bool isFraudOK, bool isRacketeeringOK, bool isProstitutionOK, bool isIllegalGamblingOK, List<Player> addedCouncilMemberPlayers, List<NPC> addedCouncilMemberNPCs)
    {
        Name = name;
        Authority = 10;
        Loyalty = 50;
        PullForce = 50;
        PerkPoints = 0;
        Perks = new List<OrganizationPerk>();
        IsOneManSystem = isOneManSystem;
        PlayerLeader = null;
        NPCLeader = null;
        isLeaderAPlayer = isBuilderPlayer;
        CouncilMemberPlayers = new List<Player>();
        CouncilMemberNPCs = new List<NPC>();
        HeadConnectorPlayer = null;
        HeadConnectorNPC = null;
        HeadPlannerPlayer = null;
        HeadPlannerNPC = null;
        HeadLawyerPlayer = null;
        HeadLawyerNPC = null;
        HeadAccountantPlayer = null;
        HeadAccountantNPC = null;
        IsCentralized = isCentralized;
        OrganizationLayer = organizationLayer;

        ManifestedCities = new List<City>();

        IsCiviliansAreNotImportant = isCiviliansAreNotImportant;
        IsOkayWithOrganizedRobberies = isRobberiesOK;
        IsOkayWithDrugTrafficking = isDrugsOK;
        IsOkayWithHumanTrafficking = isHumanTraffickingOK;
        IsOkayWithOrganTrafficking = isOrganTraffickingOK;
        IsOkayWithExtortioning = isExtortioningOK;
        IsOkayWithAssassinationJobs = isAssassinJobsOK;
        IsOkayWithArmsTrafficking = isArmsTraffickingOK;
        IsOkayWithFraud = isFraudOK;
        IsOkayWithRacketeering = isRacketeeringOK;
        IsOkayWithProstitution = isProstitutionOK;
        IsOkayWithIllegalGambling = isIllegalGamblingOK;

        LevelLimitation = 0;
        RefreshLevelLimitation();

        if (playerBuilder != null)
        {
            CouncilMemberPlayers.Add(playerBuilder);
        }
        if (npcBuilder != null)
        {
            CouncilMemberNPCs.Add(npcBuilder);
        }
        if (addedCouncilMemberPlayers != null)
        {
            for (int i = 0; i < addedCouncilMemberPlayers.Count; i++)
            {
                CouncilMemberPlayers.Add(addedCouncilMemberPlayers[i]);
            }
        }
        if (addedCouncilMemberNPCs != null)
        {
            for (int i = 0; i < addedCouncilMemberNPCs.Count; i++)
            {
                CouncilMemberNPCs.Add(addedCouncilMemberNPCs[i]);
            }
        }

        //Leader & Authority
        if (isBuilderPlayer)
        {
            if (isOneManSystem) { PlayerLeader = playerBuilder; } else { PlayerLeader = null; }
            Authority = CalculateAuthorityAtCreation(playerBuilder.Renown, playerBuilder.Dependability, playerBuilder.Level);
        }
        else
        {
            if (isOneManSystem) { NPCLeader = npcBuilder; } else { NPCLeader = null; }
            Authority = CalculateAuthorityAtCreation(npcBuilder.Renown, npcBuilder.Dependability, npcBuilder.Level);
        }

        PullForce = CalculatePullForceAtCreation();

        InvolvedPlayers = new List<Player>();
        foreach (Player pl in CouncilMemberPlayers)
        {
            InvolvedPlayers.Add(pl);
        }
        InvolvedNPCs = new List<NPC>();
        foreach (NPC npc in CouncilMemberNPCs)
        {
            InvolvedNPCs.Add(npc);
        }

        UmbrellaOrganization = null;
        SubOrganizations = new List<Organization>();
        FriendlyOrganizations = new List<Organization>();
        EnemyOrganizations = new List<Organization>();
    }
    #endregion

    #region Methods
    //Triggers
    public void TriggerDaily()
    {

    }
    public void TriggerWeekly()
    {

    }
    public void TriggerMonthly()
    {
        
    }
    public void TriggerYearly()
    {

    }

    public void ChangeName(string newName)
    {
        Name = newName;
    }

    public void RefreshLevelLimitation()
    {
        ushort tempLevelLimitation = 0;
        byte countOfPoliciesApplied = 0;

        if (IsOkayWithOrganizedRobberies) { tempLevelLimitation += 1000; countOfPoliciesApplied++; }
        if (IsOkayWithDrugTrafficking) { tempLevelLimitation += 1000; countOfPoliciesApplied++; }
        if (IsOkayWithHumanTrafficking) { tempLevelLimitation += 1000; countOfPoliciesApplied++; }
        if (IsOkayWithOrganTrafficking) { tempLevelLimitation += 1000; countOfPoliciesApplied++; }
        if (IsOkayWithExtortioning) { tempLevelLimitation += 500; countOfPoliciesApplied++; }
        if (IsOkayWithAssassinationJobs) { tempLevelLimitation += 1000; countOfPoliciesApplied++; }
        if (IsOkayWithArmsTrafficking) { tempLevelLimitation += 1000; countOfPoliciesApplied++; }
        if (IsOkayWithFraud) { tempLevelLimitation += 500; countOfPoliciesApplied++; }
        if (IsOkayWithRacketeering) { tempLevelLimitation += 1000; countOfPoliciesApplied++; }
        if (IsOkayWithProstitution) { tempLevelLimitation += 1000; countOfPoliciesApplied++; }
        if (IsOkayWithIllegalGambling) { tempLevelLimitation += 1000; countOfPoliciesApplied++; }

        if (countOfPoliciesApplied <= 2)
        {
            tempLevelLimitation = 0;
        }

        LevelLimitation = tempLevelLimitation;
    }

    private byte CalculateAuthorityAtCreation(ushort renown, ushort dependability, ushort level)
    {
        byte authority = 0;

        if (IsOneManSystem)
        {
            authority = Convert.ToByte(((renown + dependability) / 10) + (level / 1000));
            if (!(LevelLimitation == 0))
            {
                if (level < LevelLimitation - 100)
                {
                    authority = Convert.ToByte(authority - 15);
                }
            }
        }
        else
        {
            byte councilMemberCount = Convert.ToByte(CouncilMemberPlayers.Count + CouncilMemberNPCs.Count);
            uint sumOfCouncilMembersRenown = 0;
            uint sumOfCouncilMembersDependability = 0;
            uint sumOfCouncilMemberLevels = 0;

            for (int i = 0; i < CouncilMemberPlayers.Count; i++)
            {
                sumOfCouncilMembersRenown += CouncilMemberPlayers[i].Renown;
                sumOfCouncilMembersDependability += CouncilMemberPlayers[i].Dependability;
                sumOfCouncilMemberLevels += CouncilMemberPlayers[i].Level;
            }
            for (int i = 0; i < CouncilMemberNPCs.Count; i++)
            {
                sumOfCouncilMembersRenown += CouncilMemberNPCs[i].Renown;
                sumOfCouncilMembersDependability += CouncilMemberNPCs[i].Dependability;
                sumOfCouncilMemberLevels += CouncilMemberNPCs[i].Level;
            }

            authority = Convert.ToByte(((sumOfCouncilMembersRenown + sumOfCouncilMembersDependability) / (councilMemberCount * 10)) + (sumOfCouncilMemberLevels / (councilMemberCount * 1000)));
        }
        
        return authority;
    }
    /*
    public void UpdateAuthority()
    {
        byte authority = 0;

        if (IsOneManSystem)
        {
            if (isLeaderAPlayer)
            {
                authority = Convert.ToByte(((PlayerLeader.Renown + PlayerLeader.Dependability) / 10) + (PlayerLeader.Level / 1000));
                if (!(LevelLimitation == 0))
                {
                    if (PlayerLeader.Level < LevelLimitation - 100)
                    {
                        Authority = Convert.ToByte(authority - 15);
                    }
                }
            }
            else
            {
                authority = Convert.ToByte(((NPCLeader.Renown + NPCLeader.Dependability) / 10) + (NPCLeader.Level / 1000));
                if (!(LevelLimitation == 0))
                {
                    if (NPCLeader.Level < LevelLimitation - 100)
                    {
                        Authority = Convert.ToByte(authority - 15);
                    }
                }
            }
        }
        else
        {
            byte councilMemberCount = Convert.ToByte(CouncilMemberPlayers.Count + CouncilMemberNPCs.Count);
            uint sumOfCouncilMembersRenown = 0;
            uint sumOfCouncilMembersDependability = 0;
            uint sumOfCouncilMemberLevels = 0;

            for (int i = 0; i < CouncilMemberPlayers.Count; i++)
            {
                sumOfCouncilMembersRenown += CouncilMemberPlayers[i].Renown;
                sumOfCouncilMembersDependability += CouncilMemberPlayers[i].Dependability;
                sumOfCouncilMemberLevels += CouncilMemberPlayers[i].Level;
            }
            for (int i = 0; i < CouncilMemberNPCs.Count; i++)
            {
                sumOfCouncilMembersRenown += CouncilMemberNPCs[i].Renown;
                sumOfCouncilMembersDependability += CouncilMemberNPCs[i].Dependability;
                sumOfCouncilMemberLevels += CouncilMemberNPCs[i].Level;
            }

            Authority = Convert.ToByte(((sumOfCouncilMembersRenown + sumOfCouncilMembersDependability) / (councilMemberCount * 10)) + (sumOfCouncilMemberLevels / (councilMemberCount * 1000)));
        }
    } */ //suspended due to being unconnectable with ChangeAuthority method.
    public void ChangeAuthority(sbyte amount)
    {
        Authority = Convert.ToByte(Authority + amount);
    }

    public void ChangeLoyalty(sbyte amount)
    {
        Loyalty = Convert.ToByte(Loyalty + amount);
    }

    private byte CalculatePullForceAtCreation()
    {
        uint pullForce = 0;

        if (!IsCiviliansAreNotImportant)
        {
            pullForce += 30;
        }
        if (!IsOkayWithOrganizedRobberies)
        {
            pullForce += 10;
        }
        if (!IsOkayWithDrugTrafficking)
        {
            pullForce += 30;
        }
        if (!IsOkayWithHumanTrafficking)
        {
            pullForce += 10;
        }
        if (!IsOkayWithOrganTrafficking)
        {
            pullForce += 50;
        }
        if (!IsOkayWithExtortioning)
        {
            pullForce += 5;
        }
        if (!IsOkayWithAssassinationJobs)
        {
            pullForce += 15;
        }
        if (!IsOkayWithArmsTrafficking)
        {
            pullForce += 0;
        }
        if (!IsOkayWithFraud)
        {
            pullForce += 5;
        }
        if (!IsOkayWithRacketeering)
        {
            pullForce += 5;
        }
        if (!IsOkayWithProstitution)
        {
            pullForce += 5;
        }
        if (!IsOkayWithIllegalGambling)
        {
            pullForce += 5;
        }

        return Convert.ToByte(pullForce);
    }
    public void ChangePullForce(sbyte amount)
    {
        PullForce = Convert.ToByte(PullForce + amount);
    }

    public void AddPerkPoint(byte amount)
    {
        PerkPoints = Convert.ToUInt(PerkPoints + amount);
        GameMessageScript.Notification("Organization perk points has increased by " + amount + ".", CouncilMemberPlayers, Color.green, true);
    }
    public void AddPerk(OrganizationPerk newPerk)
    {
        Perks.Add(newPerk);
        GameMessageScript.Notification("Organization has the " + newPerk.Name + " perk now.", CouncilMemberPlayers, Color.green, true);
    }

    public void SetOneManSystem(bool isOneManSystem)
    {
        IsOneManSystem = isOneManSystem;
    }

    public void ChangeLeaderNPC(NPC newNPC)
    {
        NPCLeader = newNPC;
        isLeaderAPlayer = false;
        PlayerLeader = null;
    }
    public void ChangeLeaderPlayer(Player newPlayer)
    {
        PlayerLeader = newPlayer;
        isLeaderAPlayer = true;
        NPCLeader = null;
    }

    public void MakeAPlayerCouncilMember(Player player)
    {
        if (!CouncilMemberPlayers.Contains(player))
        {
            if (InvolvedPlayers.Contains(player))
            {
                CouncilMemberPlayers.Add(player);
                GameMessageScript.Notification("New council member: " + player.Name + ".", InvolvedPlayers, Color.green, true);
            }
        }
    }
    public void RemoveAPlayerFromCouncil(Player player)
    {
        if (CouncilMemberPlayers.Contains(player))
        {
            CouncilMemberPlayers.Remove(player);
            GameMessageScript.Notification("Council member " + player.Name + " left the council.", InvolvedPlayers, Color.green, true);
        }
    }
    public void MakeAnNPCCouncilMember(NPC npc)
    {
        if (!CouncilMemberNPCs.Contains(npc))
        {
            if (InvolvedNPCs.Contains(npc))
            {
                CouncilMemberNPCs.Add(npc);
                GameMessageScript.Notification("New council member: " + npc.Name + ".", InvolvedPlayers, Color.green, true);
            }
        }
    }
    public void RemoveAnNPCFromCouncil(NPC npc)
    {
        if (CouncilMemberNPCs.Contains(npc))
        {
            CouncilMemberNPCs.Remove(npc);
            GameMessageScript.Notification("Council member " + npc.Name + " left the council.", InvolvedPlayers, Color.green, true);
        }
    }

    public void MakeAPlayerHeadConnector(Player player)
    {
        HeadConnectorPlayer = player;
        HeadConnectorNPC = null;
        GameMessageScript.Notification("New 'Head Connector' title holder: " + player.Name + ".", InvolvedPlayers, Color.green, true);
    }
    public void MakeAnNPCHeadConnector(NPC npc)
    {
        HeadConnectorNPC = npc;
        HeadConnectorPlayer = null;
        GameMessageScript.Notification("New 'Head Connector' title holder: " + npc.Name + ".", InvolvedPlayers, Color.green, true);
    }
    public void RemoveHeadConnector()
    {
        HeadConnectorPlayer = null;
        HeadConnectorNPC = null;
    }
    public void MakeAPlayerHeadPlanner(Player player)
    {
        HeadPlannerPlayer = player;
        HeadPlannerNPC = null;
        GameMessageScript.Notification("New 'Head Planner' title holder: " + player.Name + ".", InvolvedPlayers, Color.green, true);
    }
    public void MakeAnNPCHeadPlanner(NPC npc)
    {
        HeadPlannerNPC = npc;
        HeadPlannerPlayer = null;
        GameMessageScript.Notification("New 'Head Planner' title holder: " + npc.Name + ".", InvolvedPlayers, Color.green, true);
    }
    public void RemoveHeadPlanner()
    {
        HeadPlannerPlayer = null;
        HeadPlannerNPC = null;
    }
    public void MakeAPlayerHeadLawyer(Player player)
    {
        HeadLawyerPlayer = player;
        HeadLawyerNPC = null;
        GameMessageScript.Notification("New 'Head Lawyer' title holder: " + player.Name + ".", InvolvedPlayers, Color.green, true);
    }
    public void MakeAnNPCHeadLawyer(NPC npc)
    {
        HeadLawyerNPC = npc;
        HeadLawyerPlayer = null;
        GameMessageScript.Notification("New 'Head Lawyer' title holder: " + npc.Name + ".", InvolvedPlayers, Color.green, true);
    }
    public void RemoveHeadLawyer()
    {
        HeadLawyerPlayer = null;
        HeadLawyerNPC = null;
    }
    public void MakeAPlayerHeadAccountant(Player player)
    {
        HeadAccountantPlayer = player;
        HeadAccountantNPC = null;
        GameMessageScript.Notification("New 'Head Accountant' title holder: " + player.Name + ".", InvolvedPlayers, Color.green, true);
    }
    public void MakeANNPCHeadAccountant(NPC npc)
    {
        HeadAccountantNPC = npc;
        HeadAccountantPlayer = null;
        GameMessageScript.Notification("New 'Head Accountant' title holder: " + npc.Name + ".", InvolvedPlayers, Color.green, true);
    }
    public void RemoveHeadAccountant()
    {
        HeadAccountantPlayer = null;
        HeadAccountantNPC = null ;
    }

    public void AddAPlayer(Player player)
    {
        if (!InvolvedPlayers.Contains(player))
        {
            if (player.Level >= LevelLimitation)
            {
                GameMessageScript.Notification("New participant in organization: " + player.Name + ".", InvolvedPlayers, Color.green, true);
                InvolvedPlayers.Add(player);
            }
        }
    }
    public void RemoveAPlayer(Player player)
    {
        if (InvolvedPlayers.Contains(player))
        {
            InvolvedPlayers.Remove(player);
            GameMessageScript.Notification("Participant left the organization: " + player.Name + ".", InvolvedPlayers, Color.green, true);
        }
    }

    public void AddAnNPC(NPC npc)
    {
        if (!InvolvedNPCs.Contains(npc))
        {
            if (npc.Level >= LevelLimitation)
            {
                GameMessageScript.Notification("New participant in organization: " + npc.Name + ".", InvolvedPlayers, Color.green, true);
                InvolvedNPCs.Add(npc);
            }
        }
    }
    public void RemoveAnNPC(NPC npc)
    {
        if (InvolvedNPCs.Contains(npc))
        {
            InvolvedNPCs.Remove(npc);
            GameMessageScript.Notification("Participant left the organization: " + npc.Name + ".", InvolvedPlayers, Color.green, true);
        }
    }

    public void SetIsCentralized(bool isCentralized)
    {
        IsCentralized = isCentralized;
    }

    public void SetPolicies(bool isCiviliansAreNotImportant, bool isRobberiesOK, bool isDrugsOK, bool isHumanTraffickingOK, bool isOrganTraffickingOK, bool isExtortioningOK, bool isAssassinJobsOK, bool isArmsTraffickingOK, bool isFraudOK, bool isRacketeeringOK, bool isProstitutionOK, bool isIllegalGamblingOK)
    {
        IsCiviliansAreNotImportant = isCiviliansAreNotImportant;
        IsOkayWithOrganizedRobberies = isRobberiesOK;
        IsOkayWithDrugTrafficking = isDrugsOK;
        IsOkayWithHumanTrafficking = isHumanTraffickingOK;
        IsOkayWithOrganTrafficking = isOrganTraffickingOK;
        IsOkayWithExtortioning = isExtortioningOK;
        IsOkayWithAssassinationJobs = isAssassinJobsOK;
        IsOkayWithArmsTrafficking = isArmsTraffickingOK;
        IsOkayWithFraud = isFraudOK;
        IsOkayWithRacketeering = isRacketeeringOK;
        IsOkayWithProstitution = isProstitutionOK;
        IsOkayWithIllegalGambling = isIllegalGamblingOK;
        RefreshLevelLimitation();
    }

    //NEEDS REWORK ABOUT RELATIONS BETWEEN ORGANIZATIONS, THAT HAS BEEN ADDED TO THE TO-DO LIST
    public void UpdateOrganizationLayer(string layer)
    {
        switch (layer)
        {
            case "Top":
                ChangeUmbrellaOrganization(null);
                GameMessageScript.Notification("Your organization is now at the top layer and can hold Sub-Organizations.", InvolvedPlayers, Color.green, true);
                break;
            case "Middle":
                GameMessageScript.Notification("Your organization is now at the middle layer and can hold Sub-Organizations.", InvolvedPlayers, Color.green, true);
                break;
            case "Bottom":
                RemoveAllSubOrganizations();
                GameMessageScript.Notification("Your organization is now at the bottom layer and can NOT hold Sub-Organizations.", InvolvedPlayers, Color.yellow, true);
                break;
            case "Free":
                RemoveAllSubOrganizations();
                ChangeUmbrellaOrganization(null, "");
                GameMessageScript.Notification("Your organizations is now at the free layer, can NOT hold Sub-Organizations and can NOT be a subject of others (unless council or leader wants to).", InvolvedPlayers, Color.green, true);
                break;
            default:
                break;
        }
    }

    public void ChangeUmbrellaOrganization(Organization umbrellaOrganization, string startingLayer = "Bottom")
    {
        if (!SubOrganizations.Contains(umbrellaOrganization))
        {
            UmbrellaOrganization = umbrellaOrganization;
            if (UmbrellaOrganization != null)
            {
                if (UmbrellaOrganization.OrganizationLayer == "Top") {
                    UpdateOrganizationLayer(startingLayer);
                }
                else {
                    UpdateOrganizationLayer("Bottom");
                }
                if (EnemyOrganizations.Contains(umbrellaOrganization)) {
                    EnemyOrganizations.Remove(umbrellaOrganization);
                }

                GameMessageScript.Notification("Your organization is now a subject of " + umbrellaOrganization.Name + ".", InvolvedPlayers, Color.yellow, true);
            }
            else
            {
                if (SubOrganizations.Count >= 1)
                {
                    UpdateOrganizationLayer("Top");
                }
                else
                {
                    UpdateOrganizationLayer("Free");
                }
            }
        }
        else
        {
            GameMessageScript.Notification("The organization you wanted as your master is your subject!", CouncilMemberPlayers, Color.red, true);
        }
    }

    public void AddSubOrganization(Organization addedOrganization)
    {
        if (!SubOrganizations.Contains(addedOrganization) && UmbrellaOrganization != addedOrganization && OrganizationLayer != "Bottom")
        {
            SubOrganizations.Add(addedOrganization);
            addedOrganization.ChangeUmbrellaOrganization(this);
            GameMessageScript.Notification("Your organization is now the master of " + addedOrganization.Name + ".", InvolvedPlayers, Color.green, true);
        }
        else
        {
            GameMessageScript.Notification("The organization you wanted to subjucate is can not be a subject. It can be already in Sub-Organizations. It can be your master. You could be a bottom-layer organization.", CouncilMemberPlayers, Color.red, false);
        }
    }
    public void RemoveSubOrganization(Organization removedOrganization)
    {
        if (SubOrganizations.Contains(removedOrganization)) {
            SubOrganizations.Remove(removedOrganization);
            GameMessageScript.Notification(removedOrganization.Name + " is no longer our subject.", CouncilMemberPlayers, Color.yellow, true);
            GameMessageScript.Notification("We are no longer subject of " + Name, removedOrganization.CouncilMemberPlayers, Color.green, true);

            if (UmbrellaOrganization != null) {
                UmbrellaOrganization.AddSubOrganization(removedOrganization);
            }
        }
    }
    public void RemoveAllSubOrganizations()
    {
        foreach (Organization organization in SubOrganizations) {
            SubOrganizations.Remove(organization);

            if (UmbrellaOrganization != null) {
                UmbrellaOrganization.AddSubOrganization(organization);
            }
        }
    }

    public void AddFriendlyOrganization(Organization addedOrganization)
    {
        if (!FriendlyOrganizations.Contains(addedOrganization))
        {
            FriendlyOrganizations.Add(addedOrganization);
            GameMessageScript.Notification("Our organization now have friendly relations with " + addedOrganization.Name + ".", CouncilMemberPlayers, Color.green, true);
            if (EnemyOrganizations.Contains(addedOrganization))
            {
                EnemyOrganizations.Remove(addedOrganization);
            }
        }
    }
    public void RemoveFriendlyOrganization(Organization removedOrganization)
    {
        if (FriendlyOrganizations.Contains(removedOrganization))
        {
            FriendlyOrganizations.Remove(removedOrganization);
            GameMessageScript.Notification("Our organization now have neutral relations with " + removedOrganization.Name + ".", CouncilMemberPlayers, Color.yellow, true);
        }
    }

    public void AddEnemyOrganization(Organization addedOrganization)
    {
        if (!EnemyOrganizations.Contains(addedOrganization))
        {
            EnemyOrganizations.Add(addedOrganization);
            GameMessageScript.Notification("Our organization have a new enemy: " + addedOrganization.Name + ".", CouncilMemberPlayers, Color.red, true);

            if (FriendlyOrganizations.Contains(addedOrganization))
            {
                FriendlyOrganizations.Remove(addedOrganization);
            }

            if (UmbrellaOrganization == addedOrganization)
            {
                ChangeUmbrellaOrganization(null);
            }
        }
    }
    public void RemoveEnemyOrganization(Organization removedOrganization)
    {
        if (EnemyOrganizations.Contains(removedOrganization))
        {
            EnemyOrganizations.Remove(removedOrganization);
            GameMessageScript.Notification("Our organization is NO longer the enemy of " + removedOrganization.Name + ".", CouncilMemberPlayers, Color.green, true);
        }
    }

    public void ManifestInCity(City city)
    {
        if (!ManifestedCities.Contains(city))
        {
            byte counter = 0;

            foreach (Player player in InvolvedPlayers)
            {
                if (player.CurrentLocation == city)
                {
                    counter++;
                    if (counter >= OrganizationSettings.THRESHOLD_FOR_ORG_MANIFEST && !ManifestedCities.Contains(city))
                    {
                        ManifestedCities.Add(city);
                        GameMessageScript.Notification("Our organization manifested itself in " + city.Name + ".", CouncilMemberPlayers, Color.green, true);
                        break;
                    }
                }
            }

            foreach (NPC npc in InvolvedNPCs)
            {
                if (npc.CurrentLocation == city)
                {
                    counter++;
                    if (counter >= OrganizationSettings.THRESHOLD_FOR_ORG_MANIFEST && !ManifestedCities.Contains(city))
                    {
                        ManifestedCities.Add(city);
                        GameMessageScript.Notification("Our organization manifested itself in " + city.Name + ".", CouncilMemberPlayers, Color.green, true);
                        break;
                    }
                }
            }
        }
    }
    #endregion
}
#endregion
