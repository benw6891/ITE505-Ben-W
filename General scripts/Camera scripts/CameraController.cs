using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //variables to control the offset of the camera which points at character
    public GameObject target;
    public float xOffset, yOffset, ZOffset;

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position + new Vector3(xOffset, yOffset, ZOffset);
        transform.LookAt(target.transform.position);
    } 
}
