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
        playerObject = GameObject.FindWithTag("Player");
        animator = transform.parent.GetComponent<Animator>();
        playerStat = playerObject.GetComponent<PlayerStats>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
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