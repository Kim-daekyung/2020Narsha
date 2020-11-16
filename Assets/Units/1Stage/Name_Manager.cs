using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Name_Manager : MonoBehaviour
{
    Dictionary<int, string[]> NameData; //이름 데이터 저장

    void Awake()
    {
        NameData = new Dictionary<int, string[]>();
        GenerateNameData();
    }

    void GenerateNameData()
    {
        NameData.Add(5000, new string[] { "주인공" });
    }

    public string GetName(int id, int nameIndex)
    {
        if (nameIndex == NameData[id].Length)
        {
            return null;
        }
        else
        {
            return NameData[id][nameIndex];
        }
    }
}
