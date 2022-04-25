using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowMouse : MonoBehaviour
{
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;


    //updates once per frame
    void Update()
    {
        //move mouse canera movement in general
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        //clamps mouse camera movement
        yaw = Mathf.Clamp(yaw, -90f,90f); 
        pitch = Mathf.Clamp(pitch, -60f, 90f); 

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
