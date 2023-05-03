using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;
    [SerializeField] private GameObject _loaderCanvas;
    [SerializeField] private Image _progBar;
    private float _target;

    void Awake()
    {
        if (Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    public async void LoadScene(string sceneName)
    {
        _target = 0;
        _progBar.fillAmount = 0;

        var scene = SceneManager.LoadSceneAsync(sceneName);
        scene.allowSceneActivation = false;

        _loaderCanvas.SetActive(true);

        do{
            _target = scene.progress;
        }while(scene.progress < 0.9f);

        scene.allowSceneActivation = true;
        _loaderCanvas.SetActive(false);
    }
    void Update(){
        _progBar.fillAmount = Mathf.MoveTowards(_progBar.fillAmount, _target, 3*Time.deltaTime);
    }
}
