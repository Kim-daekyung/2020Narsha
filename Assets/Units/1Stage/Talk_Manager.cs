using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talk_Manager : MonoBehaviour
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
        talkList.Add("스테이지 3 : 이 곳에 처음 왔구나?");
        talkList.Add("스테이지 4 : 이 곳에 처음 왔구나?");
        talkList.Add("스테이지 5 : 이 곳에 처음 왔구나?");
        talkList.Add("스테이지 6 : 이 곳에 처음 왔구나?");
        talkList.Add("스테이지 7 : 이 곳에 처음 왔구나?");
        talkList.Add("스테이지 8 : 이 곳에 처음 왔구나?");
        talkList.Add("스테이지 9 : 이 곳에 처음 왔구나?");
        talkList.Add("스테이지 10 : 이 곳에 처음 왔구나?");

        //talk
        TalkData.Add(5000, new string[] { "기다려" });
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