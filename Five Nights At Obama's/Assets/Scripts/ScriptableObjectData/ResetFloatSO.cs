using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class ResetFloatSO : MonoBehaviour
{
    [SerializeField] private xFloatSO xFloat;
    [SerializeField] private yFloatSO yFloat;
    public float DefaultSense = 400f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Reseting Sense");
        xFloat.Value = DefaultSense;
        yFloat.Value = DefaultSense;
    }

}
