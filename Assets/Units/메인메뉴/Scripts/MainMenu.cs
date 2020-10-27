using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnClickNewGame()
    {
        Debug.Log("새 게임");
        SoundManager.instance.PlaySound2();
        StartCoroutine(DelayStart());
    }

    IEnumerator DelayStart()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("맵 개발 씬");
    }

    public void OnClickLoad()
    {
        Debug.Log("불러오기");
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
