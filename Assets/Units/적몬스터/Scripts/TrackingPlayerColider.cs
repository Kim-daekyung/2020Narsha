using System.Collections;
using UnityEngine;

public class TrackingPlayerColider : MonoBehaviour
{
    private GameObject traceTarget;
    private GameObject mobObject;
    private bool isTracing = false;
    private Animator animator;
    private int movementFlag = 0;
    public float movePower = 35.0f;

    // Start is called before the first frame update
    private void Start()
    {
        mobObject = GameObject.Find("적몬스터");
        animator = mobObject.GetComponent<Animator>();
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
            Vector3 playerPos = GameObject.Find("플레이어").transform.position;

            if (playerPos.x <= mobObject.transform.position.x)
            {
                Debug.Log("Left");
                dist = "Left";
            }
            else if (playerPos.x > mobObject.transform.position.x)
            {
                Debug.Log("Right");
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
            mobObject.transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
            animator.SetBool("isMoving", true);
            animator.SetInteger("Direction", 1);
        }
        else if (dist == "Right")
        {
            moveVelocity = Vector3.right;
            mobObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            animator.SetBool("isMoving", true);
            animator.SetInteger("Direction", -1);
        }

        mobObject.transform.position += moveVelocity * movePower * Time.deltaTime;
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
            isTracing = true;
            animator.SetBool("isMoving", true);
            Debug.Log("isMoving true");
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