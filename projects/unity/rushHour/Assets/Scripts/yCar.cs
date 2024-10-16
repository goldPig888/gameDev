using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yCar : MonoBehaviour
{
    private Manager gameManager;

    // Start is called before the first frame update
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

            if (mousePosition.y > carCenter.y)
            {
                gameManager.MoveVehicle(gameObject, Vector3.up);
            }
            else
            {
                gameManager.MoveVehicle(gameObject, Vector3.down);
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
