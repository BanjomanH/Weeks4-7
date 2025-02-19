using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanningScript : MonoBehaviour
{
    public GameObject textBox; // A reference to the text box gameObject prefab
    public string[] responses = new string[2]; // A collection of the string responses that the button can produce

    public void whenPressed(RectTransform buttonPos)
    {
        // If random.range produces a number greater than 15, set a temporary response variable to be “No Gold…”, if not then set the response variable to be “Gold!”
        string tempAnswer = responses[0];
        if (Random.Range(0, 100) > 15)
        {
            tempAnswer = responses[0];
        } else
        {
            tempAnswer = responses[1];
        }

        // Instantiate a new Textbox with the temporary variable set to occupy the text field
        textBox.GetComponent<TextBox>().placeTextbox(buttonPos, tempAnswer);
        Instantiate(textBox);
    }
}