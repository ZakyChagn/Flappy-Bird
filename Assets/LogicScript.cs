using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text texte;
    public GameObject gameOverscreen;
    [ContextMenu("increase score")]
    public void AddScore()
    {
        playerScore += 1;
        texte.text = playerScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverscreen.SetActive(true);
    }
}
