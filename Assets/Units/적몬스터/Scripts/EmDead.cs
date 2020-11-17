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
    }
}