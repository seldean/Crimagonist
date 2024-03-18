using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class OutputField : MonoBehaviour
{
    public TMP_InputField inputField;
    public GameObject outputPrefab;

    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (inputField != null && !string.IsNullOrEmpty(inputField.text))
            {
                string input = inputField.text.Trim();

                switch (input)
                {
                    case "help":
                        GameObject instantiatedObject = Instantiate(outputPrefab, transform.position, Quaternion.identity, transform);
                        TextMeshProUGUI textComponent = instantiatedObject.GetComponentInChildren<TextMeshProUGUI>();
                        if (textComponent != null)
                        {
                            textComponent.text =
                                "\n\nCrimagonist Console Helper:\n" +
                                "Version: 0.0.1 (Development) - Unity Editor Version: 2023.2.0\n\n" +
                                "show [object name]\n" +
                                "Usage: /show npcs, guns, vehicles, items, locations, businesses or places\n\n" +
                                "add_money [player name] [player surname] [amount]\n" +
                                "Usage: /add_money Sertan Balta 500000";
                        }
                        else
                        {
                            Debug.LogError("TextMeshProUGUI component not found on instantiated object.");
                        }
                        break;
                    default:
                        break;
                }

                inputField.text = "";
            }
            else
            {
                Debug.Log("Null input.");
            }
        }
    }
}