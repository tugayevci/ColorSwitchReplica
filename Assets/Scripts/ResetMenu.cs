using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetMenu : MonoBehaviour
{
    public GameObject resetMenuUI;       
    

     
    public void ResetButton()
    {
        resetMenuUI.SetActive(true);
        
    }

    public void ResetHighScore()
    {
        resetMenuUI.SetActive(false);
        PlayerPrefs.SetInt("HighScore", 0);
    }

    public void Cancel()
    {
        resetMenuUI.SetActive(false);
    }

    public void GoMainMenu()
    {
        SceneManager.LoadScene(0);

    }

}
