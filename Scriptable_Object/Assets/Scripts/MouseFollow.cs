using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    private Vector3 mousePos;

    // Update is called once per frame
    void Update()
    {
        mousePos.Set(Input.mousePosition.x, 0, Input.mousePosition.z);
        transform.position = mousePos;
    }
}
