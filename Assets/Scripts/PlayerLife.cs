using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private int LifePoint = 10;
    [SerializeField] Text text;

    public void DecreaseLifeBar()
    {
        if (--LifePoint <= 0)
        {
            text.text = "Game Over";
            Invoke("GameOverScene", 1.75f);
        }
        else
        {
            text.text = "Health: " + LifePoint;
        }
    }

    public void GameOverScene()
    {
        SceneManager.LoadScene(3);
    }
}
