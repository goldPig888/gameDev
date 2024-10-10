using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject winText; 

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        winText.SetActive(false); 
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        movement = new Vector2(moveX, moveY);
        movement = Vector2.ClampMagnitude(movement, 1);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Respawn"))
        {
            GameManager.Instance.TryOpenDoor(other);
        }
        else if (other.CompareTag("Finish"))
        {
            Debug.Log("Player reached the finish!");
            winText.SetActive(true);
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
