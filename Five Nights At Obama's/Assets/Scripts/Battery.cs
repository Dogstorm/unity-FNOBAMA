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
    private float drainRate = 1f;
    [SerializeField]
    private float batteryLevel;
    [SerializeField]
    private TMP_Text batteryText;

    IEnumerator Start()
    {
        batteryLevel = 100;
        while (true)
        {
            yield return new WaitForSeconds(2.5f);
            PlayEverySecond();
        }
    }

    void PlayEverySecond()
    {
        if (drainOverTime == true)
        {
        
            batteryLevel -= drainRate;
            batteryText.text = batteryLevel.ToString() + "%";
        }
        if (batteryLevel <= 0)
        {
            batteryLevel = 0;
            drainOverTime = false;
            print("drainSetToFalse");
        }

        //Debug.Log(Time.time);

    }



    void Update()
    {
       // if (drainOverTime == true)
       // {
       //     
       //     batteryLevel -= drainRate;
       //     batteryText.text = ((Mathf.Round(batteryLevel * 100) / 100)).ToString() + "%";
       // }
      //  if (batteryLevel <= 0)
        //{
        //    batteryLevel = 0;
        //    drainOverTime = false;
        //   print("drainSetToFalse");
        //}
    }
}
