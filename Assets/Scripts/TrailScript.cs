using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailScript : MonoBehaviour
{
    [SerializeField] GameObject player, trail;
    void Start()
    {
        InvokeRepeating("MakeTheTrails", 0, 0.05f);        
    }

    public void StopTrailing()
    {
        CancelInvoke("MakeTheTrails");
    }

    void MakeTheTrails()
    {
        GameObject newTrail = Instantiate(trail, player.transform.position, player.transform.rotation);

        Destroy(newTrail, 1.0f);
    }
}
