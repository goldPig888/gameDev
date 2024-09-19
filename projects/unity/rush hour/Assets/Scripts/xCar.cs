using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Manager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<Manager>();
        
        
    }

    private void OnMouseDown()
    {
        Vector2 coords = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        //make diff box colliders for top bottom left right

    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
