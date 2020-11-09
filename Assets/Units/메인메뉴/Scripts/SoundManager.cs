using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioClip hyogwaum; //switch3_2
    AudioSource myAudio;
    
    public AudioClip hyogwaum2; //피 물보라
    AudioSource myAudio2;
    
    public AudioClip hyogwaum3; //흐에1
    AudioSource myAudio3;
    
    public AudioClip hyogwaum4; //흐에2
    AudioSource myAudio4;  
    
    public AudioClip hyogwaum5; //step
    AudioSource myAudio5;  
    
    public AudioClip hyogwaum6; //menu negative
    AudioSource myAudio6;

    

    public static SoundManager instance;

    void Awake()
    {
        if (SoundManager.instance == null) SoundManager.instance = this;
    }

    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        
    }
    public void PlaySound1() //switch
    {
        myAudio.PlayOneShot(hyogwaum);
    }
    public void PlaySound2() //피 물보라
    {
        myAudio.PlayOneShot(hyogwaum2);
    }
    public void PlaySound3() //흐에1
    {
        myAudio.PlayOneShot(hyogwaum3);
    }    
    public void PlaySound4() //흐에2
    {
        myAudio.PlayOneShot(hyogwaum4);
    }
    public void PlaySound5() //step
    {
        myAudio.PlayOneShot(hyogwaum5);
    }    
    public void PlaySound6() //menu negative
    {
        myAudio.PlayOneShot(hyogwaum6);
    }
    //GameObject.Find("SoundManager").GetComponent<SoundManager>().PlaySound3(); 다른 소스에서 함수 참조
}
