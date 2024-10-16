using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xCar : MonoBehaviour
{
    private Manager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<Manager>();
    }

    private void OnMouseDown()
    {
        if (!gameManager.gameEnded)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 carCenter = GetSpriteCenter();

            if (mousePosition.x > carCenter.x)
            {
                gameManager.MoveVehicle(gameObject, Vector3.right);
            }
            else
            {
                gameManager.MoveVehicle(gameObject, Vector3.left);
            }
        }
    }

    private Vector2 GetSpriteCenter()
    {
        Renderer renderer = GetComponent<Renderer>();
        Bounds bounds = renderer.bounds;
        return bounds.center;
    }
}
