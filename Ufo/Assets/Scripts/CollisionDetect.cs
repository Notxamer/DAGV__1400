using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); //Destroy this Object
        Destroy(other.gameObject); //Destroy Object it Hits
    }
}
