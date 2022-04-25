using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallHeightReset : MonoBehaviour
{

    public Transform respawn;
    public Transform Player;

    //when this method is called, it will move the player back to the 'respawn' empty object 
    public void RespawnPlayer()
    {
        Player.position = respawn.position;
    }

    //threshold for reset
    public float threshold = -10f;

    // Update is called once per frame
    void Update()
    {
        //if the position of the ball is less than the threshold set above
        if(transform.position.y < threshold)
        {
            RespawnPlayer();
        }

        bool restart = Input.GetKeyDown(KeyCode.R);

        if (restart)
        {
            RespawnPlayer();
        }
    }
}
