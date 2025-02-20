using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChangeStat : MonoBehaviour
{
    public GameObject target;
    public float distance;

    void Start()
    {
        //target.GetComponent(test);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(target.transform.position, transform.position) < distance)
        {
            Debug.Log("touched");
        }
    }
}
