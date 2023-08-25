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
    [SerializeField]
    private float batteryTickRate = 2f; // In Seconds

    IEnumerator Start()
    {
        batteryLevel = 100;
        while (true)
        {
            yield return new WaitForSeconds(batteryTickRate); 
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
            print("GAME OVER, National Anthem as screen fades to black, then maybe jumpscare"); // dont forget to add this
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
