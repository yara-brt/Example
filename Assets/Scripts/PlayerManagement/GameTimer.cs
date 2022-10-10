using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    public string levelToLoad;
    float timer = 60f;
    private Text seconds;
    void Start()
    {
        seconds = GetComponent<Text>();
    }

    void Update()
    {
        timer -= Time.deltaTime;
        seconds.text = timer.ToString("f0");
        if (timer <=0)
        {
            Application.LoadLevel(levelToLoad);
        }
    }
}
