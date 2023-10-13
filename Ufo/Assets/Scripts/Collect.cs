using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colect : MonoBehaviour
{
    public Transform Spawner;
    public GameObject Collect;

  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            Instantiate(Collect, Spawner.transform.position, Collect.transform.rotation);
        }
       
    }

}
