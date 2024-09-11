using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{

    [SerializeField] GameObject skull1;
    [SerializeField] GameObject skull2;
    [SerializeField] GameObject skull3;

    [SerializeField] GameObject triangle;
    [SerializeField] GameObject square;
    [SerializeField] GameObject circle;

    [SerializeField] Text scoreText;

    private int score = 0;
    private int death = 0;

    // Start is called before the first frame update
    void Start()
    {
        skull1.GetComponent<SpriteRenderer>().enabled = false;
        skull2.GetComponent<SpriteRenderer>().enabled = false;
        skull3.GetComponent<SpriteRenderer>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoints(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;

    }

    public void AddDeaths()
    {
        death++;

        if (death == 1)
            skull1.GetComponent<SpriteRenderer>().enabled = true;
        if (death == 2)
            skull2.GetComponent<SpriteRenderer>().enabled = true;
        if (death == 3)
            skull3.GetComponent<SpriteRenderer>().enabled = true;
    }
}
