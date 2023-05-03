using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    Level_Stopwatch lvlSW;
    //Points points;
    [SerializeField] GameObject EndOfGame;
    float temp;

    void Start()
    {

  
    }
    // On player collision goes to next level
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
        Points.playerPoints += 100;
        
        // Goes to next level
        Debug.Log("Game Over!!");
        EndOfGame.SetActive(true);

        }
    }
}
