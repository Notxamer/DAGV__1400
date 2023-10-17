using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public ScoreManager scoreManager; //Store reference to score manager
    public int scoreToGive;

   void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //Find ScoreManage gameobject
    }
    private void OnTriggerEnter(Collider other)
    {
        scoreManager.IncreaseScore(); //Increase the Score
        Destroy(gameObject); //Destroy this Object
        Destroy(other.gameObject); //Destroy Object it Hits
    }
}
