using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveLeftOrRight = 0f;
        if (Keyboard.current.aKey.isPressed)
        {
            moveLeftOrRight = -10f;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            moveLeftOrRight = 10f;
        }

        moveLeftOrRight = moveLeftOrRight * Time.deltaTime;
        
        transform.Translate(moveLeftOrRight, 0f, 0f);
    }

    public float getCurrentXValue()
    {
        return transform.position.x;
    }
    
}
