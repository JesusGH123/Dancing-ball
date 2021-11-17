using UnityEngine;

public class ObjectCrossingCheck : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))   //If it was the player, drop tile
        {
            if(gameObject.CompareTag("Pickup"))
            {
                Destroy(transform.parent.gameObject);
                GameManager.instance.IncrementPickup();
            }
            else if(gameObject.CompareTag("Tile")) {
                Invoke("DropBlock", 0.5f);
                GameManager.instance.IncrementScore();
            }
        }
    }

    void DropBlock()
    {
        transform.parent.gameObject.GetComponentInParent<Rigidbody>().useGravity = true;
        transform.parent.gameObject.GetComponentInParent<Rigidbody>().isKinematic = false;
        transform.parent.gameObject.GetComponentInParent<Rigidbody>().AddForce(Physics.gravity, ForceMode.Acceleration);

        Destroy(transform.parent.gameObject, 0.5f);
    }

}
