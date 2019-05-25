using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModMenuClassicPlayer : MonoBehaviour
{
    public GameObject classicPlayer;
    public Rigidbody2D rb;
    public float jumpForce = 2f;


    // Update is called once per frame
    void Update()
    {
        if (rb.position.y < 1.9)
        {

            rb.velocity = Vector2.up * jumpForce;

        }

    }
}
