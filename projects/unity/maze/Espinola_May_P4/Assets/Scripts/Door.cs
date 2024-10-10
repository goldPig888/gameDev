using UnityEngine;

public class Door : MonoBehaviour
{
    public bool isUnlocked = false; 

    private Collider2D doorCollider;
    private SpriteRenderer doorRenderer;

    private void Awake()
    {
        doorCollider = GetComponent<Collider2D>();
        doorRenderer = GetComponent<SpriteRenderer>();
    }

    public void UnlockDoor()
    {
        isUnlocked = true;
        doorCollider.isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player") && isUnlocked)
        {
            HideDoor();
        }
    }

    private void HideDoor()
    {
        doorRenderer.enabled = false;
        doorCollider.enabled = false;}
}
