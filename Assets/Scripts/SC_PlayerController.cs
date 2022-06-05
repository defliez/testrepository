/*
Author: Valentino Glave
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 10f;

    private float xInput;
    public float gravity = 20.0f;
    bool grounded = false;
    Vector3 defaultScale;


    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        Move();
        grounded = false;
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
    
    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
    }

    private void Move()
    {
        rb.AddForce(new Vector3(xInput, 0f) * moveSpeed);
    }
}
