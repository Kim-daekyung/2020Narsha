using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour 
{
    float timer; //수정
    float waitingTime; //수정

    public Animator animator;
    private SpriteRenderer sprite;
    private float cooltime_attack = 0;
    PlayerStats player_stat =null;
    
    // Start is called before the first frame update
    void Start()
    {
       
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
       player_stat = GetComponent<PlayerStats>();

        timer = 0.0f; //수정
        waitingTime = 0.3f; //수정
    }

    // Update is called once per frame
	Vector3 vector = new Vector3();
    void Update()
    {

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

    }
}