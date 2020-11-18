using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talk_Manager : MonoBehaviour
{
    public Game_Manager gameManager;

    public List<string> talkList;

    public int stage = 0;

    public int talklevel = 1;
    public float talkTimer = 0.0f;

    void Awake()
    {
        GenerateTalkData();
    }

    void GenerateTalkData() //대화창 데이터
    {
        talkList.Add("NULL");           //NULL
        talkList.Add("STAGE1START");    //1스테이지
        talkList.Add("STAGE2START");
        talkList.Add("STAGE3START");
    }

    void Update()
    {
        if (talkTimer != 0.0f)
        {
            //Debug.Log("대사 출력");
            talkTimer += -Time.deltaTime;


            if (talkTimer <= 0 || Input.GetKeyDown(KeyCode.Space))
            {
                talkTimer = 0.0f;

                gameManager.TalkPanel.SetActive(false);
                gameManager.NamePanel.SetActive(false);
            }
        }
    }

    public void OnStageStart(int inputStage)
    {
        stage = inputStage;
        talkTimer = 3.0f;
        talklevel = 0;

        gameManager.TalkPanel.SetActive(true);
        gameManager.NamePanel.SetActive(true);
        gameManager.systemName(5000);
        gameManager.text.SetMessage(gameManager.talkManager.talkList[gameManager.stage]);

    }
}