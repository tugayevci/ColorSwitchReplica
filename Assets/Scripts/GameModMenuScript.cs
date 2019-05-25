using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameModMenuScript : MonoBehaviour
{
    public GameObject rotateObjectPlayer;
    public GameObject oneByOneObjectPlayer;


    private void Update()
    {
        rotateObjectPlayer.transform.Translate(Vector3.up * Time.deltaTime/3);
        if (rotateObjectPlayer.transform.position.y > 1)
        {
            rotateObjectPlayer.transform.position = new Vector3(0, 0f, 0);
        }


        oneByOneObjectPlayer.transform.Translate(Vector3.up * Time.deltaTime);
        if (oneByOneObjectPlayer.transform.position.y > -0.5f)
        {
            oneByOneObjectPlayer.transform.position = new Vector3(0, -1.3f, 0);
        }

    }

    public void ClassicGameLoader()
    {
        SceneManager.LoadScene(1);

    }

    public void TurnObjectsGameLoader()
    {
        SceneManager.LoadScene(4);

    }

    public void ConstantSpeedGameLoader()
    {
        SceneManager.LoadScene(5);

    }

    public void PianoModeLoader()
    {
        SceneManager.LoadScene(6);

    }
}
