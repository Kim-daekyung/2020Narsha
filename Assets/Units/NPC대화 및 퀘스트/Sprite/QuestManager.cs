/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public int questId;
    public int questActionIndex;

    Dictionary<int, QuestData> questList;

    void Awake()
    {
        questList = new Dictionary<int, QuestData>();
    }

    void GenerateData()
    {
        questList.Add(10, new QuestData("마을 사람과 대화하기", new int[] { 1000, 2000 }));
        questList.Add(20, new QuestData("노트 찾기", new int[] { 2000, 100 }));
    }

    public int GetQuestTextIndex(int id)
    {
        return questId + questActionIndex;  //퀘스트가 끝나면 questId가 1증가
    }

    public string CheakQuest(int id)
    {
        if (id == questList[questId].npcId[questActionIndex])
        {
            questActionIndex++;                 //퀘스트가 끝나면 1증가
        }
        if (questActionIndex == questList[questId].npcId.Length)
        {
            NextQuest();
        }

        return questList[questId].questName;
    }

    void NextQuest()
    {
        questId += 10;
        questActionIndex = 0;
    }
}*/