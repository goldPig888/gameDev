using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Manager manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = FindObjectOfType<Manager>();

    }

    private void OnMouseDown()
    {
        manager.OnVehicleClick();
        //send the point coords
        //say whether it is a top/bottom/left/right bounding box that is clicked on

    }

    // Update is called once per frame
    void Update()
    {

    }
}