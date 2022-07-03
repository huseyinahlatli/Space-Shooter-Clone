using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject hazard; // hazard --> engellemek
    public int spawnCount;
    public float spawnTime;
    public float startSpawnTime;
    public float waveWait;
    public Text scoreText;
    public int score;

    public Text gameOverText;
    public Text restartText;
    public Text quitGameText;

    private bool gameOver;
    private bool restart;

    void Start()
    {
        gameOver = false;
        restart = false;
        StartCoroutine(SpawnValues());
    } 

    void Update()
    {
        if(restart == true)
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(0);
            }

            if(Input.GetKeyDown(KeyCode.Q))
            {
                Application.Quit();
            }
        }
    }

    IEnumerator SpawnValues()
    {
        yield return new WaitForSeconds(startSpawnTime);
        while(true){
            for(int i=0; i<spawnCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-3, 3), 0, 10);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);

                yield return new WaitForSeconds(spawnTime); 
                // Coroutine kodudur. Kullanılması için değer döndürecek olan fonksiyon, IEnumerator tipinde olmalıdır.
            }
            yield return new WaitForSeconds(waveWait);
            
            if(gameOver == true)
            {
                restartText.gameObject.SetActive(true);
                quitGameText.gameObject.SetActive(true);
                restart = true;
                break;
            }
        }
    }

    public void UpdateScore()
    {
        score += 10;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    { 
       gameOverText.gameObject.SetActive(true); 
       gameOver = true;
    }
}


