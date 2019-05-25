using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreText : MonoBehaviour
{

    public Text textScore;
    public Text highScoreText;

    public Rigidbody2D rb;
    int score = 0;
    int newScore = 0;
    int highScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore");
        highScoreText.text = highScore.ToString();
        textScore.text = score.ToString();
    }

    //public void ScoreUpdate()
    //{
    //    score++;
    //    textScore.text = score.ToString();
    //}

    //public void ScoreReset()
    //{
    //    score = 3;
    //}

    // Update is called once per frame
    void Update()
    {
        if (Player.GameStatus == 1)
        {
            int score = (int)rb.position.y;

            if (score > newScore)
            {
                newScore = score;
                textScore.text = newScore.ToString();

                if (newScore>highScore)
                {
                    
                    highScoreText.text = newScore.ToString();
                }
            }
        }         
        
    }

    public void HighScoreSaver()
    {
        if (newScore > highScore)
        {
            PlayerPrefs.SetInt("HighScore", newScore);
        }
    }


   

}
