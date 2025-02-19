using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class POVSliderCode : MonoBehaviour
{
    public string[] responses = new string[3];
    public Slider slider;
    public TMP_Text textBox;

    // Update is called once per frame
    void Update()
    {
        textBox.SetText(responses[(int)slider.value]);
    }
}
