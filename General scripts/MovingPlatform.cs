using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public GameObject Player;


    //player will pair with platform upon entering the collider/hitbox. Currently glitchy.

    private void OnTriggerEnter(Collider other)
    {
        Player.transform.parent = transform;
    }

    //player will de-pair with collider once leaving 
    private void OnTriggerExit (Collider other)
    {
        Player.transform.parent = null;
    }

}
