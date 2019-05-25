using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuManager : MonoBehaviour
{       

    public void PlayMethod()
    {
        SceneManager.LoadScene(3);
    }

    public void OptionsMethod()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitMethod()
    {
        Application.Quit();

    }


    public void ResetHighScore()
    {
        //Vector3 spawnPosition = new Vector3();
        //spawnPosition.y = 400f;
        //spawnPosition.x = 400f;
        //Instantiate(dialogBox, spawnPosition, Quaternion.identity);     

        

    }

    public void GoMainMenu()
    {
        SceneManager.LoadScene(0);

    }


}
