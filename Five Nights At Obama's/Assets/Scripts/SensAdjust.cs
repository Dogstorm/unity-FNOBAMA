using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensAdjust : MonoBehaviour
{
    public GameObject mainCam;
    public float xSense;
    public float ySense;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xSense = mainCam.GetComponent<PlayerCam>().sensX;
        ySense = mainCam.GetComponent<PlayerCam>().sensY;


    }
}
