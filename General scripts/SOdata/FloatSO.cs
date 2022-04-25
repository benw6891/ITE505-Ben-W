using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatSO : ScriptableObject
{
    [SerializeField]
    private float coins;
    
    public float Value
    {
        get { return coins; }
        set { coins = value; }
    }


}
