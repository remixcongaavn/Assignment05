using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    public static MusicScript MusicInstance;
    public AudioSource Audio;

    private void Awake()
    {
        if (MusicInstance != null && MusicInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        MusicInstance = this;
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        Audio = GetComponent<AudioSource>();
    }
}
