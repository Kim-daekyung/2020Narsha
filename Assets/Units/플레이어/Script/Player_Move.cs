using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;



public class Player_Move : MonoBehaviour 
{
    
    float timer; //수정
    float waitingTime; //수정
    public Animator animator;
    private SpriteRenderer sprite;

    private float cooltime_attack = 0;

    public Game_Manager gameManager;     //GameManager를 참조
    public Rigidbody2D rigid;           //rigid를 위치 스캔

    PlayerStats player_stat = null;
    public PlayerUI playerui;

    public float talkTimer = 0.0f;
    int talklevel = 1;
    public PullEffect pulleffect = null;
    

    float ctimer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        rigid = this.GetComponent<Rigidbody2D>();   //Rigidbody2D를 참조
        pulleffect = GameObject.Find("pullEffect").GetComponent<PullEffect>();
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        player_stat = GetComponent<PlayerStats>();
        
        //playerui= GameObject.Find("체력바").GetComponent<PlayerUI>();
        //playerui.pstats = GetComponent<PlayerStats>();
        timer = 0.0f; //수정
        waitingTime = 0.3f; //수정
    }

    // Update is called once per frame
	Vector3 vector = new Vector3();
    void Update()
    {
        /*if (rigid.position.x > 500 * talklevel)
        {
            //on
            gameManager.TalkPanel.SetActive(true);
            gameManager.NamePanel.SetActive(true);

            gameManager.systemName(5000);
            gameManager.text.SetMessage(gameManager.talkManager.talkList[talklevel]);

            talklevel++;

            //N초 기다리기
            talkTimer = 3.0f;

        }*/

        if (talkTimer != 0.0f)
        {
            talkTimer = talkTimer - Time.deltaTime;
            if (talkTimer < 0.1f || Input.GetKeyDown(KeyCode.Space))
            {
                talkTimer = 0.0f;

                gameManager.TalkPanel.SetActive(false);
                gameManager.NamePanel.SetActive(false);

            }
        }

        if (cooltime_attack > 0) cooltime_attack -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Q)){
            ctimer = 0.0f;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            ctimer += Time.deltaTime;
            if (ctimer > 0.5f)
            {
                pulleffect.ONEffect();
            }
        }
        if (Input.GetKeyUp(KeyCode.Q) && cooltime_attack <= 0 && GameObject.Find("플레이어").GetComponent<PlayerStats>().speed == 2.0)//수정
        {
            if (ctimer > 0.5f)
            {
                pulleffect.OFFEffect();
                animator.SetTrigger("PullAttack");
            }
            else
            {
                
                cooltime_attack = 0.5f;
                animator.SetBool("Attack", true);
            }
        }
        else animator.SetBool("Attack", false);

        if (Input.GetAxisRaw("Horizontal") != 0
            && GameObject.Find("플레이어").GetComponent<PlayerStats>().speed == 2.0) //수정

        {
            timer += Time.deltaTime;//수정 시작

            if (timer > waitingTime)
            {
                GameObject.Find("SoundManager").GetComponent<SoundManager>().PlaySound5();
                timer = 0;
            }//수정 끝

            vector.Set(Input.GetAxisRaw("Horizontal"), transform.position.y, transform.position.z);
            if (vector.x == 1)
            {
                animator.SetBool("isWalk", true);
                sprite.flipX = false;
                transform.Translate(vector.x * player_stat .speed, 0, 0);


            }
            else if (vector.x == -1)
            {
                animator.SetBool("isWalk", true);
                sprite.flipX = true;
                transform.Translate(vector.x * player_stat .speed, 0, 0);


            }
            


        }
        else animator.SetBool("isWalk", false);

    }

    void AttackEnermy2()
    {
        //em_stat.curhp -= 10;

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Stage1Wall"
            && GameObject.Find("스테이지 매니저").GetComponent<StageManager>().stage == 1
            && GameObject.Find("스테이지 매니저").GetComponent<StageManager>().s1e <= 0)
        {
            GameObject.Find("스테이지 매니저").GetComponent<StageManager>().stage = 2;
            //좌표 이동 구현 필요
            gameObject.transform.position = new Vector2(566, -10);
        }
    }

}

