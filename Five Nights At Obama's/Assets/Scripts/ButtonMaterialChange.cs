using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMaterialChange : MonoBehaviour
{
    public Material redMaterial;
    public Material greenMaterial;
    private Renderer rend;
    [SerializeField] GameObject buttonHitBox;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
         if (buttonHitBox.GetComponent<Door>().doorOpen == false)
        {
            rend.sharedMaterial = redMaterial;
        }
         else if (buttonHitBox.GetComponent<Door>().doorOpen == true)
        {
            rend.sharedMaterial = greenMaterial;
        }
    }
}
