using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneByOneMode : MonoBehaviour
{
    public static int GameStatus = 1; // 1 play 0 death
    public float jumpForce = 5f;
    public int clickCounterForPlayerNextCoor = 1;

    Vector3 playerCoorNext = new Vector3(0, 0, 0);

    public static Vector3 nextObstacleCoor = new Vector3(0,0,0);

    public Rigidbody2D rb;
    public SpriteRenderer sr;

    public GameObject deathParticles;
    public GameObject particles;
    public GameObject player;

    public Animator animator;

    public ParticleSystem particleSystemm;
    public ParticleSystem deadParticleSystem;
    public ParticleSystem.MainModule particleSystemmMain;
    public ParticleSystem.MainModule deadParticleSystemMain;

    public string currentColor;
    public Color colorCyan;
    public Color colorYellow;
    public Color colorMagenta;
    public Color colorPink;


    void Start()
    {
        SetRandomColor();
        GameStatus = 1;

    }


    // Update is called once per frame
    void Update()
    {
        if (GameStatus == 1)
        {
            Vector3 playerCoor = new Vector3(0, player.transform.position.y, 0);
            Debug.Log("playercoor " + player.transform.position.y);

            if (rb.position.y < -3)
            {
                player.transform.position = new Vector3(0, -3, 0);
                //rb.velocity = Vector2.up * jumpForce;
            }

            if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
            {
                playerCoorNext = new Vector3(0, clickCounterForPlayerNextCoor*5, 0);
                clickCounterForPlayerNextCoor++;
                Debug.Log("playercoorNEXT " + playerCoorNext.y);

                rb.velocity = Vector2.up * jumpForce;
            }

            if (playerCoor.y >= playerCoorNext.y)
            {
                rb.velocity = Vector2.up * 0;
                player.transform.position = playerCoorNext;
            }
        }

    }


    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "ColorChanger")
        {
            LevelGeneratorOnebyOne lvlGenerator = FindObjectOfType<LevelGeneratorOnebyOne>();
            nextObstacleCoor.y += 5;
            lvlGenerator.LevelGeneratorMethod(rb);
            SetRandomColor();
            Destroy(col.gameObject);


            return;
        }


        if (col.tag != currentColor)
        {
            Dead();
        }
    }


    public void Dead()
    {


        nextObstacleCoor = new Vector3(0, 0, 0);

        Debug.Log("Game Over");

        Vector3 spawnPosition = new Vector3();
        spawnPosition.x = 0f;
        spawnPosition.y = rb.position.y;

        deadParticleSystemMain = deadParticleSystem.main;
        deadParticleSystemMain.startColor = sr.color;

        //deadParticleSystem.startColor = sr.color;
        Instantiate(deadParticleSystem, spawnPosition, Quaternion.identity); // Particle creater
        Destroy(particles);
        Destroy(player);
        GameStatus = 0; // Gameover variable for conditions which are using RigidBody2D rb
        animator.SetTrigger("EndGame"); // End Game animation trigger
        scoreText scoreText = FindObjectOfType<scoreText>(); //Updates the highscore 
        scoreText.HighScoreSaver(); //Updates the highscore 

    }




    void SetRandomColor()
    {
        int index = Random.Range(0, 4);
        particleSystemmMain = particleSystemm.main;

        switch (index)
        {
            case 0:
                currentColor = "Cyan";
                sr.color = colorCyan;

                break;
            case 1:
                currentColor = "Yellow";
                sr.color = colorYellow;


                break;
            case 2:
                currentColor = "Magenta";
                sr.color = colorMagenta;


                break;
            case 3:
                currentColor = "Pink";
                sr.color = colorPink;


                break;
        }
        particleSystemmMain.startColor = sr.color;


    }
}
