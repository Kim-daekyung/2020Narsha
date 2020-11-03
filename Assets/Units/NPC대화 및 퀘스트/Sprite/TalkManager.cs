using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> TalkData; //대화창 데이터 저장

    void Awake()
    {
        TalkData = new Dictionary<int, string[]>();
        GenerateTalkData();
    }

    void GenerateTalkData() //대화창 데이터
    {
        //talk
        TalkData.Add(1000, new string[] { "안녕?", "이 곳에 처음 왔구나?" });
        TalkData.Add(2000, new string[] { "잠시만...", "아직 공고 된 임무가 없어.", "나중에 다시 찾아와줘." });
        TalkData.Add(100, new string[] { "자극히 평범한 책상이다.", "아무래도 대화창 재작자가 이 책상을 까먹었나 보다." });

        //quest
        TalkData.Add(10 + 1000, new string[] { "어서와.", "이 곳에 처음 왔구나?",
            "첫 퀘스트는 옆에 QuestNpc가 알려 줄 꺼야" });   //첫 퀘스트
        TalkData.Add(10 + 2000, new string[] { "잠시만 기다려...",
            "그래 할 임무가 필요하다고 했지",
            "우선 옆에 desk에서 길드에 이름을 등록하고와.", "그럼 네가 할 수 있는 임무를 줄테니까." });
    }

    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == TalkData[id].Length)
        {
            return null;
        }
        else
        {
            return TalkData[id][talkIndex];
        }
    }
}
