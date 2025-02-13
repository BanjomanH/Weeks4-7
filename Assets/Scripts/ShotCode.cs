using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotCode : MonoBehaviour
{
    public float bulletSpeed = 2;
    public float travelDistance = 5;
    Vector3 velocity;

    void Update()
    {
        velocity.y -= 0.01f;
        velocity = transform.up * bulletSpeed * Time.deltaTime;
        transform.position += velocity;
        Destroy(gameObject, travelDistance);
    }
}
