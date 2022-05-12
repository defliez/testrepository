using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPlayer : MonoBehaviour
{
    [SerializeField] int speed;

    private void onCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(speed * Vector3.left, ForceMode.Impulse);
        }
    }
}
