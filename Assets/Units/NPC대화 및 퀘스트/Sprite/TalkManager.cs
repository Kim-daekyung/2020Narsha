using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> TalkData; //대화창 데이터 저장
    public List<string> talkList;

    void Awake()
    {
        TalkData = new Dictionary<int, string[]>();
        GenerateTalkData();
    }

    void GenerateTalkData() //대화창 데이터
    {
        talkList.Add("none");   //NULL
        talkList.Add("스테이지 1 : 안녕?");
        talkList.Add("스테이지 2 : 이 곳에 처음 왔구나?");

        //talk
        TalkData.Add(5000, new string[] { "기다려" });
        /*TalkData.Add(1000, new string[] { "안녕?", "이 곳에 처음 왔구나?" });
        TalkData.Add(2000, new string[] { "잠시만...", "아직 공고 된 임무가 없어.", "나중에 다시 찾아와줘." });
        TalkData.Add(100, new string[] { "자극히 평범한 책상이다.", "아무래도 대화창 재작자가 이 책상을 까먹었나 보다." });*/

        //quest
        /*TalkData.Add(10 + 1000, new string[] { "어서와.", "이 곳에 처음 왔구나?",
            "첫 퀘스트는 옆에 QuestNpc가 알려 줄 꺼야" });   //첫 퀘스트
        TalkData.Add(10 + 2000, new string[] { "잠시만 기다려...",
            "그래 할 임무가 필요하다고 했지",
            "그전에 내가 노트를 잃어버려서 말이야.\n아주 중요한 노트라서...",
            "그럼 네가 할 수 있는 임무를 줄테니까." });*/
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
