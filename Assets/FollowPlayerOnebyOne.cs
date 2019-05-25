using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowPlayerOnebyOne : MonoBehaviour
{
    public Transform player;

    private void Update()
    {
        if (Player.GameStatus == 1)
        {
            if (player.position.y+2 > transform.position.y)
            {
                transform.position = new Vector3(transform.position.x, player.position.y+2, transform.position.z);
            }
        }

    }

    public void NewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
