using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BackgroundScript : MonoBehaviour
{
    public Sprite[] backgrounds = new Sprite[4]; // An array containing the sprites of all the selectable background
    public GameObject bDropdown; // A reference to the background dropdown gameObject
    Image thisBackground; // A reference to the image component. Used for setting the background
    void Start()
    {
        // Assigns the background to the component found on the same gameObject
        thisBackground = GetComponent<Image>();
    }

    void Update()
    {
        // Set the backgrounds spriteRenderer to be the selected image based on the dropdown value
        thisBackground.sprite = backgrounds[(int)bDropdown.GetComponent<TMP_Dropdown>().value];
    }
}
