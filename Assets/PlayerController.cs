using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< Updated upstream:Assets/PlayerController.cs
public class PlayerController : MonoBehaviour
=======
//[RequireComponent(typeof(Rigidbody))]
public class SC_PlayerController : MonoBehaviour
>>>>>>> Stashed changes:Assets/Scripts/SC_PlayerController.cs
{
    public float gravity = 20.0f;
    public Rigidbody rb;
    bool grounded = false;
    Vector3 defaultScale;
    public float moveSpeed = 10f;

    private float xInput;
    private float zInput;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
        rb.freezeRotation = true;
        rb.useGravity = false;
        defaultScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }

    private void FixedUpdate()
    {
        Move();

        grounded = false;
    }

    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }

    private void Move()
    {
        //rb.AddForce(new Vector3(xInput, 0f, zInput) * moveSpeed);
        rb.AddForce(new Vector3(0, -gravity * rb.mass, 0));
    }

    void OnCollisionStay()
    {
        grounded = true;
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Finish")
        {
            //print("GameOver!");
            SC_GroundGenerator.instance.gameOver = true;
        }
    }


}
