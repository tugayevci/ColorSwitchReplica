using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    private void Update()
    {
        if (Player.GameStatus == 1 )
        {
            if (player.position.y > transform.position.y)
            {
                transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
            }
        }         
        
    }

    public void NewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    //public void GameStatusChangerForCameraFollow()
    //{
    //    if (GameStatus==1)
    //    {
    //        GameStatus = 0;
    //    }
    //    else
    //    {
    //        GameStatus = 1;
    //    }
    //}



}
