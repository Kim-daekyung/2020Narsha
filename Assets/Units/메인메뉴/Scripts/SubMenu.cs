using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices;

public class SubMenu : MonoBehaviour
{
    public Slider SVolume;
    public AudioSource audio;

    public GameObject GsubMenu;
    public GameObject DMenu;
    public GameObject EMenu;

    private float SVol = 1f;

    private void Start()
    {
        PAlive();
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
                if (GsubMenu.activeSelf) //창이 떠 있으면
                {
                    GsubMenu.gameObject.SetActive(false);
                    PAlive();
                } //활성화 -> 비활
                else if (GsubMenu.activeSelf == false)
                {
                    GsubMenu.gameObject.SetActive(true);
                    PDead();
                
            } //비활 -> 활성화
        }
        if (GameObject.Find("플레이어").GetComponent<PlayerStats>().curhp <= 0) {
            PDead();
            DMenu.gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            if (EMenu.activeSelf) //창이 떠 있으면
            {
                EMenu.gameObject.SetActive(false);
                PAlive();
            } //활성화 -> 비활
            else if (EMenu.activeSelf == false)
            {
                EMenu.gameObject.SetActive(true);
                PDead();

            } //비활 -> 활성화

        }
    }

    public void restart() {
        DMenu.gameObject.SetActive(false);
        SceneManager.LoadScene(0);
    }

    public void PDead()
    {
        GameObject.Find("플레이어").GetComponent<PlayerStats>().speed = 0.0f;
        Time.timeScale = 0;
    }

    public void PAlive()
    {
        GameObject.Find("플레이어").GetComponent<PlayerStats>().speed = 2.0f;
        Time.timeScale = 1;
    }

    public void SubMenuContinue()
    {
        GameObject.Find("SoundManager").GetComponent<SoundManager>().PlaySound6();
        PAlive();      
        GsubMenu.gameObject.SetActive(false);
        //활성화 -> 비활
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