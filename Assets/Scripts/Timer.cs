using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Slider thisSlider;
    public float timer = 0;

    void Start()
    {
        thisSlider = GetComponent<Slider>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        thisSlider.value = timer % thisSlider.maxValue;
    }
}
