using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class settings_script : MonoBehaviour
{
    public AudioMixer AudioMixer;
    public void setvolume(float volume)
    {
        AudioMixer.SetFloat("volume", volume);
    }
}
