using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int PScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    public void addScore()
    {
        PScore = PScore + 1;
        scoreText.text = PScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

}
