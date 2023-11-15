using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBehaviour : MonoBehaviour
{
    public float seconds = 1;
    private WaitForSeconds wfsobj;
    // Start is called before the first frame update
   private IEnumerator Start()
    {
        wfsobj = new WaitForSeconds(seconds);
        yield return wfsobj;
        Destroy(gameObject);
    }

   
}
