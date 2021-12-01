using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject player;

    Vector3 offset;
    [SerializeField] float cameraFollowRate = 3f; 

    void Start()
    {
        offset = player.transform.position - gameObject.transform.position;
    }

    void Update()
    {
        if (GameManager.instance.gameStatus != Modes.running) return;
        
        Vector3 currPosition = transform.position;
        Vector3 targetPosition = player.transform.position - offset;

        Vector3 newCamPos = Vector3.Lerp(currPosition, targetPosition, Time.deltaTime * cameraFollowRate);

        gameObject.transform.position = newCamPos;
    }
}
