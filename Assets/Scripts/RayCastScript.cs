using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (!Input.GetMouseButton(0)) return;
   
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(myRay, out hit))
        {
            //If raycast collides with something
            Transform hitObjectTransform = hit.transform;   //Get the transform of the hitte

            Destroy(hitObjectTransform.gameObject);
        }
    }
}
