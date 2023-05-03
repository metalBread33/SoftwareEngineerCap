using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{

    public static int playerPoints;
    public static int coins;
    public TMP_Text pointsTxt;

    // Start is called before the first frame update
    void Start()
    {
        playerPoints = 0;
        coins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pointsTxt.text = playerPoints.ToString();
    }
}
