using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{
    //Parameters
    [Range(0.1f, 10f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlockDestroyed = 10;
    [SerializeField] TextMeshProUGUI scoreText;

    //state variables
    [SerializeField] int currentScore = 0;

    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if (gameStatusCount > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void ResetScore()
    {
        Destroy(gameObject);
    }

    private void Start()
    {
        AddToScore();
    }

    void Update ()
    {
        Time.timeScale = gameSpeed;
	}

    public void AddToScore()
    {
        scoreText.text = currentScore.ToString();
        currentScore += pointsPerBlockDestroyed;
    }
}
