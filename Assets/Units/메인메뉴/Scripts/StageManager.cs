using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{

    void Start()
    {
        stage = 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow)) stage += 1;
        if (Input.GetKeyDown(KeyCode.DownArrow)) stage -= 1;


    }
}
