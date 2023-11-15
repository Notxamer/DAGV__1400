using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorIDBehaviour : IDContainerBehavior
{
    public ColorIDDataList colorIDDataListObj;

    private void Awake()
    {
        idObj = colorIDDataListObj.currentColor;
    }
}
