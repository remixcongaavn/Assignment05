using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Text toggleMusictxt;

    public void Start()
    {
        if(MusicScript.MusicInstance.Audio.isPlaying)
        {
            toggleMusictxt.text = "OFF";
        } else
        {
            toggleMusictxt.text = "ON";
        }
    }

    public void MusicToggle()
    {
        if(MusicScript.MusicInstance.Audio.isPlaying)
        {
            MusicManager.MusicMan.Audio.PlayOneShot(MusicManager.MusicMan.Click);
            MusicScript.MusicInstance.Audio.Pause();
            toggleMusictxt.text = "ON";
        } else
        {
            MusicManager.MusicMan.Audio.PlayOneShot(MusicManager.MusicMan.Click);
            MusicScript.MusicInstance.Audio.Play();
            toggleMusictxt.text = "OFF";
        }
    }
}
