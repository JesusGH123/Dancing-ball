using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtScript : MonoBehaviour
{
    [SerializeField]
    Transform targetTrans, upTrans;

    void Update()
    {
        gameObject.transform.LookAt(targetTrans, upTrans.position);
    }
}
