using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
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
        Vector2 center = GetSpriteCenter();
        if (coords.y > center.y)
        {
            
        }
        else if (coords.y < center.y)
        {
            {

            }
        }

    private Vector2 GetSpriteCenter()
    {
        Renderer renderer = GetComponent<Renderer>();
        Bounds bounds = renderer.bounds;

        return bounds.center;
    }


    // Update is called once per frame
    void Update()
    {


    }
}
