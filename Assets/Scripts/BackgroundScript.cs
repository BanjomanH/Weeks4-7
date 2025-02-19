using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BackgroundScript : MonoBehaviour
{
    public Sprite[] backgrounds = new Sprite[4];
    public GameObject bDropdown;
    Image thisBackground;
    void Start()
    {
        thisBackground = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        thisBackground.sprite = backgrounds[(int)bDropdown.GetComponent<TMP_Dropdown>().value];
    }
}
