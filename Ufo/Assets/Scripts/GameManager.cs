using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOverText;

    private GameObject gameOverText;

    // Start is called before the first frame update

   void Awake()
    {
        Time.timeScale = 1;
        isGameOverText = false;
    }
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOverText)
        {
            Debug.Log("Other");
            EndGame(); //Start Endgame
        }
        else
            gameOverText.gameObject.SetActive(false);

    }
    public void EndGame() //Keep UI Text Game Over Hidden
    {
        gameOverText?.SetActive(true);
        Time.timeScale = 0; //Freeze Time
    }
}
