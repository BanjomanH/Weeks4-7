using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class TankPlayer : MonoBehaviour
{
    public Sprite[] tankAppearance = new Sprite[4];
    public SpriteRenderer tankRenderer;
    public float speed;
    public float spriteSelected = 0;

    public GameObject TSprite;
    public GameObject TSpeed;

    void Update()
    {
        spriteSelected = TSprite.GetComponent<Slider>().value;
        speed = TSpeed.GetComponent<Slider>().value;

        tankRenderer.sprite = tankAppearance[(int)spriteSelected];
        Vector3 velocity = new Vector3();
        velocity.x = Input.GetAxis("Horizontal") * speed;
        velocity = transform.position + velocity * Time.deltaTime;
        transform.position = velocity;
    }
    public void setSprite(float tempSpeed)
    {
        speed = tempSpeed;
    }
    public void setSpeed(int sprite)
    {
        spriteSelected = sprite;
    }
}
