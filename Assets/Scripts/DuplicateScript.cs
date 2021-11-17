using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicateScript : MonoBehaviour
{
    [SerializeField]
    GameObject sample;

    private void Start()
    {
        //Run the clone function after 2 seconds
        Invoke("Clone", 2);

        InvokeRepeating("Clone", 2, 0.2f);
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
            Clone();

        if (Input.GetMouseButtonDown(1))
            CancelInvoke("Clone");
    }

    void Clone()
    {
        Vector3 pos = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
        Instantiate(sample, pos, Quaternion.identity);
    }
}
