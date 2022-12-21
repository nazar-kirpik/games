using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    // This is a referenceto the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // We marked this as "Fixed"Update because we
    // are using it to mess with physics.
    void FixedUpdate()
    {   
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        // Add force to the right
        if (Input.GetKey("d")) 
        { 
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        // Add force to the left
        if (Input.GetKey("a")) 
        { 
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f) 
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
