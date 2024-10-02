using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    [SerializeField] int points;
    [SerializeField] int timeToDie;
    [SerializeField] GameObject manager;

    private float elapsedTime;

    void Start()
    {
        elapsedTime = 0f;
    }

    void Update()
    {
        if (manager.GetComponent<Manager>().IsGameOver())
            return;

        elapsedTime += 1000f * Time.deltaTime;

        if (elapsedTime >= timeToDie && manager.GetComponent<Manager>().GetDeaths() < 3)
        {
            Move();
            manager.GetComponent<Manager>().AddDeath();
            elapsedTime = 0f;
        }
    }

    void Move()
    {
        if (manager.GetComponent<Manager>().IsGameOver())
            return;

        transform.position = new Vector3(
            UnityEngine.Random.Range(-4.25f, 4.25f),
            UnityEngine.Random.Range(-4.25f, 4.0f),
            transform.position.z
        );
        elapsedTime = 0f;
    }

    private void OnMouseDown()
    {
        if (manager.GetComponent<Manager>().IsGameOver())
            return;

        Move();
        manager.GetComponent<Manager>().AddPoints(points);
    }
}
