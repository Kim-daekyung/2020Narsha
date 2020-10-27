using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioClip hyogwaum;
    AudioSource myAudio;
    
    public AudioClip hyogwaum2; 
    AudioSource myAudio2;

    public static SoundManager instance;

    void Awake()
    {
        if (SoundManager.instance == null) SoundManager.instance = this;
    }

    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        
    }
    public void PlaySound1()
    {
        myAudio.PlayOneShot(hyogwaum);
    }
    public void PlaySound2()
    {
        myAudio.PlayOneShot(hyogwaum2);
    }

}
