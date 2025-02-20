using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 3;
    public float gold = 0;
    public TMP_Text goldCount;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 velocity = new Vector3(x, y, 0);

        transform.position += velocity * speed * Time.deltaTime;

        goldCount.text = "Gold: " + gold;
    }
}
