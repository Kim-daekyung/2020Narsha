using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHp : PlayerStats
{
    [SerializeField]
    private Slider hpbar= null;

    void Start()
    {
        hpbar.value = (float)curhp / (float)maxhp;
    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            curhp -= 10;
        }
        HandleHp();
    }

    private void HandleHp()
    {
        hpbar.value= Mathf.Lerp(hpbar.value,(float)curhp / (float)maxhp,Time.deltaTime);

    }
}
