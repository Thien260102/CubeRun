using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sidewaysForce = 30f;

    public static bool isCollidedGround;
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.freezeRotation = true;
        // add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) // move right
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) // move left 
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        else if (Input.GetKey(KeyCode.Space) && isCollidedGround) // jump up
        {
            rb.AddForce(0, 300f, 0);
            Debug.Log("Player Jumping");
        }

        if(rb.position.y < 0.7f)
            FindObjectOfType<GameManager>().EndGame();
    }
}
