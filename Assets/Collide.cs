using Unity.VisualScripting;
using UnityEngine;

public class Collide : MonoBehaviour
{
    void OnTriggerEnter2D()
    {
        Debug.Log("Game Over");
    }
}
