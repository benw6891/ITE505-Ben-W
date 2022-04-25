/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDamage : MonoBehaviour
{

    public Vector3 enterPos;
    public Vector3 exitPos;

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Terrain")
        {
            print("enter");

            enterPos = transform.position;

            if(exitPos.y - enterPos.y > 2);
            {
                print("falling dmg");

                healthBar.SetHealth -= 5 * exitPos.y - enterPos.y;
            }

        }
    }

    void OnTriggerExit(Collider col)
    {
        if(col.tag == "Terrain")
        {
            print("exit");

            exitPos = transform.position;

        }

    }

}
*/