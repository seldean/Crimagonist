using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

//This is the script to control the "menu" scene /Assets/Scenes

public class SwitchScene : MonoBehaviour
{
    //Opening the main scene
    public void OpenMain()
    {
        SceneManager.LoadScene("main"); //main's index: 1
    }
}
