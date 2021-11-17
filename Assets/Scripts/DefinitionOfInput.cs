using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefinitionOfInput : MonoBehaviour
{

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Press
        }
        if(Input.GetKey(KeyCode.Space))
        {
            //While pressed
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Release
        }

        if(Input.GetMouseButtonUp(0))
        {
            //Mouse left click pressed
        }

        float x = Input.GetAxis("Horizontal");  //Left/Rigth or A/D
        float y = Input.GetAxis("Vertical");    //Up/Down   or W/S
    }
}
