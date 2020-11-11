using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public int maxhp;//최대 체력 변수
    public int curhp;//현재 체력 변수
    public float Def;//방어력 변수
    public int maxstemana;//최대스테마나(플레이어가 방어 했을때 일저량 감소)
    public int curstemana;//현재 스테마나
    public int attackpower;//공격력 변수
    public float speed;//속도변수
    

    public int GiveDangme(Stats peer)
    {
        return peer.curhp-attackpower;  
    }
    
}
