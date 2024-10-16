using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [SerializeField] GameObject[] skulls;
    [SerializeField] GameObject circle;
    [SerializeField] GameObject triangle;
    [SerializeField] GameObject square;
    [SerializeField] Text scoreText;
    [SerializeField] Text endGameText;

    private int score = 0;
    private int deaths = 0;
    private bool gameOver = false;

    void Start()
    {
        ResetGame();
    }

    void Update()
    {
        if (deaths >= 3 && !gameOver)
        {
            gameOver = true;
            endGameText.text = "Game Over!\nYou scored " + score + " points!";
            endGameText.enabled = true;
        }

        if (gameOver && Input.GetKeyDown(KeyCode.R))
        {
            ResetGame();
        }
    }

    public void ResetGame()
    {
        gameOver = false;
        deaths = 0;
        scoreText.text = "Score: " + score;
        endGameText.enabled = false;

        foreach (var skull in skulls)
        {
            skull.GetComponent<SpriteRenderer>().enabled = false;
        }
        circle.transform.position = new Vector3(-4.4f, 2.5f, 0f);
        square.transform.position = new Vector3(-4.3f, 0.09f, 0f);
        triangle.transform.position = new Vector3(2.7f, 0.3f, 0f);

        scoreText.text = "Score: " + score;
    }

    public void AddPoints(int pts)
    {
        if (gameOver) return;
        score += pts;
        scoreText.text = "Score: " + score;
    }

    public void AddDeath()
    {
        if (gameOver) return;
        deaths += 1;
        skulls[deaths - 1].GetComponent<SpriteRenderer>().enabled = true;
    }

    public int GetDeaths() { return deaths; }
    public int GetScore() { return score; }
    public bool IsGameOver() { return gameOver; }
}
