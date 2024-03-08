using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using OutputController;

//This scene (Main) needs to be loaded after the storage methods are executed.
public class GameController : MonoBehaviour
{
    #region Storages
    public static CharacterStorage characterStorage = new CharacterStorage();
    public static ItemStorage itemStorage = new ItemStorage();
    public static OrganizationStorage organizationStorage = new OrganizationStorage();
    public static LocationStorage locationStorage = new LocationStorage();
    public static DrugStorage drugStorage = new DrugStorage();
    #endregion

    public static GameDate gameDate = new GameDate();

    private void Start()
    {
        InvokeRepeating("RealTimer", 0f, 1f);

        BuildNewStorages(); //This line is executed in startup it needs to be at START button input.
    }

    #region RealTimer
    static byte SecondPassed = 0;
    static byte MinutePassed = 0;
    static byte HourPassed = 0;
    static byte DayPassed = 0;
    static byte MonthPassed = 0;

    private void RealTimer()
    {
        SecondPassed++;
        if (SecondPassed == 60) { MinutePassed++; SecondPassed = 0; }
        if (MinutePassed == 60) { HourPassed++; MinutePassed = 0; }
        if (HourPassed == 24) { DayPassed++; HourPassed = 0; }
        if (DayPassed == 30) { MonthPassed++; DayPassed = 0; }
    }
    #endregion

    public void BuildNewStorages()
    {
        StartCoroutine(WaitForOneFrame());
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
    }

    private IEnumerator WaitForOneFrame()
    {
        yield return null;
    }
}
