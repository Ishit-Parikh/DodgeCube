using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using TMPro;

public class GameControll : MonoBehaviour
{
    [SerializeField] private GameObject droppyPrefab;
    private float xPosition = 0f;
    public bool isSpawned = false;
    public int score = 0;
    public TextMeshProUGUI ScoreText;

    public void updateScore()
    {
        ScoreText.text = "Score: " + score.ToString();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (!isSpawned)
        {
            xPosition = UnityEngine.Random.Range(-8.5f, 8.5f);
            Instantiate(droppyPrefab, new Vector3(xPosition, 0f, 0f), Quaternion.identity);
            Debug.Log("Is Created");
            isSpawned = true;
        }
    }
}
