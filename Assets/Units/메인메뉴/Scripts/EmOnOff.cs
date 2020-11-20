using UnityEngine;

public class EmOnOff : MonoBehaviour
{
    public GameObject s1e1;
    public GameObject s1e2;

    public GameObject s2e1;
    public GameObject s2e2;
    public GameObject s2e3;
    public GameObject s2e4;
    public GameObject s2e5;
    public GameObject s2e6;
    public GameObject s2e7;
    public GameObject s2e8;
    public GameObject s2e9;
    public GameObject s2e10;
    public GameObject s2e11;
    public GameObject s2e12;
    public GameObject s2e13;

    public GameObject s3e1;
    public GameObject s3e2;
    public GameObject s3e3;
    public GameObject s3e4;
    public GameObject s3e5;
    public GameObject s3e6;
    public GameObject s3e7;
    public GameObject s3e8;
    public GameObject s3e9;
    public GameObject s3e10;
    public GameObject s3e11;
    public GameObject s3e12;
    public GameObject s3e13;
    public GameObject s3e14;
    public GameObject s3e15;
    public GameObject s3e16;
    public GameObject s3e17;
    public GameObject s3e18;

    private void Start()
    {
        s1e1 = GameObject.Find("적몬스터");

        s1e2 = GameObject.Find("적몬스터 (1)");

        s2e1 = GameObject.Find("적몬스터 (2)");
        s2e2 = GameObject.Find("적몬스터 (3)");
        s2e3 = GameObject.Find("적몬스터 (5)");
        s2e4 = GameObject.Find("적몬스터 (6)");
        s2e5 = GameObject.Find("적몬스터 (7)");
        s2e6 = GameObject.Find("적몬스터 (9)");
        s2e7 = GameObject.Find("적몬스터 (15)");
        s2e8 = GameObject.Find("적몬스터 (14)");
        s2e9 = GameObject.Find("적몬스터 (17)");
        s2e10 = GameObject.Find("적몬스터 (23)");
        s2e11 = GameObject.Find("적몬스터 (22)");
        s2e12 = GameObject.Find("적몬스터 (25)");
        s2e13 = GameObject.Find("적몬스터 (30)");

        s3e1 = GameObject.Find("적몬스터 (4)");
        s3e2 = GameObject.Find("적몬스터 (11)");
        s3e3 = GameObject.Find("적몬스터 (10)");
        s3e4 = GameObject.Find("적몬스터 (8)");
        s3e5 = GameObject.Find("적몬스터 (13)");
        s3e6 = GameObject.Find("적몬스터 (12)");
        s3e7 = GameObject.Find("적몬스터 (12)");
        s3e8 = GameObject.Find("적몬스터 (19)");
        s3e9 = GameObject.Find("적몬스터 (18)");
        s3e10 = GameObject.Find("적몬스터 (16)");
        s3e11 = GameObject.Find("적몬스터 (21)");
        s3e12 = GameObject.Find("적몬스터 (20)");
        s3e13 = GameObject.Find("적몬스터 (27)");
        s3e14 = GameObject.Find("적몬스터 (26)");
        s3e15 = GameObject.Find("적몬스터 (24)");
        s3e16 = GameObject.Find("적몬스터 (31)");
        s3e17 = GameObject.Find("적몬스터 (29)");
        s3e18 = GameObject.Find("적몬스터 (28)");
    }

    private void Update()
    {
        if (GameObject.Find("스테이지 매니저").GetComponent<StageManager>().stage == 1)
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