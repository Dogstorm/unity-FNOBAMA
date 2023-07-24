using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetFloat : MonoBehaviour
{
    [SerializeField] private xFloatSO xFloat;
    [SerializeField] private yFloatSO yFloat;
    [SerializeField] public float xdefault;
    [SerializeField] public float ydefault;
    [SerializeField] private xFloatSO onlyOneValue;
    void Start()
    {
        

    }
    private void Awake()
    {
        if (onlyOneValue.Value == 1)
        {
            xFloat.Value = xdefault;
            yFloat.Value = ydefault;
            onlyOneValue.Value = 0;
        }
        
    }
}
