using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
   
   

    void OnCollisionEnter (Collider other)
    {
    
        if (other.gameObject.tag == "Obstacle")
    {
       print("kuk");

   // movement.enabled = false;

     } 
    }
}
