using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Experimental.AI;

public class BarrelCursor : MonoBehaviour
{
    public GameObject shell;
    public float bulletSpeed = 2;
    public float travelDistance = 5;

    void Update()
    {
        Vector3 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 target = cursorPos - transform.position;
        cursorPos.z = 0;
        transform.up = target;

        if (Input.GetMouseButtonDown(0))
        {
            GameObject tempShot = shell;
            shell.transform.position = transform.position;
            shell.transform.up = cursorPos;
            shell.GetComponent<ShotCode>().travelDistance = travelDistance;
            shell.GetComponent<ShotCode>().bulletSpeed = bulletSpeed;
            Instantiate(tempShot);
        }
    }
}
