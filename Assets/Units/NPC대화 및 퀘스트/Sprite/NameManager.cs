using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameManager : MonoBehaviour
{
    Dictionary<int, string[]> NameData; //이름 데이터 저장

    void Awake()
    {
        NameData = new Dictionary<int, string[]>();
        GenerateNameData();
    }

    void GenerateNameData()
    {
        NameData.Add(1000, new string[] { "주민" });
        NameData.Add(2000, new string[] { "기사단원" });
        NameData.Add(100, new string[] { "책상" });
    }

    public string GetName(int id, int nameIndex)
    {
        if (nameIndex == NameData[id].Length)
        {
            return null;
        }
        else
        {
            return NameData[id][nameIndex]; //오류
        }
    }
}