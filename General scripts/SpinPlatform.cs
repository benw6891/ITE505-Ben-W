using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPlatform : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //x, y, z spin
        //Time.deltaTime = frames loaded in Unity 
        transform.Rotate(0f * Time.deltaTime, 20f * Time.deltaTime, 0f * Time.deltaTime, Space.Self);
    }
}
