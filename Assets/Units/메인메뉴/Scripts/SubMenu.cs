using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMenu : MonoBehaviour
{
    public GameObject GsubMenu;

    void Update()
    {
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