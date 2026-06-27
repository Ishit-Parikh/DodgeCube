using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        
    }

    [SerializeField] float moveLimitLeft = -4f; 
    [SerializeField] float moveLimitRight = 4f;
    
    void Update()
    {
        float move = 0f;

        if (Keyboard.current.aKey.isPressed)
        {
            if (transform.position.x <= moveLimitLeft)
            {
                move = 0f;
            }
            else
            {
                move = -7.5f;
            }
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            if (transform.position.x >= moveLimitRight)
            {
                move = 0f;
            }
            else
            {
                move = 7.5f;
            }
        }
        
        //translate will help direction of acceleration (Move i.e. left, right, up, down)
        transform.Translate(move * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Debug.Log("GAME-OVER!");
        }
    }
}
