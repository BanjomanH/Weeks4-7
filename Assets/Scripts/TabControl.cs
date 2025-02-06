using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class TabControl : MonoBehaviour
{
    public GameObject[] tabs = new GameObject[3];
    public AudioClip click;
    public float tabSetting;
    AudioSource switchSound;

    void Start()
    {
        switchSound = GetComponent<AudioSource>();
        setTab(1);
    }

    public void setTab(int tabNum)
    {
        switchSound.PlayOneShot(click);
        if (tabNum == 1)
        {
            tabs[0].SetActive(true);
            tabs[1].SetActive(false);
            tabs[2].SetActive(false);
        } else if (tabNum == 2)
        {
            tabs[0].SetActive(false);
            tabs[1].SetActive(true);
            tabs[2].SetActive(false);
        } else
        {
            tabs[0].SetActive(false);
            tabs[1].SetActive(false);
            tabs[2].SetActive(true);
        }
    }
}
