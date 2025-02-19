using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//Credit to https://www.youtube.com/watch?v=gXPxYzJCU4I for the construction noises!

public class ConstructionVolumeScript : MonoBehaviour
{
    public AudioClip constructionSFX;
    public AudioSource soundPlayer;
    public Slider slider;

    // Update is called once per frame
    void Update()
    {
        soundPlayer.volume = slider.value;

        if (soundPlayer.isPlaying == false)
        {
            soundPlayer.PlayOneShot(constructionSFX);
        }
    }
}
