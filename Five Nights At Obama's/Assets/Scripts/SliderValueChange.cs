using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class SliderValueChange : MonoBehaviour
{
    [SerializeField]
    private xFloatSO xSenseSO;
    [SerializeField]
    private yFloatSO ySenseSO;

    public Slider slider;
    public TextMeshProUGUI sliderText;
    // Start is called before the first frame update
    void Start()
    {
        if (slider.name == "X-SensitivitySlider")
        {
            slider.value = xSenseSO.Value;

        }
        else if (slider.name == "Y-SensitivitySlider")
        {
            slider.value = ySenseSO.Value;
        }
    }

    // Update is called once per frame
    void Update()
    {
        sliderText.text = slider.value.ToString();

        if (slider.name == "X-SensitivitySlider")
        {
            float Sliderdiv = slider.value / 100;
            Sliderdiv = Mathf.Round(Sliderdiv * 100.0f) * 0.01f;
            sliderText.text = Sliderdiv.ToString();
            xSenseSO.Value = slider.value;

        }
        else if (slider.name == "Y-SensitivitySlider")
        {
            float Sliderdiv = slider.value / 100;
            Sliderdiv = Mathf.Round(Sliderdiv * 100.0f) * 0.01f;
            sliderText.text = Sliderdiv.ToString();
            ySenseSO.Value = slider.value;
        }
        
    }
}
