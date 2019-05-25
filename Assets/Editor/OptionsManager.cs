using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsManager : MonoBehaviour
{
    public GameObject dialogBox;

    public void ResetHighScore()
    {
        Vector3 spawnPosition = new Vector3();
        spawnPosition.y = 234f;
        spawnPosition.x = 234f;
        Instantiate(dialogBox, spawnPosition, Quaternion.identity);



        //bool messageBox= UnityEditor.EditorUtility.DisplayDialog("Are you sure to reset high score?",
        //      "Are you sure to reset high score?"
        //     , "Reset", "Back");

        //if (messageBox)
        //{
        //    PlayerPrefs.SetInt("HighScore", 0);
        //}

        ////if (EditorUtility.DisplayDialog("Are you sure to reset high score?",
        ////       "Are you sure to reset high score?"
        ////      , "Reset", "Back"))
        ////{
        ////    PlayerPrefs.SetInt("HighScore", 0);
        ////}
    }

    public void GoMainMenu()
    {
        SceneManager.LoadScene(0);

    }



}
