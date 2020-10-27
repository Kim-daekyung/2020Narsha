using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMenu : MonoBehaviour
{
    public GameObject GsubMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (GsubMenu.activeSelf) GsubMenu.gameObject.SetActive(false);
            else GsubMenu.gameObject.SetActive(true);
        }

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