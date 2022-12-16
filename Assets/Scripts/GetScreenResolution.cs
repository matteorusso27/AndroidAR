using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetScreenResolution : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        float height =  Display.main.systemHeight;
        float width  =  Display.main.systemWidth;

        RectTransform rt = GetComponent(typeof(RectTransform)) as RectTransform;
        rt.sizeDelta = new Vector2(width, height);
    }
}
