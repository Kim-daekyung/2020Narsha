using System.Collections;
using UnityEngine;

public class EmAttack : MonoBehaviour
{
    private GameObject playerObject;
    private PlayerStats playerStat;
    private Animator animator;
    private bool isAttack = false;
    private bool isMoving = false;
    public float attackPower = 10.0f;

    private void Start()
    {
        playerObject = GameObject.Find("플레이어");
        animator = GameObject.Find("적몬스터").GetComponent<Animator>();
        playerStat = playerObject.GetComponent<PlayerStats>();
        Debug.Log("시작됨");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("굥격 범위 들어옴");
        if (collision.gameObject.tag == "Player")
        {
            animator.SetBool("isAttack", true);
            isAttack = true;
            isMoving = false;

            playerStat.curhp -= 10;
            Debug.Log("공격 완료");
            StartCoroutine("WaitSeconds");
        }
    }

    private IEnumerator WaitSeconds()
    {
        yield return new WaitForSeconds(3.0f);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (isAttack)
        {
            isAttack = false;
            animator.SetBool("isAttack", false);
        }
    }
}