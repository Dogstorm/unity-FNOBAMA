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
    private float drainRate = 0.001f;
    [SerializeField]
    private float batteryLevel = 100f;
    [SerializeField]
    private TMP_Text batteryText;
    void Start()
    {
       startDrain();
    }

    public void startDrain ()
    {
        Debug.Log("draining battery");
      
    }

    void Update()
    {
        if (drainOverTime == true)
        {
            
            
            //float realBattery = batteryLevel / 100;
            batteryLevel -= drainRate;
            batteryLevel = Mathf.Round(batteryLevel * 100f) / 10000f;
            batteryText.text = batteryLevel + "%";
        }
        
    }
}
