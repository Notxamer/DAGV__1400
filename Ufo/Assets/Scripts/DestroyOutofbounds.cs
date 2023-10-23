using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOutofbounds : MonoBehaviour
{
    public float topBounds = 30f;
    public float lowerBounds = -10;

    public GameManager gameManager;
    public AudioOver audioOver;
    // Start is called before the first frame update

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        audioOver = GameObject.Find("GUOver").GetComponent<AudioOver>();
    }

    private void Awake()
    {
        Time.timeScale = 1;
    }
    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBounds)
        {
            gameManager.isGameOverText = true;
            audioOver.isGameOverText = true;
            Debug.Log("Game Over!");
            Destroy(gameObject); 
           // Time.timeScale = 0;
        }

    }
}
