using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextBox : MonoBehaviour
{
    public RectTransform spawnPoint; // The place the box is directed to spawn at
    public TMP_Text textContents; // A reference to the text container attached to the box
    
    // Called from a button to place the textBox in the correct place
    public void placeTextbox(RectTransform tempPos, string tempText)
    {
        // Assigns the correct text contents
        textContents.text = tempText;
        // Sets the anchored spawn position to the inputted one
        spawnPoint.anchoredPosition = tempPos.anchoredPosition;
    }

    // Destroys itself after 6 seconds
    void Update()
    {
        Destroy(gameObject, 6);
    }
}
