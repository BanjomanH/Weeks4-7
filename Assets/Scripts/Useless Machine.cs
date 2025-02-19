using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using UnityEngine;
using UnityEngine.UI;

public class UselessMachine : MonoBehaviour
{
    public RectTransform Switch;
    public RectTransform Hand;
    public RectTransform Cover;
    public bool isOn = false;
    float timer = 0;
    public AnimationCurve Curve;

    // Update is called once per frame
    void Update()
    {
        Vector2 tempPos = Vector2.zero;

        if (isOn == false)
        {
            tempPos.x = -35;
        } else
        {
            tempPos.x = 35;
        }
        Switch.anchoredPosition = tempPos;

        if (timer != 0)
        {
            timer += Time.deltaTime * 2;
        } else if (timer > 1)
        {
            timer = 0;
        }

        if (timer > 0.48f && timer < 0.52f)
        {
            isOn = false;
        }

        Hand.anchoredPosition = new Vector2(-1 - (Curve.Evaluate(timer) * 100), 0);
        Cover.anchoredPosition = new Vector2(-50 - (Curve.Evaluate(timer) * -50), 0);
        Cover.localScale = new Vector2(1.1f / (1 + Curve.Evaluate(timer) * 1.5f), 0.5f);
    }

    public void whenPresssed()
    {
        if (isOn == false)
        {
            isOn = true;
            timer = 0.01f;
        } else
        {
            isOn = false;
            if (timer < 0.5)
            {
                timer = 1 - timer;
            }
        }
    }
}
