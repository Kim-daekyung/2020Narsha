using UnityEngine;

public class EmAttack : MonoBehaviour
{
    private GameObject playerObject;
    private PlayerStats playerStat;
    private Animator animator;
    private bool isMoving = false;
    public float attackPower = 10.0f;
    public bool isAttack = false;

    private void Start()
    {
        playerObject = GameObject.Find("플레이어");
        animator = GameObject.Find("적몬스터").GetComponent<Animator>();
        playerStat = playerObject.GetComponent<PlayerStats>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("굥격 범위 들어옴");
        if (collision.gameObject.tag == "Player")
        {
            animator.SetBool("isAttack", true);
            animator.SetBool("isMoving", false);
            isMoving = false;
            isAttack = true;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isAttack = false;
        animator.SetBool("isAttack", false);
        animator.SetBool("isMoving", true);
    }
}