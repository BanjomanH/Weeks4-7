using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterVolumeScript : MonoBehaviour
{
    public GameObject textBox;
    public string[] responses = new string[9];
    bool isFirst = true;

    public void whenPressed(RectTransform buttonPos)
    {
        string tempAnswer = responses[(int)Random.Range(1, 8.99f)];
        if (isFirst == true)
        {
            isFirst = false;
            tempAnswer = responses[0];
        }

        Instantiate(textBox);
        textBox.GetComponent<TextBox>().placeTextbox(buttonPos, tempAnswer);
        Destroy(textBox, 6);
    }
}
