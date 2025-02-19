using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using UnityEngine;
using UnityEngine.UI;

public class UselessMachine : MonoBehaviour
{
    public RectTransform Switch; // A reference to the uselessMachine gameObject
    public RectTransform Hand; // A reference to the hand gameObject
    public RectTransform Cover; // A reference to the cover gameObject
    public bool isOn = false; // A bool telling the code whether the switch is flipped or not
    float timer = 0; // A float containing the amount of time used for the animation
    public AnimationCurve Curve; // An animation curve for the hand moving there and back

    // Update is called once per frame
    void Update()
    {
        // Creates a temp variable for the position of the lever
        Vector2 tempPos = Vector2.zero;

        // Places the lever depending on if the switch is on or off
        if (isOn == false)
        {
            tempPos.x = -35;
        } else
        {
            tempPos.x = 35;
        }
        // Places the switch at the temporary position
        Switch.anchoredPosition = tempPos;

        // If the timer has started, then begin to increment it up
        if (timer != 0)
        {
            timer += Time.deltaTime * 2;
        // if the timer has completed the animation then reset the timer
        } else if (timer > 1)
        {
            timer = 0;
        }

        // If the animation curve is roughly at half, then turn off the switch
        if (timer > 0.48f && timer < 0.52f)
        {
            isOn = false;
        }

        // Set the position of the hand under the switch along the animation curve
        Hand.anchoredPosition = new Vector2(-1 - (Curve.Evaluate(timer) * 100), 0);
        // Set the position of the cover of the switch along the inverse animation curve
        Cover.anchoredPosition = new Vector2(-50 - (Curve.Evaluate(timer) * -50), 0);
        // Sets the size of the cover along the animation curve
        Cover.localScale = new Vector2(1.1f / (1 + Curve.Evaluate(timer) * 1.5f), 0.5f);
    }

    // Script that is called when the switch is pressed
    public void whenPresssed()
    {
        // Checks to see whether the switch is on or off, and toggles it
        if (isOn == false)
        {
            isOn = true;
            // Starts the timer if the switch is turned on
            timer = 0.01f;
        } else
        {
            isOn = false;
            // If timer is less than 0.5, then increase it by the difference between its current value and 0.5
            if (timer < 0.5)
            {
                timer = 1 - timer;
            }
        }
    }
}
