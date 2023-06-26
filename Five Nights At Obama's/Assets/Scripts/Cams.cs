using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cams : MonoBehaviour, IInteractable
{
    public Camera Cam1;
    public Camera Cam2;
    public Camera Cam3;
    public Camera playerCam;
    public float startCamera = 1;
    public bool camsActivated = false;
    public GameObject Player;
    public GameObject mainCamera;
    public void Interact()
    {
        playerCam.enabled = false;
        Cam1.enabled = true;
        camsActivated = true;
       Player.SetActive(false);
        mainCamera.SetActive(false);

    }
   
    // Start is called before the first frame update
    void Start()
    {
       Cam1.enabled = false;
       Cam2.enabled = false;
       Cam3.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (camsActivated == false)
        {
            playerCam.enabled = true;
            Cam1.enabled = false;
            Cam2.enabled = false;
            Cam3.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && startCamera == 1 && camsActivated == true)
        {
            startCamera = 2;
            Cam1.enabled = false;
            Cam2.enabled = true;
            Cam3.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && startCamera == 2 && camsActivated == true)
        {
            startCamera = 3;
            Cam1.enabled = false;
            Cam2.enabled = false;
            Cam3.enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && startCamera == 3 && camsActivated == true)
        {
            startCamera = 1;
            Cam1.enabled = true;
            Cam2.enabled = false;
            Cam3.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.E) && camsActivated == true)
        {
            camsActivated = false;
            Player.SetActive(true);
            mainCamera.SetActive(true);
        }
    }
}
