using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, disableEvent;

    public void Awake()
    {
        awakeEvent.Invoke();
    }

    public void Start()
    {
       startEvent.Invoke();
    }

    public void OnDisable()
    {
        disableEvent.Invoke();
    }
}
