using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PauseGame : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool paused = false;
    public TMP_Text coinCount;
    Points points;
    [SerializeField] GameObject GameManager;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);   
        points = GameManager.GetComponent<Points>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused) resume();
            else pause();
        }

        coinCount.text = points.coins.ToString(); 
    }

    public void pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
    }

    public void resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
    }

    public void returnToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void quit()
    {
        Application.Quit();
    }
}
