using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextLabelBhaviour : MonoBehaviour
{
    public Text Label;
    public UnityEvent startEvent;
    private void Start()
    {
        Label = GetComponent<Text>();
        startEvent.Invoke();
    }

    public void UpdateLabel(FloatData obj)
    {
        Label.text = obj.value.ToString();
    }

    public void UpdateLabel(IntData obj)
    {
        Label.text = obj.Value.ToString();
    }
}
