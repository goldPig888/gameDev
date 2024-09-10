using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    [SerializeField] int points;
    [SerializeField] int moveTime;
    [SerializeField] GameObject manager;
    private float elaspedTime;
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        elaspedTime += 1000f * Time.deltaTime;
        if (elaspedTime >= moveTime) {
            Move();
        }
    }


    private void Move()
    {
        gameObject.transform.position = new Vector3(UnityEngine.Random.Range(-7.5f, 7.5f), transform.position.y, transform.position.z); elaspedTime = 0;
    }

    private void OnMouseDown()
    {
        Move();
        manager.GetComponent<Manager>().AddPoints(points);
    }
}