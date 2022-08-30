using System;
using UnityEngine;
using UnityEngine.Audio;

// sets up the sound structure that's accessed in the inspector

[System.Serializable]

public class Sound
{
    [HideInInspector]
    public AudioSource source;

    public enum AudioTypes { soundEffect, music }
    public AudioTypes audioType;

    public string name;
    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;

    [Range(0f, 3f)]
    public float pitch;

    public bool loop;
    public bool playOnAwake;
}

