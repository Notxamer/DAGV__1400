using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerControler : MonoBehaviour

{
    public float horizontalinput;
    public float speed;
    public float xRange;
    public Transform Blaster;
    public GameObject Lazerbolt;
    // Start is called before the first frame update
    void Start()
    {
        
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

         if(Input.GetKeyDown(KeyCode.Space))
        {
            //Create lazerbolt at the blaster position 
            Instantiate(Lazerbolt, Blaster.transform.position, Lazerbolt.transform.rotation);
        }

         
}
    //Delete any object with a trigger that hits the player
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
