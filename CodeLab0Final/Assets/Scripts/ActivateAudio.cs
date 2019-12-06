using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAudio : MonoBehaviour
{
    public AudioSource audioClip;


    public void PhoneRing() //call on start button click to make phone ring
    {
        audioClip = GetComponent<AudioSource>();
        audioClip.Play();
    }

    public void PickedUp() //call when player picks up to stop ringing
    {
        audioClip = GetComponent<AudioSource>();
        audioClip.Stop();
    }
}
