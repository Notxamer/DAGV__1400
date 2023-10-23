using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOverText;
    public AudioSource backgroundMusic;
    public AudioClip gameOver;
    public AudioClip gameMusic;
    public bool endGame;

    private GameObject gameOverText;

    // Start is called before the first frame update

    void Awake()
    {
        Time.timeScale = 1;
        isGameOverText = false;
    }
    void Start()
    {
        backgroundMusic = GetComponent<AudioSource>();
        gameOverText = GameObject.Find("GameOverText");
        backgroundMusic.PlayOneShot(gameMusic, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOverText)
        {
            endGame = true;

        }
        else
        {
            gameOverText.gameObject.SetActive(false);
            endGame = false;
        }

        if (endGame)
            EndGame(); //Start Endgame
    }
    public void EndGame() //Keep UI Text Game Over Hidden
    {
        backgroundMusic.Stop();
        gameOverText?.SetActive(true);
        backgroundMusic.PlayOneShot(gameOver, 1f);
        endGame=false;
        Time.timeScale = 0; //Freeze Time


    }


    
}

