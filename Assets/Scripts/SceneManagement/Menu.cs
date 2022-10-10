using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void LoadScene(int indexScene)
    {
        //remember to use "LoadSceneAsync" when loading screen is ready
        SceneManager.LoadSceneAsync(indexScene);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("exit!!!!");
    }
}
