using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Rungame : MonoBehaviour
{
    //public bool GAMERUNNING = false;

    /*public static Rungame Instance;
    void Start()
    {
        if (Instance != null && Instance != this)
            Destroy(this);
        else
            Instance = this;
    }*/

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartNewGame();
            Debug.Log("space");
        }
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene("GamePlay", LoadSceneMode.Single);
        //GAMERUNNING = true;
        //Debug.Log(GAMERUNNING);
    }
}
