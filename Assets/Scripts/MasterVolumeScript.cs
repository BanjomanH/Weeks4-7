using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class MasterVolumeScript : MonoBehaviour
{
    public GameObject textBox; // A reference to the text box gameObject prefab
    public string[] responses = new string[9]; // A list of all 9 responses that master volume can say
    bool isFirst = true; // A boolean for whether master volume should introduce himself

    // Whenever the mastervolume button is depressed this script is activated with the position of the button as input
    public void whenPressed(RectTransform buttonPos)
    {
        // Create a temporary string variable for what Master Volume will say
        string tempAnswer = responses[(int)Random.Range(1, 8.99f)];
        // If IsFirst is true then use the first element of the Responses variable, if not then use the 2nd to 9th responses.
        if (isFirst == true)
        {
            isFirst = false;
            tempAnswer = responses[0];
        }

        // Instantiate a new Textbox with the temporary variable set to occupy the text field
        textBox.GetComponent<TextBox>().placeTextbox(buttonPos, tempAnswer);
        Instantiate(textBox);
    }
}
