using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubMenu : MonoBehaviour
{
    public Slider SVolume;
    public AudioSource audio;

    public GameObject GsubMenu;

    private float SVol = 1f;

    private void Start()
    {
        SVol = PlayerPrefs.GetFloat("SVol", 1f);
        SVolume.value = SVol;
        audio.volume = SVolume.value;
    }

    public void SoundSlider()
    {
        audio.volume = SVolume.value;
        SVol = SVolume.value;
        PlayerPrefs.SetFloat("SVol", SVol);
    }

    void Update()
    {
        SoundSlider();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameObject.Find("SoundManager").GetComponent<SoundManager>().PlaySound6();
            if (GsubMenu.activeSelf) { 
                GsubMenu.gameObject.SetActive(false);
                GameObject.Find("플레이어").GetComponent<PlayerStats>().speed = 2.0f;
                Time.timeScale = 1; } //활성화 -> 비활
            else {
                GsubMenu.gameObject.SetActive(true);
                GameObject.Find("플레이어").GetComponent<PlayerStats>().speed = 0.0f;
                Time.timeScale = 0; } //비활 -> 활성화
        }

    }

    public void SubMenuContinue()
    {
        GameObject.Find("SoundManager").GetComponent<SoundManager>().PlaySound6();
        GameObject.Find("플레이어").GetComponent<PlayerStats>().speed = 2.0f;
        
        GsubMenu.gameObject.SetActive(false);
        Time.timeScale = 1; //활성화 -> 비활
    }
    public void NoMoreGame()
    {
    #if UNITY_EDITOR
      UnityEditor.EditorApplication.isPlaying = false;
    #else
        Application.Quit();
    #endif
    }

}