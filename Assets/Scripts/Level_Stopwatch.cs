using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class Level_Stopwatch : MonoBehaviour
{
    bool stopwatchActive = false;
    public static float currentTime;
    public int startMinutes;
    public TMP_Text currentTimeText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
        StartStopwatch();
    }

    // Update is called once per frame
    void Update()
    {
        if (stopwatchActive ==true){
            currentTime = currentTime+Time.deltaTime;
            if(currentTime < 60){
                currentTimeText.color = Color.green;
            }
            else if (currentTime > 60 && currentTime < 120){
                currentTimeText.color = Color.yellow;
            }
            else currentTimeText.color = Color.red;
        }

        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.ToString(@"mm\:ss\:fff");
    }

    public void StartStopwatch(){
        stopwatchActive = true;
    }

    public void StopStopwatch(){
        stopwatchActive = false;
    }

    public void ResetStopwatch(){
         currentTime = 0;
    }

    public float getCurrentTime(){
        return currentTime;
    }
}
