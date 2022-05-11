using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;
     public float sidewaysForce = 500f;

    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);

        if(Input.GetKey("d")){
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        }
        
         if(Input.GetKey("a")){
            rb.AddForce(-500 * Time.deltaTime, 0, 0);
        }
        
    }
}

