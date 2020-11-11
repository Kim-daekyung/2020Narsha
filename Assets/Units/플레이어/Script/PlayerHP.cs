using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : PlayerStats
{
    private Image content;
    public float lerpSpeed;

    private float currentFill = 1;
    void Awake()
    {
        content = GetComponent<Image>();
    }
    void Update()
    {
        currentFill = (float)curhp / maxhp;
        if (currentFill != content.fillAmount)
        {
            content.fillAmount = Mathf.Lerp(content.fillAmount, currentFill, Time.deltaTime * lerpSpeed);

        }
    }
}
