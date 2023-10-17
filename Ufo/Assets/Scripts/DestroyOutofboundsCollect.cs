using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofboundsCollect : MonoBehaviour
{
    public float TopBounds = 30f;
    public float LowerBounds = -10f;
    // Start is called before the first frame update

    
    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > TopBounds)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < LowerBounds)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject); 
      
        }

    }
}
