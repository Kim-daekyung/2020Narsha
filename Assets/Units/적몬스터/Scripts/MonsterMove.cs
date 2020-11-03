using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove :MonoBehaviour 
{
    PlayerStats player_stat =null;
public GameObject palyer = null;
    private void Awake()
    {
palyer  = GameObject.Find("플레이어");
       player_stat = GameObject.Find("플레이어").GetComponent<PlayerStats>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("충될 시작 " + collision.ToString());
        player_stat.curhp -= 10;
    }
    private void OnTriggerStay(Collider collision)
    {
        Debug.Log("충돌 중 " + collision.ToString());
    }

}
