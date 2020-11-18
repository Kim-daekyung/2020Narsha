using UnityEngine;

public class EmDead : MonoBehaviour
{
    private EmStats emStats;

    private void Start()
    {
        emStats = GetComponent<EmStats>();
    }

    [System.Obsolete]
    void EnermyDead()
    {
        DestroyObject(gameObject);
        //gameObject.SetActive(true);
        if (GameObject.Find("스테이지 매니저").GetComponent<StageManager>().stage == 1)
            GameObject.Find("스테이지 매니저").GetComponent<StageManager>().s1e -= 1; //수정

        if (GameObject.Find("스테이지 매니저").GetComponent<StageManager>().stage == 2)
            GameObject.Find("스테이지 매니저").GetComponent<StageManager>().s2e -= 1; //수정

        if (GameObject.Find("스테이지 매니저").GetComponent<StageManager>().stage == 3)
            GameObject.Find("스테이지 매니저").GetComponent<StageManager>().s3e -= 1; //수정
    }
}