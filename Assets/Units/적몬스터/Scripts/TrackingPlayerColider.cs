using System.Collections;
using Unity.Mathematics;
using UnityEngine;

public class TrackingPlayerColider : MonoBehaviour
{
    private GameObject traceTarget;
    private GameObject mobObject;
    private bool isTracing = false;
    private Animator animator;
    private EmAttack emAttack;
    public float movePower = 35.0f;
    public bool canMoving = true;

    // Start is called before the first frame update
    private void Start()
    {
        mobObject = transform.parent.gameObject;
        animator = mobObject.GetComponent<Animator>();
        emAttack = mobObject.GetComponent<EmAttack>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Move();
    }

    public void DelayCoroutine()
    {
        StartCoroutine("StartDelay");
    }

    private IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(0.5f);
    }

    private void Move()
    {
        Vector3 moveVelocity = Vector3.zero;
        string dist = "";

        if (isTracing && canMoving)
        {
            Vector3 playerPos = GameObject.FindWithTag("Player").transform.position;

            if (math.abs(playerPos.x - mobObject.transform.position.x) < 20)
            {
                animator.SetBool("isMoving", false);
                return;
            }

            if (playerPos.x <= mobObject.transform.position.x)
            {
                dist = "Left";
            }
            else if (playerPos.x > mobObject.transform.position.x)
            {
                dist = "Right";
            }
        }
        else
        {
            dist = "idle";
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            traceTarget = collision.gameObject;

            StopCoroutine("ChangeMovement");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isTracing = true;
            animator.SetBool("isMoving", true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isTracing = false;
            animator.SetBool("isMoving", false);
        }
    }
}