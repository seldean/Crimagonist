using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using OutputController;

public class MidDivContentOutput : MonoBehaviour
{
    //IN THIS DEBUGGING SCRIPT PLEASE USE COROUTINES TO NOT FREEZE THE GAME

    public GameObject prefabCharacterEntry;
    public TMP_Text showed_data_amount;
    int dataCount = 0;

    private void ClearData()
    {
        // Loop through all children of the parent transform
        for (int i = transform.childCount - 1; i >= 0; i--)
        {
            // Destroy the child game object
            Destroy(transform.GetChild(i).gameObject);
        }
    }

    public void StopCoroutines()
    {
        StopAllCoroutines();
    }

    public void StartCharacterListing()
    {
        ClearData();
        StartCoroutine(ShowCharacters());
    }
    public IEnumerator ShowCharacters()
    {
        //Players listed first
        foreach (Player pl in CharacterStorage.Players)
        {
            GameObject newEntry = Instantiate(prefabCharacterEntry, transform.position, Quaternion.identity, transform);

            foreach (Transform child in newEntry.transform)
            {
                switch (child.name)
                {
                    case "Name":
                        TMP_Text nameText = child.GetComponent<TMP_Text>();
                        if (nameText != null)
                            nameText.text = "Name: " + pl.Name;
                        break;
                    case "Age":
                        TMP_Text ageText = child.GetComponent<TMP_Text>();
                        if (ageText != null)
                            ageText.text = " Age: " + pl.Age;
                        break;
                    case "Level":
                        TMP_Text levelText = child.GetComponent<TMP_Text>();
                        if (levelText != null)
                            levelText.text = " Level: " + pl.Level;
                        break;
                    case "XP":
                        TMP_Text xpText = child.GetComponent<TMP_Text>();
                        if (xpText != null)
                            xpText.text = " XP: " + pl.LevelXP;
                        break;
                    case "Renown":
                        TMP_Text renownText = child.GetComponent<TMP_Text>();
                        if (renownText != null)
                            renownText.text = " Renown: " + pl.Renown;
                        break;
                    case "Dependability":
                        TMP_Text dependabilityText = child.GetComponent<TMP_Text>();
                        if (dependabilityText != null)
                            dependabilityText.text = " Dependability: " + pl.Dependability;
                        break;
                    case "WantedLevel":
                        TMP_Text wantedLevelText = child.GetComponent<TMP_Text>();
                        if (wantedLevelText != null)
                            wantedLevelText.text = " Wanted Level: " + pl.WantedLevel;
                        break;
                    case "MotherLand":
                        TMP_Text motherlandText = child.GetComponent<TMP_Text>();
                        if (motherlandText != null)
                            motherlandText.text = " Motherland: " + pl.Motherland.Name;
                        break;
                    case "CurrentLocation":
                        TMP_Text locationText = child.GetComponent<TMP_Text>();
                        if (locationText != null)
                            locationText.text = " Current Location: " + pl.CurrentLocation.Name;
                        break;
                    default:
                        break;
                }
            }
            dataCount++;
            showed_data_amount.text = "Data being showed: " + dataCount;
            yield return null;
        }

        //NPC's listed
        foreach (NPC npc in CharacterStorage.NPCs)
        {
            GameObject newEntry = Instantiate(prefabCharacterEntry, transform.position, Quaternion.identity, transform);

            foreach (Transform child in newEntry.transform)
            {
                switch (child.name)
                {
                    case "Name":
                        TMP_Text nameText = child.GetComponent<TMP_Text>();
                        if (nameText != null)
                            nameText.text = "Name: " + npc.Name;
                        break;
                    case "Age":
                        TMP_Text ageText = child.GetComponent<TMP_Text>();
                        if (ageText != null)
                            ageText.text = " Age: " + npc.Age;
                        break;
                    case "Level":
                        TMP_Text levelText = child.GetComponent<TMP_Text>();
                        if (levelText != null)
                            levelText.text = " Level: " + npc.Level;
                        break;
                    case "XP":
                        TMP_Text xpText = child.GetComponent<TMP_Text>();
                        if (xpText != null)
                            xpText.text = " XP: " + npc.LevelXP;
                        break;
                    case "Renown":
                        TMP_Text renownText = child.GetComponent<TMP_Text>();
                        if (renownText != null)
                            renownText.text = " Renown: " + npc.Renown;
                        break;
                    case "Dependability":
                        TMP_Text dependabilityText = child.GetComponent<TMP_Text>();
                        if (dependabilityText != null)
                            dependabilityText.text = " Dependability: " + npc.Dependability;
                        break;
                    case "WantedLevel":
                        TMP_Text wantedLevelText = child.GetComponent<TMP_Text>();
                        if (wantedLevelText != null)
                            wantedLevelText.text = " Wanted Level: " + npc.WantedLevel;
                        break;
                    case "Motherland":
                        TMP_Text motherlandText = child.GetComponent<TMP_Text>();
                        if (motherlandText != null)
                            motherlandText.text = " Motherland: " + npc.Motherland.Name;
                        break;
                    case "CurrentLocation":
                        TMP_Text locationText = child.GetComponent<TMP_Text>();
                        if (locationText != null)
                            locationText.text = " Current Location: " + npc.CurrentLocation.Name;
                        break;
                    default:
                        break;
                }
            }
            dataCount++;
            showed_data_amount.text = "Data being showed: " + dataCount;
            yield return null;
        }
    }
}
