using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardTarget : MonoBehaviour
{
    public GameObject target;

    // Update is called once per frame
    void Update()
    {
        Vector2 rotatePos = target.transform.position - transform.position;
        Vector3 velocity = transform.up * rotatePos * Time.deltaTime;

        transform.position += velocity;
        velocity = transform.right * rotatePos * Time.deltaTime;

        transform.position += velocity;
    }
}
