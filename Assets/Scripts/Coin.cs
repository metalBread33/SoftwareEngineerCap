using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    Points points;
    public AudioSource coinSound;
    [SerializeField] GameObject GameManager;

    void Awake()
    {
    points = GameManager.GetComponent<Points>();
    }

    // On player collision points go up by 10, and coin goes up by 1
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
        coinSound.Play();
        Destroy(gameObject);
        points.playerPoints += 10;
        points.coins += 1;
        }
    }
}
