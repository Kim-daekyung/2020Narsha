using Unity.Mathematics;
using UnityEngine;

public class TrackingPlayerColider : MonoBehaviour
{
    private GameObject traceTarget;
    private GameObject mobObject;
    private bool isTracing = false;
    private Animator animator;
<<<<<<< HEAD
    private int movementFlag = 0;
=======
    private EmAttack emAttack;
>>>>>>> main
    public float movePower = 35.0f;

    // Start is called before the first frame update
    private void Start()
    {
        mobObject = GameObject.Find("적몬스터");
        animator = mobObject.GetComponent<Animator>();
<<<<<<< HEAD
=======
        emAttack = GameObject.Find("적몬스터").GetComponent<EmAttack>();
>>>>>>> main
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

<<<<<<< HEAD
=======
            if (math.abs(playerPos.x - mobObject.transform.position.x) < 20)
            {
                animator.SetBool("isMoving", false);
                return;
            }

>>>>>>> main
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
<<<<<<< HEAD

        mobObject.transform.position += moveVelocity * movePower * Time.deltaTime;
    }

    private IEnumerator ChangeMovement()
    {
        movementFlag = Random.Range(0, 2);

        if (movementFlag == 0)
=======
        else if (dist == "idle")
>>>>>>> main
        {
            animator.SetBool("isMoving", false);
            return;
        }
<<<<<<< HEAD
        else
        {
            animator.SetBool("isMoving", true);
        }

        yield return new WaitForSeconds(3f);
=======
>>>>>>> main

        mobObject.transform.position += moveVelocity * movePower * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            traceTarget = collision.gameObject;
<<<<<<< HEAD

            StopCoroutine("ChangeMovement");
=======
>>>>>>> main
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