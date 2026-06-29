using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public bool isGameActive = false;
    public GameObject _mainMenuPanel;
    
    public GameObject droppyPrefab;
    private bool isObstacleSpawned = false;
    
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
                Instantiate(droppyPrefab, new Vector3(0, 0, 0), Quaternion.identity);
                isObstacleSpawned = true;
            }
        }
    }
}
