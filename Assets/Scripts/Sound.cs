﻿using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class Sound : MonoBehaviour
{
    public static Sound player { get; private set; }
    public AudioClip impact;
    AudioSource Audio;

    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider coll)
    {
        // When player enters play audio
        if (player)
        {
            Audio.PlayOneShot(impact, 1.0f);
        }
    }
}
