using UnityEngine;

public class StuffThatNeedsToBeDodged : MonoBehaviour
{
    [SerializeField] private float fallspeed = 5f;
    [SerializeField] private float speedIncreaseEveryDodge = 0.01f;
    void Update()
    {
        transform.Translate(0, -fallspeed * Time.deltaTime, 0);
        if (transform.position.y <= -5f)
        {
            float randomX = Random.Range(-5f, 5f);
            float randomY = Random.Range(5f, 4f);
            transform.position = new Vector3(randomX, randomY, 0);
        }

        speedIncreaseEveryDodge += fallspeed;
    }
}
