using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class POVSliderCode : MonoBehaviour
{
    public string[] responses = new string[3]; // An array containing all of the responses above the slider
    public Slider slider; // A reference to the POV slider gameobject
    public TMP_Text textBox; // A reference to the textBox place 

    void Update()
    {
        // Assigns the text above the slider to the correct response using the sliders value
        textBox.SetText(responses[(int)slider.value]);
    }
}
