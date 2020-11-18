using UnityEngine;

public class EmAttack : MonoBehaviour
{
    private GameObject playerObject;
    private PlayerStats playerStat;
    private Animator animator;
    private Animator playerAnimator;
    private bool isMoving = false;
    public float attackPower = 10.0f;
    public bool isAttack = false;

    private void Start()
    {
        animator = transform.parent.GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            playerObject = GameObject.FindWithTag("Player");
            playerStat = playerObject.GetComponent<PlayerStats>();
            playerAnimator = playerObject.GetComponent<Animator>();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerObject = GameObject.FindWithTag("Player");
            playerStat = playerObject.GetComponent<PlayerStats>();
            playerAnimator = playerObject.GetComponent<Animator>();
            animator.SetBool("isAttack", true);
            animator.SetBool("isMoving", false);
            isMoving = false;
            isAttack = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            isAttack = false;
            animator.SetBool("isAttack", false);
            animator.SetBool("isMoving", true);
            playerObject = null;
            playerStat = null;
        }
    }

    public void AttackPlayer()
    {
        if (playerObject != null)
        {
            playerStat.curhp -= 10;
            playerAnimator.Play("player_damzing");

            Debug.Log("데미지");
            if (playerStat.curhp <= 0)
            {
                playerAnimator.Play("player_death");
                Debug.Log("DEAD");
            }
        }
    }
}