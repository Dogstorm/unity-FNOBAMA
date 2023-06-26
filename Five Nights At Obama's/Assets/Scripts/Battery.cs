using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battery : MonoBehaviour
{
    public bool drainOverTime;
    public float drainRate;
    public float batteryLevel = 100f;
    public Text batteryText;
    void Start()
    {
        
    }

    void Update()
    {
        batteryText.text = string.Format(batteryLevel.ToString("0"));
        if(drainOverTime == true)
        {
            batteryLevel -= drainRate;
        }
    }
}
