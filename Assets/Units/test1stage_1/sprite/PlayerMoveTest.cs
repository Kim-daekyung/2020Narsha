﻿using System.Collections;
using System.Collections.Generic;

using System.Diagnostics;

using UnityEngine;

public class PlayerMoveTest : MonoBehaviour
{
    float timer; //수정
    float waitingTime; //수정
    public Animator animator;
    private SpriteRenderer sprite;

    private float cooltime_attack = 0;
    
    PlayerStats player_stat = null;
    public PlayerUI playerui;

    public GameManager gameManager;     //GameManager를 참조
    public Rigidbody2D rigid;       //rigid를 위치 스캔

    public float talkTimer = 0.0f;
    int talklevel = 1;

    void Start()
    {
        rigid = this.GetComponent<Rigidbody2D>();   //Rigidbody2D를 참조

        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        player_stat = GetComponent<PlayerStats>();

        timer = 0.0f; //수정
        waitingTime = 0.3f; //수정
    }

    Vector3 vector = new Vector3();
    void Update()
    {
        if (rigid.position.x > 500 * talklevel)
        {
            //on
            gameManager.TalkPanel.SetActive(true);
            gameManager.NamePanel.SetActive(true);

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

                gameManager.TalkPanel.SetActive(false);
                gameManager.NamePanel.SetActive(false);

            }
        }

        if (cooltime_attack > 0) cooltime_attack -= Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Q) && cooltime_attack <= 0 && GameObject.Find("플레이어").GetComponent<PlayerStats>().speed == 2.0)//수정
        {
            cooltime_attack = 0.5f;
            animator.SetBool("Attack", true);
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
                transform.Translate(vector.x * player_stat.speed, 0, 0);


            }
            else if (vector.x == -1)
            {
                animator.SetBool("isWalk", true);
                sprite.flipX = true;
                transform.Translate(vector.x * player_stat.speed, 0, 0);


            }



        }
        else animator.SetBool("isWalk", false);

    }
}