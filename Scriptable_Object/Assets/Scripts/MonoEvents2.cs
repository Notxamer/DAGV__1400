using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEvents2 : MonoBehaviour
{
    public UnityEvent clickEvent, destroyEvent, dragEvent;
    private void OnMouseDown()
    {
        clickEvent.Invoke();
    }

    private void OnDestroy()
    {
        destroyEvent.Invoke();
    }

    private void OnMouseDrag()
    {
        dragEvent.Invoke();
    }
}
