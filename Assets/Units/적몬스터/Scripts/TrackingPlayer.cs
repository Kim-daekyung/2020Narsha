using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class TrackingPlayer : MonoBehaviour
{
    public enum CurrentState
    {
        idle,
        trace,
        attack,
        dead
    };

    public CurrentState curState = CurrentState.idle;

    private Transform _transform;
    private Transform playerTransform;
    private NavMeshAgent nvAgent;

    public float traceDist = 100.0f;
    public float attackDist = 50.0f;

    private bool isDead = false;

    private void Start()
    {
        _transform = this.GetComponent<Transform>();
        playerTransform = GameObject.Find("플레이어").GetComponent<Transform>();
        nvAgent = this.gameObject.GetComponent<NavMeshAgent>();

        StartCoroutine(this.CheckState());
        StartCoroutine(this.CheckStateForAction());
    }

    private IEnumerator CheckState()
    {
        while (!isDead)
        {
            yield return new WaitForSeconds(0.2f);

            float dist = Vector3.Distance(playerTransform.position, _transform.position);

            if (dist <= attackDist)
            {
                curState = CurrentState.attack;
            }
            else if (dist <= traceDist)
            {
                curState = CurrentState.trace;
            }
            else
            {
                curState = CurrentState.idle;
            }

            Debug.Log(curState);
        }
    }

    private IEnumerator CheckStateForAction()
    {
        while (!isDead)
        {
            switch (curState)
            {
                case CurrentState.idle:
                    break;

                case CurrentState.trace:
                    break;

                case CurrentState.attack:
                    break;
            }
            yield return null;
        }
    }
}