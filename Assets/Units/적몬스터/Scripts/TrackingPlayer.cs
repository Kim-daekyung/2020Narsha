using System.Collections;
using UnityEngine;

public class TrackingPlayer : MonoBehaviour
{
    public float movePower = 20.0f;
    private SpriteRenderer renderer;
    private Vector3 movement;
    public int movementFlag;
    private Animator animator;

    private void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        StartCoroutine("ChangeMovement");
    }

    private void FixedUpdate()
    {
        Move();
    }

    private IEnumerator ChangeMovement()
    {
        movementFlag = Random.Range(0, 2);

        if (movementFlag == 0)
        {
            animator.SetBool("isMoving", false);
        }
        else
        {
            animator.SetBool("isMoving", true);
        }

        yield return new WaitForSeconds(3f);

        StartCoroutine("ChangeMovement");
    }

    private void Move()
    {
        Vector3 moveVelocity = Vector3.zero;

        if (movementFlag == 1)
        {
            moveVelocity = Vector3.left;
            transform.localScale = new Vector3(-0.16f, 0.16f, 1);
            animator.SetBool("isMoving", true);
            animator.SetInteger("Direction", 1);
        }
        else if (movementFlag == 2)
        {
            moveVelocity = Vector3.right;
            transform.localScale = new Vector3(0.16f, 0.16f, 1);
            animator.SetBool("isMoving", true);
            animator.SetInteger("Direction", -1);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }

        transform.position += moveVelocity * movePower * Time.deltaTime;
    }
}