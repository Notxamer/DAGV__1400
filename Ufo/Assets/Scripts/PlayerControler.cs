using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerControler : MonoBehaviour
{
    public float horizontalinput;
    public float speed;
    public float xRange;
    public Transform Blaster;
    public GameObject Lazerbolt;
    public GameManager gameManager;
    public AudioClip blaster;
    public AudioClip Explode;
    public AudioOver audioOver;

    public AudioSource playerAudio;


    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerAudio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        //Initialize Horizontal input from keyboard
        horizontalinput = Input.GetAxis("Horizontal");

        //Moves Player side to side
        transform.Translate(Vector3.right * horizontalinput * Time.deltaTime * speed);

        //Teleports Player to oposite side
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

         if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        }

         if(Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOverText == false)
        {
            //Create lazerbolt at the blaster position 
            Instantiate(Lazerbolt, Blaster.transform.position, Lazerbolt.transform.rotation);
            playerAudio.PlayOneShot(blaster, .5f);
            
        }

         
}

}
