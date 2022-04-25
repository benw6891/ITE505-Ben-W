using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundtrackScript : MonoBehaviour
{

    public static SoundtrackScript SoundtrackInstance;

    private void Awake()
    {
        if(SoundtrackInstance != null && SoundtrackInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        SoundtrackInstance = this;
        DontDestroyOnLoad(this);

    }

}
