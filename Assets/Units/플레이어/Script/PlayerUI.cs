using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    private Image content;
    public float lerpSpeed;
    public PlayerStats pstats; 

    private float currentFill = 1;
    void Awake()
    {
        content = GetComponent<Image>();
       // pstats = GameObject.Find("플레이어").GetComponent<PlayerStats>();
    }
    void Start()
    {
        pstats = GameObject.Find("플레이어").GetComponent<PlayerStats>();
    }
    void Update()
    {
        
       
        //(float)curhp-(curstema/10)-emattack-def/maxhp;
        currentFill = (float)pstats.curhp / pstats.maxhp;
        if (currentFill != content.fillAmount)
        {
            content.fillAmount = Mathf.Lerp(content.fillAmount, currentFill, Time.deltaTime * lerpSpeed);

        }
    }
}
