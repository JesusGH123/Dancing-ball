using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleScript : MonoBehaviour
{
    [SerializeField] float scaleRate = 2f;

    void Update()
    {
        gameObject.transform.localScale += gameObject.transform.up * scaleRate;
    }
}
