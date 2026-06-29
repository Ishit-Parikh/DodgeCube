using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    //for setting player bounds that can restrict players movement based on screen Size
    public float moveLimitLeft, moveLimitRight, playerPadding = 0.5f;

    //Variables and Methods that will help start the game
    public bool isGameActive = false; 
    public void GameStart()
    {
        isGameActive = true;
        scorePanel.SetActive(true);
    }
    
    
    //Variables & Methods that will help spawn the player
    public GameObject boppyPrefab;
    public bool isPlayerSpawned;
    
    private void SpawnPlayer()
    {
        isPlayerSpawned = true;
        Instantiate(boppyPrefab, new Vector3(0, -2.295f, 0), Quaternion.identity);
    }
    
    
    //Variables & Methods that will help manage the scoring system
    public GameObject scorePanel;
    public int score;
    public TextMeshProUGUI ScoreText;
    
    public void updateScore()
    {
        ScoreText.text = "Score: " + score.ToString();
    }
    
    
    //Variables that will help in showing the final score after Game is over
    public int finalScore;
    public TextMeshProUGUI FinalSocreText;
    public bool isGameOver;
    public GameObject gameOverPanel;
    
    private void GameOverPanel()
    {
        scorePanel.SetActive(false);
        gameOverPanel.SetActive(true);
        finalScore = score;
        FinalSocreText.text = "Final Score: " + finalScore.ToString();
        isGameOver = false;
    }
    
    public void RestartGame()
    {
        score = 0;
        updateScore();
        finalScore = 0;
        GameStart();
    }
    
    void Start()
    {
        moveLimitLeft = Camera.main.ViewportToWorldPoint(new Vector3(0,0,0)).x + playerPadding;
        moveLimitRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - playerPadding;
        gameOverPanel.SetActive(false);
        scorePanel.SetActive(false);
    }
    
    //Variables that will help in spawining of Obstacles
    public bool isObstacleSpawned = false;
    public float xPostion;
    public GameObject droppyPrefab;
    
    
    void Update()
    {
        if(isGameActive)
        {
            if (!isPlayerSpawned)
            {
                SpawnPlayer();
            }
            
            else if (!isObstacleSpawned)
            {
                xPostion = Random.Range(moveLimitLeft, moveLimitRight);
                Instantiate(droppyPrefab, new Vector3(xPostion, 0, 0), Quaternion.identity);
                isObstacleSpawned = true;
            }
        }
        else if (isGameOver)
        {
            GameOverPanel();
        }
    }
}
