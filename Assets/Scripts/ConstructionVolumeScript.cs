using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//Credit to https://www.youtube.com/watch?v=gXPxYzJCU4I for the construction noises!

public class ConstructionVolumeScript : MonoBehaviour
{
    public AudioClip constructionSFX; // An AudioClip containing construction noises
    public AudioSource soundPlayer; // An AudioSource file to play the audio clip
    public Slider slider; // A reference to the construction noises slider gameObject

    void Update()
    {
        // sets the volume slider value to the sound player value as well
        soundPlayer.volume = slider.value;

        // If the audioClip has stopped playing, then play it again.
        if (soundPlayer.isPlaying == false)
        {
            soundPlayer.PlayOneShot(constructionSFX);
        }
    }
}
