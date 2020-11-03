using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TalkManager talkManager;     //talkManager를 참조
    public GameObject TalkPanel;        //대화창
    public GameObject NamePanel;        //대화창 이름 표시
    //public QuestManager questManager;
    public Text TalkText;               //대화 텍스트
    public GameObject ScanObject;       //게임 오브젝트 스캔
    public bool isAction = false;       //대화창을 열었는가
    public int talkIndex;

    public void Action(GameObject scanObject)
    {
        ScanObject = scanObject;
        ObjectData objectData = scanObject.GetComponent<ObjectData>();
        Talk(objectData.id, objectData.isNpc);

        //TalkText.text = "this is " + ScanObject.name + ".";

        TalkPanel.SetActive(isAction);
        NamePanel.SetActive(isAction);

    }

    void Talk(int id, bool isNpc)
    {
        //int questTalkIndex = questManager.GetQuestTextIndex(id);

        //string talkData = talkManager.GetTalk(id + questTalkIndex, talkIndex);
        string talkData = talkManager.GetTalk(id, talkIndex);

        if (talkData == null)
        {
            isAction = false;
            talkIndex = 0;
            return;
        }

        if (isNpc)
        {
            TalkText.text = talkData;
        }
        else
        {
            TalkText.text = talkData;
        }

        isAction = true;
        talkIndex++;
    }

}
