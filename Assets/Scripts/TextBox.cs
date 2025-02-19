using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextBox : MonoBehaviour
{
    public RectTransform spawnPoint;
    public TMP_Text textContents;
    
    public void placeTextbox(RectTransform tempPos, string tempText)
    {
        textContents.text = tempText;
        spawnPoint.anchoredPosition = tempPos.anchoredPosition;
    }

    void Update()
    {
        Destroy(gameObject, 6);
    }
}
