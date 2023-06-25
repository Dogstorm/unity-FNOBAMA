using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour
{
    public bool toggle;
    public GameObject Door;
    // Start is called before the first frame update
    void Start()
    {
        toggle = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.E))
        {
            if (toggle == false)
            {
                Door.SetActive(false);
                toggle = true;
                Debug.Log("true");
            }
            else if (toggle == true)
            {
                Door.SetActive(true);
                toggle = false;
            }
            
           
            }
        
        }
}

