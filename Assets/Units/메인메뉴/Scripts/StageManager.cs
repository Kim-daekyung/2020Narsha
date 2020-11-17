using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    public int stage; //현재 스테이지

    public GameObject s1w; //스테이지1 벽
    public int s1e=2; //스테이지1 에 존재하는 총 적 수

    //void Start()
    //{
    //    stage = 1;
    //}

    //// Update is called once per frame
    //void Update()
    //{

<<<<<<< HEAD
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) stage += 1;
        if (Input.GetKeyDown(KeyCode.DownArrow)) stage -= 1;
        UnityEngine.Debug.Log(s1e);
    }
=======
    //    if (Input.GetKeyDown(KeyCode.UpArrow)) stage += 1;
    //    if (Input.GetKeyDown(KeyCode.DownArrow)) stage -= 1;


    //}
>>>>>>> c8321f0817ec5a9d29a35d130b9b8b383fecaf41
}
