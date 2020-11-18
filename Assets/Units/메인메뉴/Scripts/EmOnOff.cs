using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmOnOff : MonoBehaviour
{
    public GameObject s1e1 = GameObject.Find("적몬스터");
    public GameObject s1e2 = GameObject.Find("적몬스터 (1)");

    public GameObject s2e1 = GameObject.Find("적몬스터 (2)");
    public GameObject s2e2 = GameObject.Find("적몬스터 (3)");
    public GameObject s2e3 = GameObject.Find("적몬스터 (5)");
    public GameObject s2e4 = GameObject.Find("적몬스터 (6)");
    public GameObject s2e5 = GameObject.Find("적몬스터 (7)");
    public GameObject s2e6 = GameObject.Find("적몬스터 (9)");
    public GameObject s2e7 = GameObject.Find("적몬스터 (15)");
    public GameObject s2e8 = GameObject.Find("적몬스터 (14)");
    public GameObject s2e9 = GameObject.Find("적몬스터 (17)");
    public GameObject s2e10 = GameObject.Find("적몬스터 (23)");
    public GameObject s2e11 = GameObject.Find("적몬스터 (22)");
    public GameObject s2e12 = GameObject.Find("적몬스터 (25)");
    public GameObject s2e13 = GameObject.Find("적몬스터 (30)");


    public GameObject s3e1 = GameObject.Find("적몬스터 (4)");
    public GameObject s3e2 = GameObject.Find("적몬스터 (11)");
    public GameObject s3e3 = GameObject.Find("적몬스터 (10)");
    public GameObject s3e4 = GameObject.Find("적몬스터 (8)");
    public GameObject s3e5 = GameObject.Find("적몬스터 (13)");
    public GameObject s3e6 = GameObject.Find("적몬스터 (12)");
    public GameObject s3e7 = GameObject.Find("적몬스터 (12)");
    public GameObject s3e8 = GameObject.Find("적몬스터 (19)");
    public GameObject s3e9 = GameObject.Find("적몬스터 (18)");
    public GameObject s3e10 = GameObject.Find("적몬스터 (16)");
    public GameObject s3e11 = GameObject.Find("적몬스터 (21)");
    public GameObject s3e12 = GameObject.Find("적몬스터 (20)");
    public GameObject s3e13 = GameObject.Find("적몬스터 (27)");
    public GameObject s3e14 = GameObject.Find("적몬스터 (26)");
    public GameObject s3e15 = GameObject.Find("적몬스터 (24)");
    public GameObject s3e16 = GameObject.Find("적몬스터 (31)");
    public GameObject s3e17 = GameObject.Find("적몬스터 (29)");
    public GameObject s3e18 = GameObject.Find("적몬스터 (28)");

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

        if (GameObject.Find("스테이지 매니저").GetComponent<StageManager>().stage == 2)
        {
            s2e1.gameObject.SetActive(true);
            s2e2.gameObject.SetActive(true);
            s2e3.gameObject.SetActive(true);
            s2e4.gameObject.SetActive(true);
            s2e5.gameObject.SetActive(true);
            s2e6.gameObject.SetActive(true);
            s2e7.gameObject.SetActive(true);
            s2e8.gameObject.SetActive(true);
            s2e9.gameObject.SetActive(true);
            s2e10.gameObject.SetActive(true);
            s2e11.gameObject.SetActive(true);
            s2e12.gameObject.SetActive(true);
            s2e13.gameObject.SetActive(true);
        }
        else
        {
            s2e1.gameObject.SetActive(false);
            s2e2.gameObject.SetActive(false);
            s2e3.gameObject.SetActive(false);
            s2e4.gameObject.SetActive(false);
            s2e5.gameObject.SetActive(false);
            s2e6.gameObject.SetActive(false);
            s2e7.gameObject.SetActive(false);
            s2e8.gameObject.SetActive(false);
            s2e9.gameObject.SetActive(false);
            s2e10.gameObject.SetActive(false);
            s2e11.gameObject.SetActive(false);
            s2e12.gameObject.SetActive(false);
            s2e13.gameObject.SetActive(false);
        }

        if (GameObject.Find("스테이지 매니저").GetComponent<StageManager>().stage == 3)
        {
            s3e1.gameObject.SetActive(true);
            s3e2.gameObject.SetActive(true);
            s3e3.gameObject.SetActive(true);
            s3e4.gameObject.SetActive(true);
            s3e5.gameObject.SetActive(true);
            s3e6.gameObject.SetActive(true);
            s3e7.gameObject.SetActive(true);
            s3e8.gameObject.SetActive(true);
            s3e9.gameObject.SetActive(true);
            s3e10.gameObject.SetActive(true);
            s3e11.gameObject.SetActive(true);
            s3e12.gameObject.SetActive(true);
            s3e13.gameObject.SetActive(true);
            s3e14.gameObject.SetActive(true);
            s3e15.gameObject.SetActive(true);
            s3e16.gameObject.SetActive(true);
            s3e17.gameObject.SetActive(true);
            s3e18.gameObject.SetActive(true);
        }
        else
        {
            s3e1.gameObject.SetActive(false);
            s3e2.gameObject.SetActive(false);
            s3e3.gameObject.SetActive(false);
            s3e4.gameObject.SetActive(false);
            s3e5.gameObject.SetActive(false);
            s3e6.gameObject.SetActive(false);
            s3e7.gameObject.SetActive(false);
            s3e8.gameObject.SetActive(false);
            s3e9.gameObject.SetActive(false);
            s3e10.gameObject.SetActive(false);
            s3e11.gameObject.SetActive(false);
            s3e12.gameObject.SetActive(false);
            s3e13.gameObject.SetActive(false);
            s3e14.gameObject.SetActive(false);
            s3e15.gameObject.SetActive(false);
            s3e16.gameObject.SetActive(false);
            s3e17.gameObject.SetActive(false);
            s3e18.gameObject.SetActive(false);
        }
    }
}
