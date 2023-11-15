using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CorutineBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent, repeatUntilFalse;
    public IntData counterNum;
    public bool canRun = false;
    public float seconds = 0.5f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;

    private void Start()
    {
        startEvent.Invoke();
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
    }

    public void StartCounting()
    {
        StartCoroutine(Counting());
    }
    IEnumerator Counting()
    {
        
        yield return wfsObj;
        startCountEvent.Invoke();

        while (counterNum.Value > 0) 
        {
            repeatCountEvent.Invoke();
            counterNum.Value--;
            yield return wfsObj;
        

        

        }
        endCountEvent.Invoke();
    }

    public void StartRepeatUntilFalse()
    {
        canRun = true;
        StartCoroutine(RepeatUntilFalse());
    }

    IEnumerator RepeatUntilFalse() 
    {
    while (canRun) 
        {
            yield return wfsObj;
            repeatUntilFalse.Invoke();
        }
    }

}
