using System;
using UnityEngine;  
using Object = UnityEngine.Object;

public class Obstacle : MonoBehaviour
{
    private GameControll gameControll;
    private float yPosition = 0f;
    private float dropSpeed = 0.25f;

    private void Start()
    {
        gameControll = Object.FindAnyObjectByType<GameControll>();
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
            gameControll.isSpawned = false;
            gameControll.score += 1;
            gameControll.updateScore();
            Destroy(gameObject);
        }

        if (other.CompareTag("Player"))
        {
            gameControll.isSpawned = false;
            Destroy(gameObject);
        }
    }
}
