using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofbounds : MonoBehaviour
{
    public float topBounds = 30f;
    public float lowerBounds = -10;
    // Start is called before the first frame update

    private void Awake()
    {
        //Time.timeScale = 1;
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
            Debug.Log("Game Over!");
            Destroy(gameObject); 
            //Time.ticeScale = 0;
        }

    }
}
