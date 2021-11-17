using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailOpacityScript : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine("MakeTransparent");
    }

    IEnumerator MakeTransparent()
    {
        for(float f = 0; f <=1; f += Time.deltaTime)
        {
            Color currColor = GetComponent<Renderer>().material.color;

            currColor.a = Mathf.Lerp(1.0f, 0.0f, f);

            GetComponent<Renderer>().material.color = currColor;

            yield return null;
        }
    }
}
