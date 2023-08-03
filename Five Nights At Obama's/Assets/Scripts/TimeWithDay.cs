using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class TimeWithDay : MonoBehaviour
{
    public bool drainOverTime;
    private int addMins = 1; // how many mins to add

    [SerializeField] private int currentMins;
    [SerializeField] private int currentHrs;
    [SerializeField] private int currentDays;

    [SerializeField] private TMP_Text timeTextHour;
    [SerializeField] private TMP_Text timeTextMins;
    [SerializeField] private TMP_Text timeTextDay;

    private string TOD = " AM"; // Time Of Day
    [SerializeField] private float batteryTickRate; // In Seconds

    IEnumerator Start()
    {
        currentMins = 0;
        currentHrs = 2;
        currentDays = 1;
        while (true)
        {
            PlayEverySecond();
            drainOverTime = true;
            yield return new WaitForSeconds(batteryTickRate);
        }
    }

    void PlayEverySecond()
    {
        if (drainOverTime == true)
        {

            currentMins += addMins;
            timeTextHour.text = currentHrs.ToString() + ":";
            if (currentMins > 0 & currentMins < 10)
            {
                timeTextMins.text = "   0" + currentMins.ToString() + TOD; // to add the zero when its less than 10
            }
            else if (currentMins >= 10)
            {
                timeTextMins.text = "   " + currentMins.ToString() + TOD; // when it is two digits
            }
        }
        
        if (currentMins >= 59)
        {
            currentHrs = currentHrs + 1;

            if (currentHrs == 12 & TOD == " AM")
            {
                TOD = " PM";
            }
            else if (currentHrs == 12 & TOD == " PM")
            {
                TOD = " AM";
                currentDays = currentDays + 1;
                timeTextDay.text = "Day: " + currentDays.ToString();
            }

            currentMins = 0;
            timeTextMins.text = "   00" + TOD;
            timeTextHour.text = currentHrs.ToString() + ":";
            drainOverTime = false;
            print("added an hour");
        }

        if (currentHrs >= 13 & TOD == " PM")
        {
            currentHrs = 1;
            
        }
        else if (currentHrs >= 13 & TOD == " AM")
        {
            currentHrs = 1;
            currentMins = 0;
        }

        if (currentHrs >= 10)
        {
            timeTextMins.text = "  " + timeTextMins.text;
        }
    }

    void Update()
    {

    }
}