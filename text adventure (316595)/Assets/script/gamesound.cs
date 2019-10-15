using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class gamesound : MonoBehaviour
    

{
    public AudioMixer AudioMixer;
    public void setvolume(float volume)
    {
        AudioMixer.SetFloat("game", volume);
    }
}
