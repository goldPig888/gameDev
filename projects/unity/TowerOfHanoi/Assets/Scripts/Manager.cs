using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] GameObject c1;
    [SerializeField] GameObject c2;
    [SerializeField] GameObject c3;
    [SerializeField] GameObject c4;
    [SerializeField] GameObject c5;

    // Start is called before the first frame update
    void Start()
    {
        c1.transform.position = new Vector3(-3.2f, -1.99f, 0f);
        c2.transform.position = new Vector3(-3.19f, -1.19f, 0f);
        c3.transform.position = new Vector3(-3.2f, -.51f, 0f);
        c1.transform.position = new Vector3(-3.21f, -.0448f, 0f);
        c1.transform.position = new Vector3(-3.2f, -.5099f, 0f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
