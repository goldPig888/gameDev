using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] GameObject skull;
    // Start is called before the first frame update
    void Start()
    {
        skull.GetComponent<SpriteRenderer>().enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
