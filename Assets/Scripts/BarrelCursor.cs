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
    public Sprite[] shotAppearance = new Sprite[7];
    public int spriteSelected = 0;
    public AudioSource shotPlayer;
    public AudioClip shotSFX;

    void Update()
    {
        Vector3 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 target = cursorPos - transform.position;
        cursorPos.z = 0;
        transform.up = target;

        if (Input.GetMouseButtonDown(0))
        {
            shotPlayer.PlayOneShot(shotSFX);
            GameObject tempShot = shell;
            shell.transform.position = transform.position;
            shell.transform.up = cursorPos;
            shell.GetComponent<ShotCode>().travelDistance = travelDistance;
            shell.GetComponent<ShotCode>().bulletSpeed = bulletSpeed;
            shell.GetComponentInChildren<SpriteRenderer>().sprite = shotAppearance[spriteSelected];
            Instantiate(tempShot);
        }
    }
}
