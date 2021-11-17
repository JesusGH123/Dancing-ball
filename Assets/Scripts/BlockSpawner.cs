using System.Collections;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    [SerializeField] GameObject block, pickUp;
    float size;
    Vector3 currentPos;

    private void Start()
    {
        currentPos = block.transform.position;  //The first tile
        size = block.transform.localScale.x;
    }

    void Spawn()
    {
        Vector3 nextPosition = currentPos;
        int rand = Random.Range(0, 2);

        if(rand == 0)
            nextPosition.x += size;
        else
            nextPosition.z += size;

        Instantiate(block, nextPosition, Quaternion.identity);
        currentPos = nextPosition;

        if (Random.Range(0, 4) == 0) {
            Instantiate(pickUp, nextPosition + new Vector3(0, 1.25f, 0), pickUp.transform.rotation);
        }
    }

    public void StartSpawning()
    {
        InvokeRepeating("Spawn", 0.5f, 0.35f);  //We could improve this using a coroutine
    }

    public void StopSpawning()
    {
        CancelInvoke("Spawn");
    }
}
