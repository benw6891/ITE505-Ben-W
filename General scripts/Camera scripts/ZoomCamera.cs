using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCamera : MonoBehaviour
{
    //this variables controlls how fast the player can scroll out
    [SerializeField]
    private float ScrollSpeed = 25; 
    [SerializeField]
    private Camera ZoomCam;

    //private bool IsOrthographicZoom;

    private void Start()
    {
        ZoomCam = Camera.main;
        //isOrthographicZoom = ZoomCamera.orthographic;
    }

    //each update, game will check if camera zoom has been changed 
    void Update()
    {   
        //if(IsOrthographicZoom)
        if (ZoomCam.orthographic)
        {
            ZoomCam.orthographicSize -= Input.GetAxis("Mouse ScrollWheel") * ScrollSpeed;
        }
        else {
            ZoomCam.fieldOfView -= Input.GetAxis("Mouse ScrollWheel") * ScrollSpeed;
        }
    }
}
