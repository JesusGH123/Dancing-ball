using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDeactivate : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
            gameObject.SetActive(false);

        if (Input.GetMouseButtonDown(0))
            gameObject.SetActive(true);
    }
}
