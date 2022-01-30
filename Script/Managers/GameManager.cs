using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager I;

    private void Awake()
    {
        I = this;
    }

   
    public void GameStart()
    {
        SceneManager.LoadScene("GameScene");
    }

}
