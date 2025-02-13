using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class TankPlayer : MonoBehaviour
{
    public Sprite[] tankAppearance = new Sprite[4];
    public SpriteRenderer tankRenderer;
    public float speed;
    public int spriteSelected = 0;

    void Update()
    {
        tankRenderer.sprite = tankAppearance[spriteSelected];
        Vector3 velocity = new Vector3();
        velocity.x = Input.GetAxis("Horizontal") * speed;
        velocity = transform.position + velocity * Time.deltaTime;
        transform.position = velocity;
    }
}
