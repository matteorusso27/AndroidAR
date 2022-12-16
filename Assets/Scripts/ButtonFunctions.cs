using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
    public void GetNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
