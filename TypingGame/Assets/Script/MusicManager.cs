using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource Audio;
    public AudioClip Click;

    public static MusicManager MusicMan;

    private void Awake()
    {
        if (MusicMan != null && MusicMan != this)
        {
            Destroy(this.gameObject);
            return;
        }

        MusicMan = this;
        DontDestroyOnLoad(this);
    }
}
