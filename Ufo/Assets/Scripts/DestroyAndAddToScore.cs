using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.Rendering;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DestroyAndAddToScore : MonoBehaviour
{
    private float score = 1;
    private bool display = false;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider Player)
    {
        Destroy(gameObject);
       
        display = true;
    
    }

    // Update is called once per frame
    void Update()
    {
        if(display)
        {
            score = score + score;
            display = false;
        }
        
    }

}
