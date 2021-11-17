using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChaseScript : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f, rotateSpeed = 1f;
    [SerializeField] Camera myCamera;

    Vector3 cameraOffset;
    
    void Start()
    {
        cameraOffset = gameObject.transform.position - myCamera.transform.position; //The gap between the game object and the camera
    }

    void Update()
    {
        float rotation = Input.GetAxis("Horizontal") * rotateSpeed;
        float translation = Input.GetAxis("Vertical") * moveSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        gameObject.transform.Translate(translation, 0, 0);   //Move the cube
        gameObject.transform.Rotate(0, rotation, 0);

        myCamera.transform.position = gameObject.transform.position - cameraOffset;
    }
}
