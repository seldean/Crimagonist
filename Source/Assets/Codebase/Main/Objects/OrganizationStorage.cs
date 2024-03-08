using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OutputController;

public class OrganizationStorage
{
    public static List<Organization> Organizations = new List<Organization>();

    public void CreateOrganization(string name, bool isOneManSystem, bool isBuilderPlayer, Player playerBuilder, NPC npcBuilder, bool isCentralized, string organizationLayer, bool isCiviliansAreNotImportant, bool isRobberiesOK, bool isDrugsOK, bool isHumanTraffickingOK, bool isOrganTraffickingOK, bool isExtortioningOK, bool isAssassinJobsOK, bool isArmsTraffickingOK, bool isFraudOK, bool isRacketeeringOK, bool isProstitutionOK, bool isIllegalGamblingOK, List<Player> addedCouncilMemberPlayers, List<NPC> addedCouncilMemberNPCs)
    {
        Organization organization = new Organization(name, isOneManSystem, isBuilderPlayer, playerBuilder, npcBuilder, isCentralized, organizationLayer, isCiviliansAreNotImportant, isRobberiesOK, isDrugsOK, isHumanTraffickingOK, isOrganTraffickingOK, isExtortioningOK, isAssassinJobsOK, isArmsTraffickingOK, isFraudOK, isRacketeeringOK, isProstitutionOK, isIllegalGamblingOK, addedCouncilMemberPlayers, addedCouncilMemberNPCs);
        Organizations.Add(organization);
    }

    public static void CreateCustomOrganizations()
    {
        //Custom organizations will be builded in here
    }
}
