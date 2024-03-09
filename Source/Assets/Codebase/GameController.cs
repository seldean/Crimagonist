using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using OutputController;
    //OutputController is a namespace to filter outputs /Assets/Codebase/dlls/OutputController.cs

//This scene (Main) needs to be loaded after the storage methods are executed.
public class GameController : MonoBehaviour {
    //These storages hold all the "non-unity object" data to use in runtime
    #region Storages
    public static CharacterStorage characterStorage = new CharacterStorage();
    public static ItemStorage itemStorage = new ItemStorage();
    public static OrganizationStorage organizationStorage = new OrganizationStorage();
    public static LocationStorage locationStorage = new LocationStorage();
    public static DrugStorage drugStorage = new DrugStorage();
    public static CrimeStorage crimeStorage = new CrimeStorage();
    public static TrialStorage trialStorage = new TrialStorage();
    public static PerkStorage perkStorage = new PerkStorage();
    #endregion

    //In game date and time
    public static GameDate gameDate = new GameDate();

    private void Start() { //INCLUDES DEBUG VERSION ONLY ELEMENTS
        //RealTimer is the real time counter.
        InvokeRepeating("RealTimer", 0f, 1f);

        //!!!This line is executed in startup! It needs to be at START button in the New Save panel.
        //The reason this code stands here is for debugging reasons. When this script is present in a scene it auto creates data storages.
        BuildNewStorages();
    }

    //RealTimer region is a real time counter
    #region RealTimer
    //Variables to count the real time while game is open
    static byte SecondPassed = 0;
    static byte MinutePassed = 0;
    static byte HourPassed = 0;
    static byte DayPassed = 0;
    static byte MonthPassed = 0;

    //This method is called every second
    private void RealTimer() {
        SecondPassed++;
        if (SecondPassed == 60) { MinutePassed++; SecondPassed = 0; }
        if (MinutePassed == 60) { HourPassed++; MinutePassed = 0; }
        if (HourPassed == 24) { DayPassed++; HourPassed = 0; }
        if (DayPassed == 30) { MonthPassed++; DayPassed = 0; }
    }
    #endregion

    //This method prepares the storages for a new game
    public void BuildNewStorages() {
        StartCoroutine(WaitForOneFrame()); //Waiting for a frame to not overwhelm the CPU
        itemStorage.ExecuteItemStartup();
        Debug.Log("Item Creation Completed.");

        StartCoroutine(WaitForOneFrame());
        locationStorage.ExecuteCityStartUp();
        Debug.Log("Locations Creation Completed.");

        StartCoroutine(WaitForOneFrame());
        drugStorage.ExecuteDrugStartUp();
        Debug.Log("Drug Creation Completed.");

        StartCoroutine(WaitForOneFrame());
        characterStorage.ExecuteNPCStartUp();
        Debug.Log("NPC Creation Completed.");

        //Organizations doesn't have a StartUp() method currently
        /*
        StartCoroutine(WaitForOneFrame());
        organizationStorage.ExecuteOrganizationStartUp();
        Debug.Log("Organization Creation Completed.");
        */
    }

    //This method is used for waiting one frame to proceed in the code
    private IEnumerator WaitForOneFrame() {
        yield return null;
    }
}
