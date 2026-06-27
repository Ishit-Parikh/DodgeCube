using System;
using UnityEngine;  
using Object = UnityEngine.Object;

public class Obstacle : MonoBehaviour
{
    private GameManager _gameManager;
    private float yPosition = 0f;
    private float dropSpeed = 0.25f;

    private void Start()
    {
        _gameManager = Object.FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        yPosition -= dropSpeed;
        transform.Translate(0,yPosition * Time.deltaTime,0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            _gameManager.isSpawned = false;
            _gameManager.score += 1;
            _gameManager.updateScore();
            Destroy(gameObject);
        }

        if (other.CompareTag("Player"))
        {
            _gameManager.isSpawned = false;
            Destroy(gameObject);
        }
    }
}
