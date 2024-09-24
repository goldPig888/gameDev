using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject car;

   

    public void OnVehicleClick()
    {

        if ()
        {

        }else if ()
        {

        }else if ()
        {

        }else
        {

        }
        // get the point coordinates
        // check to see if the bounding box is which, then get the movements
        
    }

    void Start()
    {
        
    }


// the up down right left can be simplified with a parameter changing the vector of transformation just by move

    public void Move(Vector3 direction) {
        Vector3 newPosition = transform.position + direction; 
        if (IsValid(newPosition))
        {
            transform.position = newPosition;
        }
    }

    public bool IsValid(Vector3 position)
    {
        float range = 3f;
        if (position.magnitude > range)
            return false;
        if (Collider2D[] colliders == Physics2D.OverlapCircleAll(transform.position, range)) { }
        //1. we don't hit any walls

        //2. we don't hit any other cars (distance between them can't be < one square) check on the canvas number to be determined

    }

    public void CheckGameEnd()
    {
        //if the little red car gets to the end, win function and stop game
    }

    public void Reset()
    {
        //reset the positions of the cars to the beginning state
        
    }
}