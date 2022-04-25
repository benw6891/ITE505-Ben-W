using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Teleporter : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject Player;
    public GameObject TeleportTo;
    public GameObject TP2;

    private void OnTriggerEnter(Collider collision) {
        if(collision.gameObject.CompareTag("Teleporter")) {
            Player.transform.position = TeleportTo.transform.position;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            rb.Sleep();

        }

        if(collision.gameObject.CompareTag("SecondTeleporter")) {
            Player.transform.position = TP2.transform.position;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            rb.Sleep();
        
        }
    }
}
