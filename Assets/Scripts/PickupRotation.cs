using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupRotation : MonoBehaviour
{
    void Update()
    {
        gameObject.transform.Rotate(0, 1, 0);
    }
}
