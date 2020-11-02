using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    public float movePower = 1.0f;

    private Animator animator;
    private Vector3 movement;
    private int movementFlag = 0;
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();

        StartCoroutine("ChangeMovement");
    }

    IEnumerator ChangeMovement()
    {
        movementFlag = Random.Range(0, 3);

        if (movementFlag == 0)
        {
            animator.SetBool("isMoving", false);
        }
        else
        {
            animator.SetBool("isMoving", true);
        } 
        yield return new WaitForSeconds(3.0f);

        StartCoroutine("ChangeMovement");
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        Vector3 moveVelocity = Vector3.zero;

        if (movementFlag == 1)
        {
            moveVelocity = Vector3.left;
            transform.localScale = new Vector3(1, 1, 1);
        } else if (movementFlag == 2)
        {
            moveVelocity = Vector3.right;
            transform.localScale = new Vector3(-1, 1, 1);
        }

        transform.position += moveVelocity * movePower * Time.deltaTime;
    }
}
