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


    public void MoveUp()
    {
        //check to see if the move is valid
        //add in y

    }

    public void MoveDown()
    {
        //check to see if the move is valid
        // subtract in y

    }
    public void MoveRight()
    {
        //check to see if the move is valid
        //add in x
    }
    public void MoveLeft()
    {
        //check to see if the move is valid
        //subtract in x
    }

    public void IsValid()
    {
        //1. we don't hit any walls
        //2. we don't hit any other cars (distance between them can't be < one square) check on the canvas

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