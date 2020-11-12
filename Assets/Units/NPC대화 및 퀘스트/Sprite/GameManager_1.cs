using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager_1 : MonoBehaviour
{
    public TalkManager talkManager;     //talkManager를 참조
    public NameManager nameManager;     //nameManager를 참조
    public GameObject TalkPanel;        //대화창
    public GameObject NamePanel;        //대화창 이름 표시
    //public QuestManager questManager;
    //public Text TalkText;             //대화 텍스트
    public TypeEffect text;             //대화 텍스트 이펙트
    public Text NameText;               //이름 텍스트
    //public GameObject ScanObject;       //게임 오브젝트 스캔

    public bool isAction = false;       //대화창을 열었는가
    public int talkIndex;               //대화 인덱스
    public int nameIndex;               //이름 인덱스

    public void systemName(int textId)
    {
        nameText(textId, true);

    }

    public void Start()
    {
        TalkPanel.SetActive(false);
        NamePanel.SetActive(false);
    }

    /*public void Action(GameObject scanObject)
    {
        ScanObject = scanObject;
        ObjectData objectData = scanObject.GetComponent<ObjectData>();
        Talk(objectData.id, objectData.isNpc);

        //TalkText.text = "this is " + ScanObject.name + ".";

        TalkPanel.SetActive(isAction);
        NamePanel.SetActive(isAction);
    }*/

    /*public void Talk(int id, bool isNpc)
    {
        //int questTalkIndex = questManager.GetQuestTextIndex(id);

        //string talkData = talkManager.GetTalk(id + questTalkIndex, talkIndex);
        string talkData = talkManager.GetTalk(id, talkIndex);

        nameText(id, isNpc);    //이름 표기 함수

        if (talkData == null)
        {
            isAction = false;
            talkIndex = 0;
            //Debug.Log(questManager.CheakQuest(id));
            return;
        }

        if (isNpc)
        {
            //TalkText.text = talkData;
            text.SetMessage(talkData);
        }
        else
        {
            //TalkText.text = talkData;
            text.SetMessage(talkData);
        }

        isAction = true;
        talkIndex++;
        
    }*/

    public void nameText(int id, bool isNpc)
    {
        string nameData = nameManager.GetName(id, nameIndex);

        if (isAction == false)
        {
            NameText.text = nameData;
        }
    }

}
