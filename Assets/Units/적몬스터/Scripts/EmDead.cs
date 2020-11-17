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
        GameObject.Find("스테이지 매니저").GetComponent<StageManager>().s1e -= 1; //수정
    }
}