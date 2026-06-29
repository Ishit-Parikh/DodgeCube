using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float moveLimitLeft, moveLimitRight, playerPadding = 0.5f;
    
    public PlayerController _playerController;
    
    public bool isGameActive = false;
    public GameObject _mainMenuPanel;
    
    public GameObject droppyPrefab;
    public bool isObstacleSpawned = false;
    public float xPostion;
    
    
    public GameObject boppyPrefab;
    public bool isPlayerSpawned = false;

    //public int score = 0;
    //public TextMeshProUGUI ScoreText;
    //public TextMeshProUGUI FinalSocreText;

    /*public void updateScore()
    {
        ScoreText.text = "Score: " + score.ToString();
    }*/

    void Start()
    {
        moveLimitLeft = Camera.main.ViewportToWorldPoint(new Vector3(0,0,0)).x + playerPadding;
        moveLimitRight = Camera.main.ViewportToWorldPoint(new Vector3(1,0,0)).x - playerPadding;
    }

    public void GameStart()
    {
        isGameActive = true;
    }

    private void SpawnPlayer()
    {
        isPlayerSpawned = true;
        Instantiate(boppyPrefab, new Vector3(0, -2.295f, 0), Quaternion.identity);
    }
    
    // Update is called once per frame
    void Update()
    {
        if(isGameActive)
        {
            if (!isPlayerSpawned)
            {
                SpawnPlayer();
            }
            
            if (!isObstacleSpawned)
            {
                xPostion = Random.Range(moveLimitLeft, moveLimitRight);
                Instantiate(droppyPrefab, new Vector3(xPostion, 0, 0), Quaternion.identity);
                isObstacleSpawned = true;
            }
        }
    }
}
