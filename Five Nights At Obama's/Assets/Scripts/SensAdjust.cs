using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensAdjust : MonoBehaviour
{
    public GameObject mainCam;
    public float xSense { get; set; }
    public float ySense { get; set; }
    string Sensekey = "Sense";
    
    // Update is called once per frame
    void Update()
    {
        xSense = mainCam.GetComponent<PlayerCam>().sensX;
        ySense = mainCam.GetComponent<PlayerCam>().sensY;
    }

    private void Awake()
    {
        xSense = PlayerPrefs.GetFloat(Sensekey);
    }

    public void SetSense(float sense)
    {
        PlayerPrefs.SetFloat(Sensekey, sense);
    }
}
