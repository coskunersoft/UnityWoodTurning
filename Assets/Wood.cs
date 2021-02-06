using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
    private bool Touched;

    public Transform VisualObject;

    public void TouchMe()
    {
        if (!Touched)
        {
            VisualObject.GetComponent<Renderer>().material.mainTexture = Test.Instance.MatSecond;
            Touched = true;
        }
        Vector3 scale= transform.localScale / 1.01f;
        scale.y = transform.localScale.y;
        transform.localScale = scale;

        VisualObject.transform.localScale = transform.localScale;
        
    }
}
