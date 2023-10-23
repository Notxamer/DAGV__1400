using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using Unity.VisualScripting;
using UnityEngine;

public class AudioOver: MonoBehaviour
{
    public bool isGameOverText;
    public AudioSource backgroundMusic;
    public AudioClip gameOver;
    public AudioClip gameMusic;
    public bool endGame;

    private float startDelay = 2f;
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

    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOverText)
        {

            EndGame(); //Start Endgame

        }

    }
    public void EndGame() //Keep UI Text Game Over Hidden
    {
        backgroundMusic.PlayOneShot(gameOver, 3f);
        Debug.Log("Yup");
        isGameOverText=false;


    }

    
}

