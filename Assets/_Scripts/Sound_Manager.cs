using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Manager : MonoBehaviour {

    static Sound_Manager _instance = null;

    public AudioSource sfxSource;
    public AudioSource musicSource;

    public AudioClip music;
    public AudioClip fireSound;
    public AudioClip elevator;
    public AudioClip bElevator;

    // Use this for initialization
    void Start()
    {
        //Sound_Manager.instance.playMusic(Sound_Manager.instance.music);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static Sound_Manager instance
    {
        get { return _instance; }
        set { _instance = value; }
    }

    public void playSound(AudioClip clip, float volume = 1.0f)
    {
        // assign volume to AudioSource
        sfxSource.volume = volume;

        //assign clip to AudioSource clip
        sfxSource.clip = clip;

        //play assigned audioClip through AudioSource on SoundManager
        sfxSource.Play();
    }
    public void playMusic(AudioClip clip, float volume = 1.0f)
    {
        // assign volume to AudioSource
        musicSource.volume = volume;

        //assign clip to AudioSource clip
        musicSource.clip = clip;

        //play assigned audioClip through AudioSource on character
        musicSource.Play();

    }

}
