using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float playerPadding = 0.5f;
    [SerializeField] private float moveSpeed = 4.5f;
    
    public float moveLimitLeft, moveLimitRight;
    
    void Start()
    {
        moveLimitLeft = Camera.main.ViewportToWorldPoint(new Vector3(0,0,0)).x + playerPadding;
        moveLimitRight = Camera.main.ViewportToWorldPoint(new Vector3(1,0,0)).x - playerPadding;
    }
    
    void Update()
    {
        float move = 0f;

        if (Keyboard.current.aKey.isPressed)
        {
            move = -7.5f;
        }
        else if (Keyboard.current.dKey.isPressed)
        { 
            move = 7.5f;
        }
        
        //translate will help direction of acceleration (Move i.e. left, right, up, down)
        transform.Translate(move * moveSpeed * Time.deltaTime, 0, 0);

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, moveLimitLeft, moveLimitRight);
        transform.position = pos;

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Debug.Log("GameOver");
        }
    }
}
