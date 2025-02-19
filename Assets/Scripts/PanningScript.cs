using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanningScript : MonoBehaviour
{
    public GameObject textBox;
    public string[] responses = new string[2];

    public void whenPressed(RectTransform buttonPos)
    {
        string tempAnswer = responses[0];
        if (Random.Range(0, 100) > 15)
        {
            tempAnswer = responses[0];
        } else
        {
            tempAnswer = responses[1];
        }

        Instantiate(textBox);
        textBox.GetComponent<TextBox>().placeTextbox(buttonPos, tempAnswer);
    }
}