using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinPickup : MonoBehaviour
{

    public AudioClip coinSound;

    //this chunk of code sets up the serialization process to save the player's coin data between scenes (and if game is unloaded)
    [SerializeField]
    public Text coinText;
    [SerializeField]
    private FloatSO coinsSO;

    private void OnTriggerEnter(Collider other)
    {
        //if the tag is a coin tag
        if(GetComponent<Collider>().tag == "Coin")
        {
            //this code actually updates the canvas text component to display the coins, as well as actually adds a coin to our value 
            coinsSO.Value += 1;
            coinText.text = "$ " + coinsSO.Value;
            //this will play the coinSound audio clip at the position of the coin
            AudioSource.PlayClipAtPoint(coinSound, transform.position);

            //destroys coin once player picks it up 
            Destroy(gameObject);
        }  
    }   
}
