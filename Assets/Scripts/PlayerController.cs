using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2.5f;
    private GameManager _gameManager;
    
    void Start()
    {
        _gameManager = Object.FindAnyObjectByType<GameManager>();
    }
    
    void Update()
    {
        if (_gameManager.isGameActive)
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
            pos.x = Mathf.Clamp(pos.x, _gameManager.moveLimitLeft, _gameManager.moveLimitRight);
            transform.position = pos;
        }
    }
}
