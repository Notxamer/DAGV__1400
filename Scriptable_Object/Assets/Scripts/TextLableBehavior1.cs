using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextLableBehavior1 : MonoBehaviour
{
public Text label;
    public IntData dataOBJ;

        private void Start()
    {
        label = GetComponent<Text>();
      UpdateLabel();
    }

    public void UpdateLabel() 
    {
        label.text = dataOBJ.Value.ToString();
    }
}
