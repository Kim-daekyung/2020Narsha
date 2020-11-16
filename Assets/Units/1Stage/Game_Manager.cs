using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Manager : MonoBehaviour
{
    public Talk_Manager talkManager;     //talkManager를 참조
    public Name_Manager nameManager;     //nameManager를 참조
    public GameObject TalkPanel;        //대화창
    public GameObject NamePanel;        //대화창 이름 표시

    public Type_Effect text;             //대화 텍스트 이펙트
    public Text NameText;               //이름 텍스트

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

    public void nameText(int id, bool isNpc)
    {
        string nameData = nameManager.GetName(id, nameIndex);

        if (isAction == false)
        {
            NameText.text = nameData;
        }
    }
}
