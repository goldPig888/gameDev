using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public Dictionary<GameObject, bool> doors = new Dictionary<GameObject, bool>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        
        GameObject[] allDoors = GameObject.FindGameObjectsWithTag("Respawn");
        foreach (GameObject door in allDoors)
        {
            doors.Add(door, false); 
        }
    }

    public void CollectKey(GameObject key, GameObject doorToUnlock)
    {
        key.SetActive(false);
        if (doors.ContainsKey(doorToUnlock))
        {
            doors[doorToUnlock] = true;
            doorToUnlock.GetComponent<Collider2D>().isTrigger = true;
        }
    }

    public void TryOpenDoor(Collider2D doorCollider)
    {
        GameObject door = doorCollider.gameObject;
        if (doors.ContainsKey(door) && doors[door])
        {
            Debug.Log("Door unlocked, making it invisible: " + door.name);
            door.SetActive(false);
        }
    }
}
