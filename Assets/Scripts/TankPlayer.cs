using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class TankPlayer : MonoBehaviour
{
    public float speed;

    void Update()
    {
        Vector3 velocity = new Vector3();
        velocity.x = Input.GetAxis("Horizontal") * speed;
        velocity = transform.position + velocity * Time.deltaTime;
        transform.position = velocity;
    }
}
