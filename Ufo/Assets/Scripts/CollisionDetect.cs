using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public ScoreManager scoreManager; //Store reference to score manager
    public int scoreToGive;
    public AudioClip Explode;
    public PlayerControler playerControler;

    private AudioSource blasterAudio;

    void Start()
    {
        playerControler = GameObject.Find("Player").GetComponent<PlayerControler>();
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //Find ScoreManage gameobject
        blasterAudio = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter(Collider other)
    {
        scoreManager.IncreaseScore(); //Increase the Score
        Destroy(gameObject); //Destroy this Object
        Destroy(other.gameObject); //Destroy Object it Hits
        playerControler.playerAudio.PlayOneShot(Explode, .5f);
    }
}
