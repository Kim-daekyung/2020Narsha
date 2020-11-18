using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmOnOff : MonoBehaviour
{
    public GameObject s1e1 = GameObject.Find("적몬스터");
    public GameObject s1e2 = GameObject.Find("적몬스터 (1)");

    void Update()
    {
        if(GameObject.Find("스테이지 매니저").GetComponent<StageManager>().stage == 1)
        {
            s1e1.gameObject.SetActive(true);
            s1e2.gameObject.SetActive(true);
        }
        else
        {
            s1e1.gameObject.SetActive(false);
            s1e2.gameObject.SetActive(false);
        }
    }
}
