using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeUpdateFunctions : MonoBehaviour
{
    [SerializeField]
    float speed = 0.1f;
    void Update()
    {
        print("Time: " + Time.deltaTime);   //Time in seconds
        print("Frame: " + Time.frameCount);     //
        print("Delta: " + Time.time);       //Real time spent on rendering the frame

        //Translate = Move
        //Continually move on the z
        gameObject.transform.Translate(0, 0, speed);
    }
}
