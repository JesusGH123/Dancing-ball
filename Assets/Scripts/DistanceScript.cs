using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceScript : MonoBehaviour
{

    
    void Start()
    {
        Vector3 v1 = new Vector3(0, 0, 0);
        Vector3 v2 = new Vector3(0, 10, 32);

        //float dist = DistanceCalc(v1, v2);
        float dist2 = (v1 - v2).magnitude;  
        float dist3 = (v1 - v2).sqrMagnitude; //Without the SQRT
    }

    void Update()
    {
        
    }

    //float DistanceCalc (Vector3 v1, Vector3 v2)
    //{
        
    //}
}
