using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public float timer = 0;
    public int score;
    public int highscore;
    public Text scoreText;
    public GameObject newBest;
    public GameObject personalBest;
    public Text newbestText;
    public Text personalbestText;
    public GameObject gameoverScreen;

    [ContextMenu("Increase Score")]
    private void Start()
    {
        highscore = PlayerPrefs.GetInt("highScore");
    }

    public void addScore(int tambah)
    {
        score += tambah;
        scoreText.text = score.ToString();
        if (score > highscore)
        {
            scoreText.color = Color.gray;
        }
    }
    public void gameover()
    {
        gameoverScreen.SetActive(true);
        if (score > highscore)
        {
            highscore = score;
            newBest.SetActive(true);
            newbestText.text = highscore.ToString();
        }
        if (score < highscore)
        {
            personalBest.SetActive(true);
            personalbestText.text = highscore.ToString();
        }
        PlayerPrefs.SetInt("highScore", highscore);
    }
}
