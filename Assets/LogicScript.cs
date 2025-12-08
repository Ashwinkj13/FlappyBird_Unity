using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public static int playScore;
    public Text scoreText;
    public GameObject gameOverScreens;
    public pipescript speed;
    [SerializeField] TextMeshProUGUI highScore;
   // public birdscript birdie;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        if(birdscript.birdIsAlive)
        {
            playScore = playScore + scoreToAdd;
            ///Debug.Log(playScore + "player SCore");
            scoreText.text = playScore.ToString();
            highScoreCheck();
        }
        
    }

    public void highScoreCheck()
    {
        if(playScore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", playScore);
            UpdateHighScore();
        }
    }

    void UpdateHighScore()
    {
        highScore.text = $"HighScore: {PlayerPrefs.GetInt("HighScore", 0)}";
    }
    
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       
    }
    public void playerscoreZero()
    {
        playScore = 0;
        birdscript.birdIsAlive = true;
        
    }
    public void gameOver()
    {
         gameOverScreens.SetActive(true);
    }

    private void Start()
    {
        UpdateHighScore();
    }
}
