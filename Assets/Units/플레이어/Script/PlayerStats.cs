using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : Stats
{
    // Start is called before the first frame update
    private void Awake()
    {
        maxhp = 100;//최대 체력 변수
        curhp = 100;//기본적인 체력 변수
        curstemana = 100;//현재 스테마나 변수
        maxstemana = 100;//최대 스테마나 변수
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}
