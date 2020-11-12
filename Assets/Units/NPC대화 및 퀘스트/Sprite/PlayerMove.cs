using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float timer; //수정
    float waitingTime; //수정
    public Animator animator;
    private SpriteRenderer sprite;
    private float cooltime_attack = 0;
    PlayerStats player_stat = null;

    //대화창을 위한 변수
    public GameManager gameManager;     //GameManager를 참조
    //GameObject ScanObject = null;   //오브젝트를 스캔
    public Rigidbody2D rigid;       //rigid를 이용한 물리적 움직임 제어
    //public ObjectData objectData;
    //protected Vector3 dirVec;       //Ray 생성을 위해 선언
    public float talkTimer = 0.0f;
    int talklevel = 1;

    // Start is called before the first frame update
    void Start()
    {
        rigid = this.GetComponent<Rigidbody2D>();   //Rigidbody2D를 참조
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        player_stat = GetComponent<PlayerStats>();

        timer = 0.0f; //수정
        waitingTime = 0.3f; //수정
    }

    void FixedUpdate()
    {
        //Ray();          //조사 함수
    }

    /*void Ray()  //조사 함수
    {
        Debug.DrawRay(rigid.position, dirVec * 30.0f, new Color(0, 1, 0));
        RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, dirVec, 30.0f, LayerMask.GetMask("Object"));
        //Ray 범위 안에 Object layer을 가진 오브잭트가 있을 때 ScanObject에 해당 gameObject를 저장
        
        if (rayHit.collider != null)
        {
            ScanObject = rayHit.transform.gameObject;
        }
        else
        {
            ScanObject = null;
        }
    }*/

    /*void Survey()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("This is : " + ScanObject.name);
            gameManager.Action(ScanObject.transform.gameObject);
        }
        
    }*/

    // Update is called once per frame
    Vector3 vector = new Vector3();
    
    void Update()
    {

        if (rigid.position.x > 200 * talklevel)
        {

            /*gameManager.NamePanel.SetActive(true);
            gameManager.TalkPanel.SetActive(true);
            
            Debug.Log("over");
            gameManager.Talk(5000, true);
            talklevel++;*/

            //on
            gameManager.TalkPanel.SetActive(true);
            gameManager.NamePanel.SetActive(true);

            Debug.Log("on : " + gameManager.talkManager.talkList[talklevel]);
            gameManager.systemName(5000);
            gameManager.text.SetMessage(gameManager.talkManager.talkList[talklevel]);

            talklevel++;

            //N초 기다리기
            talkTimer = 3.0f;

        }

        if (talkTimer != 0.0f)
        {
            talkTimer = talkTimer - Time.deltaTime;
            if (talkTimer < 0.1f || Input.GetKeyDown(KeyCode.Space))
            {
                talkTimer = 0.0f;

                Debug.Log("talk off");

                gameManager.TalkPanel.SetActive(false);
                gameManager.NamePanel.SetActive(false);

            }
        }

        //space
        /*if(Input.GetKeyDown(KeyCode.Space))
        {
            //off
            
            
        }*/

        /*if (ScanObject != null)   //space를 눌렀을 때, ScanObject가 null이 아닐 때
        {
            Survey();
        }*/

        if (cooltime_attack > 0) cooltime_attack -= Time.deltaTime;
        animator.SetBool("isWalk", false);


        if (Input.GetKeyDown(KeyCode.Q) && cooltime_attack <= 0)
        {
            animator.SetBool("Attack", true);
            cooltime_attack = 1;
            if (Input.GetAxisRaw("Horizontal") == 0)
                GameObject.Find("SoundManager").GetComponent<SoundManager>().PlaySound3();//수정부분

        }
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            timer += Time.deltaTime;//수정 시작

            if (timer > waitingTime)
            {
                //GameObject.Find("SoundManager").GetComponent<SoundManager>().PlaySound5();
                timer = 0;
            }//수정 끝

            vector.Set(Input.GetAxisRaw("Horizontal"), transform.position.y, transform.position.z);
            //if (vector.x == 1 && gameManager.isAction == false)         //Manager.isAction == false, 대화창이 열였을 때는 움직임을 멈춘다 
            if (vector.x == 1)
            {
                animator.SetBool("isWalk", true);
                sprite.flipX = false;
                transform.Translate(vector.x * player_stat.speed, 0, 0);
                //dirVec = Vector3.right; //dirVec의 값을 right로 지정
            }
            //else if (vector.x == -1 && gameManager.isAction == false)   //Manager.isAction == false, 대화창이 열였을 때는 움직임을 멈춘다 
            else if (vector.x == -1)
            {
                animator.SetBool("isWalk", true);
                sprite.flipX = true;
                transform.Translate(vector.x * player_stat.speed, 0, 0);
                //dirVec = Vector3.left;  //dirVec의 값을 left로 지정
            }
        }
    }
}