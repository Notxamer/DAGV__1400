using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colect : MonoBehaviour
{
    public Transform Spawner;
    public GameObject Collect;

    private float spawnRangeX = 20f;
    private float spawnPositionZ = 20f;
    private float startDelay = 5f;
    private float spawnInterval = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomLocation", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            
        }
       
    }

    void SpawnRandomLocation()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);
        Instantiate(Collect, spawnPos, Spawner.transform.rotation); //Spawns Ufo's through index and array from random location on X-Axis
    }

}
