using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GamePlayManager : MonoBehaviour
{
    public static GamePlayManager Instance;

    public static bool isGameOver;
    public GameObject gameOverScreen;

    int score;
    public TMP_Text scoreText;
    public TMP_Text HasilScore;

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
        HasilScore.text = score.ToString();
    }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        isGameOver = false;
    }
    private void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
        HasilScore.text = score.ToString();
    }

    void Update()
    {
        if(isGameOver)
        {
            gameOverScreen.SetActive(true);
        }
    }

    public void Ulang()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
