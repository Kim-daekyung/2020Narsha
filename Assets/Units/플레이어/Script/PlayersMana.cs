using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayersMana :PlayerStats
{
    private Image scontent;
    public float lerpSpeed;

    private float scurrentFill = 1;
    void Awake()
    {
        scontent = GetComponent<Image>();
    }
    void Update()
    {
        scurrentFill = (float)curstemana/ maxstemana;
        if (scurrentFill != scontent.fillAmount)
        {
            scontent.fillAmount = Mathf.Lerp(scontent.fillAmount, scurrentFill, Time.deltaTime * lerpSpeed);

        }
    }
}
