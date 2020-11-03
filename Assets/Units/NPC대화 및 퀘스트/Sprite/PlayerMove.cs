using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameManager Manager;     //GameManager를 참조
    public float speed;
    private Vector3 vector;
    public Animator animator;
    private SpriteRenderer sprite;
    private float cooltime_attack = 0;
    GameObject ScanObject = null;   //오브젝트를 스캔
    public Rigidbody2D rigid;       //rigid를 이용한 물리적 움직임 제어
    protected Vector3 dirVec;

    void Start()
    {
        rigid = this.GetComponent<Rigidbody2D>();   //Rigidbody2D를 참조
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        Ray();  //조사 함수
    }

    void Ray()  //조사 함수
    {
        Debug.DrawRay(rigid.position, dirVec * 30.0f, new Color(0, 1, 0));
        RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, dirVec, 30.0f, LayerMask.GetMask("Object"));
        //Ray 범위 안에 Object layer을 가진 오브잭트가 있을 때 ScanObject에 해당 gameObject를 저장

        if (rayHit.collider != null)
        {
            ScanObject = rayHit.collider.gameObject;
        }
        else
        {
            ScanObject = null;
        }

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && ScanObject != null)  //space를 눌렀을 때, ScanObject가 null이 아닐 때
        {
            Debug.Log("This is : " + ScanObject.name);
            Manager.Action(ScanObject);

        }

        if (cooltime_attack > 0) cooltime_attack -= Time.deltaTime;
        animator.SetBool("isWalk", false);


        if (Input.GetKeyDown(KeyCode.Q) && cooltime_attack <= 0)
        {
            animator.SetBool("Attack", true);
            cooltime_attack = 1;

        }
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            vector.Set(Input.GetAxisRaw("Horizontal"), transform.position.y, transform.position.z);
            if (vector.x == 1 && Manager.isAction == false)         //Manager.isAction == false 대화창이 열렸는가
            {
                dirVec = Vector3.right; //dirVec의 값을 right로 지정
                animator.SetBool("isWalk", true);
                sprite.flipX = false;
                transform.Translate(vector.x * speed, 0, 0);

            }
            else if (vector.x == -1 && Manager.isAction == false)   //Manager.isAction == false 대화창이 열렸는가
            {
                dirVec = Vector3.left;  //dirVec의 값을 left로 지정
                animator.SetBool("isWalk", true);
                sprite.flipX = true;
                transform.Translate(vector.x * speed, 0, 0);

            }

        }

    }


}