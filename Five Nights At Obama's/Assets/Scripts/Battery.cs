using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Battery : MonoBehaviour
{
    public bool drainOverTime;
    public float drainRate;
    public float batteryLevel = 100;
    public TMP_Text batteryText;
    void Start()
    {
        
    }

    void Update()
    {
        batteryText.text = string.Format(batteryLevel.ToString("0.01%"));
        if(drainOverTime == true)
        {
            batteryLevel -= drainRate;
        }
    }
}
