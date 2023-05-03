using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsToText : MonoBehaviour
{
    public TMP_Text pointsTxt;

    // Update is called once per frame
    void Update()
    {
        pointsTxt.text = Points.playerPoints.ToString();
    }
}
