using UnityEngine;

public class EmDead : MonoBehaviour
{
    private EmStats emStats;

    private void Start()
    {
        emStats = GetComponent<EmStats>();
    }

    void EnermyDead()
    {
        DestroyObject(GameObject.Find("적몬스터"));
    }
}