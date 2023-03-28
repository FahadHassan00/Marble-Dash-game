using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Settings : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void SetVol(float volume)
    {
        audioMixer.SetFloat("vol",volume);  

    }

}
