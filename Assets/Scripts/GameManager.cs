using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public int lives = 3, score;
   
    private void Awake()
    {
        Instance = this;
        ShowPlayerData();
    }

    // Change player lives and show player info
    public void AddLives(int value)
    {
        lives = Mathf.Max(0, lives + value);
        ShowPlayerData();
    }

    // Change player score and show player info
    public void AddScore(int value)
    {
        score += value;
        ShowPlayerData();
    }

    private void ShowPlayerData()
    {
        Debug.Log("Lives: " + lives + " Score: " + score + (lives == 0 ? " Game over!" : ""));
    }
}
