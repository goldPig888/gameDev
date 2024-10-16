using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] GameObject racecar;
    [SerializeField] GameObject exitSquare;
    [SerializeField] GameObject[] vehicles;
    [SerializeField] UnityEngine.UI.Text moveCounterText;
    [SerializeField] UnityEngine.UI.Text winMessageText;
    [SerializeField] GameObject gridBounds;

    private int moveCount = 0;
    public bool gameEnded = false;

    private Vector3[] startingPositions;
    private Bounds gridBoundsArea;
    private Collider2D exitCollider;

    void Start()
    {
        startingPositions = new Vector3[vehicles.Length];
        for (int i = 0; i < vehicles.Length; i++)
        {
            startingPositions[i] = vehicles[i].transform.position;
        }

        gridBoundsArea = gridBounds.GetComponent<Renderer>().bounds;
        exitCollider = exitSquare.GetComponent<Collider2D>();

        winMessageText.gameObject.SetActive(false);
        moveCount = 0;
        UpdateMoveCounter();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Reset();
        }
    }

    public void ResetVehiclesToStart()
    {
        for (int i = 0; i < vehicles.Length; i++)
        {
            vehicles[i].transform.position = startingPositions[i];
        }
    }

    public void MoveVehicle(GameObject vehicle, Vector3 direction)
    {
        Collider2D vehicleCollider = vehicle.GetComponent<Collider2D>();
        Vector3 newPosition = vehicle.transform.position + (direction * 250f);
        Debug.Log($"Moving vehicle to new position: {newPosition}");
        Bounds vehicleBounds = vehicleCollider.bounds;
        Vector3 minPosition = newPosition - (vehicleBounds.extents);
        Vector3 maxPosition = newPosition + (vehicleBounds.extents);


        if (exitCollider.OverlapPoint(newPosition))
        {
            Debug.Log("Vehicle is overlapping with the exit square.");
            vehicle.transform.position = newPosition;
            moveCount++;
            UpdateMoveCounter();
            DisplayWinMessage();
            gameEnded = true;
            return;
        }

        bool isExiting = vehicle == racecar && exitCollider.OverlapPoint(newPosition);
        bool yInBounds = minPosition.y >= gridBoundsArea.min.y && maxPosition.y <= gridBoundsArea.max.y;
        bool xInBounds = minPosition.x >= gridBoundsArea.min.x && maxPosition.x <= gridBoundsArea.max.x;
        bool canGoOutXBounds = vehicle == racecar && Mathf.Abs(newPosition.y - exitSquare.transform.position.y) < 0.1f;

        Debug.Log($"Y in bounds: {yInBounds}, X in bounds: {xInBounds}, Can go out of bounds: {canGoOutXBounds}");

        if (!yInBounds || (!xInBounds && !canGoOutXBounds))
        {
            Debug.Log("Movement blocked by grid bounds.");
            return;
        }

        RaycastHit2D[] hits;
        bool isBlocked = false;

        if (direction == Vector3.up)
        {
            hits = Physics2D.RaycastAll(vehicle.transform.position, Vector2.up, vehicle.GetComponent<SpriteRenderer>().bounds.size.y + 0.01f);
        }
        else if (direction == Vector3.down)
        {
            hits = Physics2D.RaycastAll(vehicle.transform.position, Vector2.down, vehicle.GetComponent<SpriteRenderer>().bounds.size.y + 0.01f);
        }
        else if (direction == Vector3.left)
        {
            hits = Physics2D.RaycastAll(vehicle.transform.position, Vector2.left, vehicle.GetComponent<SpriteRenderer>().bounds.size.x + 0.01f);
        }
        else if (direction == Vector3.right)
        {
            hits = Physics2D.RaycastAll(vehicle.transform.position, Vector2.right, vehicle.GetComponent<SpriteRenderer>().bounds.size.x + 0.01f);
        }
        else
        {
            return;
        }

        if (hits.Length > 1)
        {
            isBlocked = true;
            Debug.Log($"Move blocked by: {hits[1].collider.name}");
        }

        if (!isBlocked)
        {
            vehicle.transform.position = newPosition;
            moveCount++;
            UpdateMoveCounter();
        }
    }

    public void Reset()
    {
        ResetVehiclesToStart();
        moveCount = 0;
        UpdateMoveCounter();
        HideWinMessage();
        gameEnded = false;
        Debug.Log("Game has been reset.");
    }

    public void UpdateMoveCounter()
    {
        moveCounterText.text = "Moves: " + moveCount.ToString();
        Debug.Log($"Move count updated to: {moveCount}");
    }

    public void DisplayWinMessage()
    {
        winMessageText.gameObject.SetActive(true);
        Debug.Log("Win message displayed.");
    }

    public void HideWinMessage()
    {
        winMessageText.gameObject.SetActive(false);
        Debug.Log("Win message hidden.");
    }
}
