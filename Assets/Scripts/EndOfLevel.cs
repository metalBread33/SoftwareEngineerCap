using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndOfLevel : MonoBehaviour
{
    Level_Stopwatch lvlSW;
    Points points;
    [SerializeField] GameObject GameManager;
    float temp;

    void Start()
    {
        lvlSW = GameManager.GetComponent<Level_Stopwatch>();
        points = GameManager.GetComponent<Points>();
    }
    // On player collision goes to next level
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
        // Stops Stopwatch and gets current time
        lvlSW.StopStopwatch();
        temp = lvlSW.getCurrentTime();

        // Calculates and adds points based on time spent in level
        if(temp < 60){
        points.playerPoints += 30;
        }
        else if (temp > 60 && temp < 120){
        points.playerPoints += 20;
        }
        else points.playerPoints += 10;
        
        // Goes to next level
        Debug.Log("Next Level");
        DontDestroyOnLoad(GameManager);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
