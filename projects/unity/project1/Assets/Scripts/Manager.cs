using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [SerializeField] GameObject skull1;
    [SerializeField] Text scoreText;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        skull1.GetComponent<SpriteRenderer>().enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoints(int points)
    {
        score += points;
        scoreText.text = "Score: " + points;

    }
}
