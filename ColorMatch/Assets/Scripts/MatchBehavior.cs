using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : IDContainerBehavior
{
    public UnityEvent matchEvent, noMatchEvent, noMatchDelayedEvent;

    private IEnumerator OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehavior>();
        if (tempObj == null)
            yield break;
            
         var otherID = tempObj.idObj;

        if (otherID == idObj)
        {
            Debug.Log("Match");
            matchEvent.Invoke();
        }

        else
        {
            Debug.Log("No Match");
            noMatchEvent.Invoke();
            yield return new WaitForSeconds(.5f);
        }
    }
}
