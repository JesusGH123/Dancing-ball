using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private float moveSpeed = 5f;

    bool fire = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && GameManager.instance.gameStatus != Modes.over)
            fire = true;

        if (GameManager.instance.gameStatus == Modes.paused)
        {
            if (fire)
                Begin();
        } 
        else if(GameManager.instance.gameStatus == Modes.running)
        {
            if(!Physics.Raycast(gameObject.transform.position, Vector3.down, 10))
            {
                //Game over
                GameManager.instance.EndGame();
                rb.velocity = new Vector3(0, -25f, 0);
            } else
            {
                if (fire)
                    ChangeDirection();
            }
        }
    
    }

    void Begin()
    {
        GameManager.instance.StartGame();
        rb.velocity = new Vector3(moveSpeed, 0, 0); //Move the player
        fire = false;
    }

    void ChangeDirection()
    {
        //If it is moving on the x, move it on the z
        if(rb.velocity.x > 0)
            rb.velocity = new Vector3(0, 0, moveSpeed);
        //If it is moving on the z, move int on the x
        else if(rb.velocity.z > 0)
            rb.velocity = new Vector3(moveSpeed, 0, 0);

        fire = false;
    }
}
