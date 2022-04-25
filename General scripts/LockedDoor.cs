using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockedDoor : MonoBehaviour
{
    [SerializeField]
    public Text coinText;
    [SerializeField]
    private FloatSO coinsSO;

    private void OnTriggerEnter(Collider other)
    {
        //if the tag is a coin tag
        if(GetComponent<Collider>().tag == "Door")
        {
            //If the coins are >= 25, then it takes those coins and removes the door
            if(coinsSO.Value >= 25) {
                coinsSO.Value = coinsSO.Value - 25;
                Destroy(gameObject);
                coinText.text = "$ " + coinsSO.Value;
                print("door opened");
            }
            else {
            print("Not enough coins!"); 
            }
        }  
    }   

}
