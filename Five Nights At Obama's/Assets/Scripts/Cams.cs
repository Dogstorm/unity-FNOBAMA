using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cams : MonoBehaviour, IInteractable
{
    [SerializeField]
    private Battery battery;
    public Camera Cam1;
    public Camera Cam2;
    public Camera Cam3;
    public Camera Cam4;
    public Light Cam4Light;
    public Camera Cam5;
    public Camera playerCam;
    public float startCamera = 1;
    public bool camsActivated = false;
    public GameObject Player;
    public GameObject mainCamera;
    public GameObject promptText;
    public GameObject crossHair;

    private int currentCam;

    public void Interact()
    {
        playerCam.enabled = false;
        Cam1.enabled = true;
        camsActivated = true;
        Player.SetActive(false);
        mainCamera.SetActive(false);
        promptText.SetActive(false);
        crossHair.SetActive(false);
        battery.drainOverTime = !battery.drainOverTime;
    }

    // Start is called before the first frame update
    void Awake()
    {
        Cam1.enabled = false;
        Cam2.enabled = false;
        Cam3.enabled = false;
        Cam4.enabled = false;
        Cam5.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentCam = currentCam + 1;
            if (currentCam == 6)
            {
                currentCam = 1;
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentCam = currentCam - 1;
            if (currentCam == 0)
            {
                currentCam = 5;
            }
        }


        if (camsActivated == false)
        {
            playerCam.enabled = true;
            Cam1.enabled = false;
            Cam2.enabled = false;
            Cam3.enabled = false;
            Cam4.enabled = false;
            Cam5.enabled = false;
            
        }
        if (currentCam == 1 && camsActivated == true)
        {
            startCamera = 2;
            Cam1.enabled = false;
            Cam2.enabled = true;
            Cam3.enabled = false;
            Cam4.enabled = false;
            Cam5.enabled = false;
        }
        else if (currentCam == 2 && camsActivated == true)
        {
            startCamera = 3;
            Cam1.enabled = false;
            Cam2.enabled = false;
            Cam3.enabled = true;
            Cam4.enabled = false;
            Cam5.enabled = false;
            
        }
        else if (currentCam == 3 && camsActivated == true)
        {
            startCamera = 4;
            Cam1.enabled = false;
            Cam2.enabled = false;
            Cam3.enabled = false;
            Cam4.enabled = true;
            Cam5.enabled = false;

        }
        else if (currentCam == 4 && camsActivated == true)
        {
            startCamera = 5;
            Cam1.enabled = false;
            Cam2.enabled = false;
            Cam3.enabled = false;
            Cam4.enabled = false;
            Cam5.enabled = true;

        }
        else if (currentCam == 5 && camsActivated == true)
        {
            startCamera = 1;
            Cam1.enabled = true;
            Cam2.enabled = false;
            Cam3.enabled = false;
            Cam4.enabled = false;
            Cam5.enabled = false;
            
        }
        if (Input.GetKeyDown(KeyCode.E) && camsActivated == true)
        {
            camsActivated = false;
            Player.SetActive(true);
            mainCamera.SetActive(true);
            promptText.SetActive(true);
            crossHair.SetActive(true);
            battery.drainOverTime = false;
        }
        
        if (Cam4.enabled == false)
        {
            Cam4Light.enabled = false;
        }
        else if (Cam4.enabled == true)
        {
            Cam4Light.enabled = true;
        }
    }
}
