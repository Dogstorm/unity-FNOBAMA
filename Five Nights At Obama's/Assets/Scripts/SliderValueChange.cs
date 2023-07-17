using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class SliderValueChange : MonoBehaviour
{

    public Slider slider;
    public TextMeshProUGUI sliderText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sliderText.text = slider.value.ToString();

        if (slider.name == "X-SensitivitySlider")
        {
            sliderText.text = (slider.value / 100).ToString();

        }
        else if (slider.name == "Y-SensitivitySlider")
        {
            sliderText.text = (slider.value / 100).ToString();
        }
        
    }
}
