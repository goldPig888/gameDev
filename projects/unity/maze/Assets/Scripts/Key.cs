using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject doorToUnlock;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.CollectKey(gameObject, doorToUnlock);
            Debug.Log("Key collected unlocking door: " + doorToUnlock.name);
        }
    }
}
