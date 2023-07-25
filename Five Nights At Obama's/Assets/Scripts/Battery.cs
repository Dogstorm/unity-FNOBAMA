using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Battery : MonoBehaviour
{
    public bool drainOverTime;
    [SerializeField] 
    private int drainRate = 1;
    [SerializeField]
    private int batteryLevel = 1000000000; // mult by 10 or add a 0 to increase the time it takes to reach 0
    [SerializeField]
    private TMP_Text batteryText;
    void Start()
    {
       
    }

    void Update()
    {
        if (drainOverTime == true)
        {
            
            batteryLevel -= drainRate;
            batteryText.text = (batteryLevel/100).ToString() + "%";
        }
        if (batteryLevel <= 0)
        {
            batteryLevel = 0;
            drainOverTime = false;
            print("drainSetToFalse");
        }
    }
}
