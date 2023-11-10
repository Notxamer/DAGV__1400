using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int Value;

    public UnityEvent disableEvent;

    public void SetValue(int num)
    {
        Value = num;
    }

    public void CompareValue(IntData obj)
    {
        if (Value >= obj.Value) 
        {
            return;
        }
        else
        {
            Value = obj.Value;
        }
    }

    public void SetValue (IntData obj)
    {
        Value = obj.Value;
    }

    public void UpdateValue(int num)
    { 
        Value += num;
    }

    private void OnDisable()
    {
     disableEvent.Invoke();
    }
}
