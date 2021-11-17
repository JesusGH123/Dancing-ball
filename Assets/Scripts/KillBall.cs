using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBall : MonoBehaviour
{
    //Applied on each of the 4 balls
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
