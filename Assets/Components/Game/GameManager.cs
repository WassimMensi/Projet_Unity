using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform Collectables;
    public GameObject WinCanvas;
    public GameObject GameOverCanvas;
    public Timer timer;

    public void Start()
    {
        timer.StartTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.GetTimeLeft() == 0) GameOver();
        else if (Collectables.childCount == 0) Win();
    }


    public void GameOver()
    {
        GameOverCanvas.SetActive(true);
    }

    public void Win()
    {
        WinCanvas.SetActive(true);
    }
}
