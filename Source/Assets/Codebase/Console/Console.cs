using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

class Console : MonoBehaviour
{
    private void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.BackQuote))
        {
            OpenConsole();
        }
    }

    static void OpenConsole()
    {
        //The console prefab is gonna be called in here
        Debug.Log("Line Called: Console.cs:Console.OpenConsole();");
    }
}
