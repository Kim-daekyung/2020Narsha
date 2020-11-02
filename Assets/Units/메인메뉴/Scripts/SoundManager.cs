using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioClip hyogwaum;
    AudioSource myAudio;
    
    public AudioClip hyogwaum2; 
    AudioSource myAudio2;
    
    public AudioClip hyogwaum3; 
    AudioSource myAudio3;

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
    public void PlaySound3()
    {
        myAudio.PlayOneShot(hyogwaum3);
    }
    //GameObject.Find("SoundManager").GetComponent<SoundManager>().PlaySound3(); 다른 소스에서 함수 참조
}
