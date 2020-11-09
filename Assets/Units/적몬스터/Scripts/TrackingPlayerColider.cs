using System.Collections;
using UnityEngine;

public class TrackingPlayerColider : MonoBehaviour
{
    private GameObject traceTarget;
    private bool isTracing = false;
    private Animator animator;
    private int movementFlag = 0;
    public float movePower = 5.0f;

    // Start is called before the first frame update
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        Vector3 moveVelocity = Vector3.zero;
        string dist = "";

        if (isTracing)
        {
            Vector3 playerPos = traceTarget.transform.position;

            if (playerPos.x < transform.position.x)
            {
                dist = "Left";
            }
            else if (playerPos.x > transform.position.x)
            {
                dist = "Right";
            }
        }
        else
        {
            if (movementFlag == 1)
            {
                dist = "Left";
            }
            else if (movementFlag == 2)
            {
                dist = "Right";
            }
        }

        if (dist == "Left")
        {
            moveVelocity = Vector3.left;
            transform.localScale = new Vector3(-0.16f, 0.16f, 1);
            animator.SetBool("isMoving", true);
            animator.SetInteger("Direction", 1);
        }
        else if (dist == "Right")
        {
            moveVelocity = Vector3.right;
            transform.localScale = new Vector3(0.16f, 0.16f, 1);
            animator.SetBool("isMoving", true);
            animator.SetInteger("Direction", -1);
        }

        transform.position += moveVelocity * movePower * Time.deltaTime;
    }

    private IEnumerator ChangeMovement()
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

        yield return new WaitForSeconds(5f);

        StartCoroutine("ChangeMovement");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            traceTarget = collision.gameObject;
            Debug.Log("범위 들어옴");

            StopCoroutine("ChangeMovement");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if ((int)collision.gameObject.transform.position.x - (int)transform.position.x < 10)
            {
                isTracing = false;
                animator.SetBool("isMoving", false);
            }
            else
            {
                isTracing = true;
                animator.SetBool("isMoving", true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isTracing = false;
            animator.SetBool("isMoving", false);

            StartCoroutine("ChangeMovement");
        }
    }
}