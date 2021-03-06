﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject SMenu;

    public void Start()
    {
        GameObject.Find("서브메뉴 매니저").GetComponent<SubMenu>().PDead();
    }

    public void OnClickNewGame()
    {
        Debug.Log("새 게임");
        SoundManager.instance.PlaySound2();
        StartCoroutine(DelayStart());
        GameObject.Find("서브메뉴 매니저").GetComponent<SubMenu>().PAlive();
    }


    IEnumerator DelayStart()
    {
        yield return new WaitForSeconds(1.5f);
        //SceneManager.LoadScene("맵 개발 씬");
        SMenu.gameObject.SetActive(false);
    }

    public void OnClickQuit()
    {
    #if UNITY_EDITOR
    UnityEditor.EditorApplication.isPlaying = false;
    #else
        Application.Quit();
    #endif
    }

    public void OnMouse()
    {
        Debug.Log("마우스 올림");
        SoundManager.instance.PlaySound1();
    }
    public void OutMouse()
    {
        Debug.Log("마우스 내림");
    }
}
