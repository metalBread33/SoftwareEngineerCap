using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{

    public void PlayTrack(string name)
    {
        Sound track = Array.Find(tracks, x => x.name == name);
        if (track == null)
            Debug.Log("Sound not found :(");
        else
        {
            trackSource.clip = track.clip;
            trackSource.Play();
        }
    }

    public void PlaySFX(string name)
    {
        Sound sfx = Array.Find(sFXs, x => x.name == name);
        if (sfx == null)
            Debug.Log("Sound not found :(");
        else
        {
            sFXSource.PlayOneShot(sfx.clip);
        }
    }

    public void StopTrack()
    {
        trackSource.Stop();
    }

    private void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
        PlayTrack("Theme");
    }
    public Sound[] tracks, sFXs;
    public AudioSource trackSource, sFXSource;
    public static AudioManager instance;
}
