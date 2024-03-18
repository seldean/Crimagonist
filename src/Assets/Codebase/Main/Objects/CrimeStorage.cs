using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using OutputController;

public class CrimeStorage
{
    //!!! If you add a new crime please add it to GetAllCrimes() method as well
    #region Declerations
    public static Crime Murder = new Crime("Murder", "Killing someone.", true, 30, 0, true);
    public static Crime Kidnapping = new Crime("Kidnapping", "Kidnapping someone against their will.", true, 5, 20000, false);
    public static Crime DrugTrafficking = new Crime("Drug Trafficking", "Dealing or transporting drugs.", true, 10, 100000, false);
    public static Crime OrganizedCrime = new Crime("Organized Crime", "Organized criminal activities.", true, 15, 250000, true);
    public static Crime ArmedRobbery = new Crime("Armed Robbery", "Robbing places with weapons.", true, 10, 100000, false);
    public static Crime UnarmedRobbery = new Crime("Robbery", "Robbing places.", true, 5, 50000, false);
    public static Crime OrganizedRobbery = new Crime("Organized Robbery", "Organized big robbery.", true, 15, 200000, false);
    public static Crime AutomobileTheft = new Crime("Automobile Theft", "Stealing automobiles, selling and trafficking them.", true, 5, 50000, false);
    public static Crime Terrorism = new Crime("Terrorism", "Bringing chaos, terror or fear to citizens.", true, 100, 0, true);
    public static Crime Harboring = new Crime("Harboring", "Harboring a criminal and slowing down the law.", false, 0, 10000, false);
    public static Crime OrganizingCriminalGroup = new Crime("Organizing Criminal Group", "Building an organization, running or helping an organization.", true, 15, 350000, false);
    public static Crime HumanTrafficking = new Crime("Human Trafficking", "Trafficking people around globe.", true, 10, 200000, false);
    public static Crime OrganTrafficking = new Crime("Organ Trafficking", "Trafficking organs.", true, 20, 500000, false);
    public static Crime Extortioning = new Crime("Extortioning", "Extortioning citizens.", true, 5, 10000, false);
    public static Crime Hitmaning = new Crime("Hit-Man'ing", "Receiving payments for murder.", true, 50, 0, true);
    public static Crime WeaponaryTrafficking = new Crime("Weaponary Trafficking", "Trafficking lethal weaponary.", true, 15, 500000, false);
    public static Crime Fraud = new Crime("Fraud", "Making money with fraud.", true, 5, 10000, false);
    public static Crime Racketeering = new Crime("Racketeering", "Blackmailing citizens or businesses.", true, 10, 20000, false);
    public static Crime Prostitution = new Crime("Prostitution", "Selling, employing, trafficking sex workers.", true, 3, 25000, false);
    public static Crime UnauthorizedGamble = new Crime("Unauthorized Gamble", "Managing illegal gambling.", true, 3, 35000, false);
    public static Crime InternationalLawBreach = new Crime("International Law Breaching", "Possession of state-level weaponary or big amount of state corruptioning.", true, 250, 0, true);
    public static Crime Fugitive = new Crime("Fugitive", "Escaping from law.", true, 10, 250000, false);
    #endregion

    //If a new Crime is added, it needs be in this array as well
    public static List<Crime> GetAllCrimes()
    {
        List<Crime> Crimes = new List<Crime>
        {
            Murder,
            Kidnapping,
            DrugTrafficking,
            OrganizedCrime,
            ArmedRobbery,
            UnarmedRobbery,
            OrganizedRobbery,
            AutomobileTheft,
            Terrorism,
            Harboring,
            OrganizingCriminalGroup,
            HumanTrafficking,
            OrganTrafficking,
            Extortioning,
            Hitmaning,
            WeaponaryTrafficking,
            Fraud,
            Racketeering,
            Prostitution,
            UnauthorizedGamble,
            InternationalLawBreach,
            Fugitive
        };
        return Crimes;
    }
}
