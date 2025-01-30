using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public SpriteRenderer thisRender;
    public EnableDisable thisEnable;
    public GameObject go;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //thisRender.enabled = false;
            //thisEnable.enabled = false;
            go.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //thisRender.enabled = true;
            //thisEnable.enabled = true;
            go.SetActive(true);
        }
    }
}
