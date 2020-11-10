using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    private PlayerStats player_stat = null;
    public GameObject palyer = null;

    private void Awake()
    {
        palyer = GameObject.Find("플레이어");
        player_stat = GameObject.Find("플레이어").GetComponent<PlayerStats>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
<<<<<<< HEAD
        Debug.Log("충될 시작 " + collision.ToString());
=======
>>>>>>> parent of 7fc9e1a... 적 몬스터 공격 추가
        player_stat.curhp -= 10;
    }

    private void OnTriggerStay(Collider collision)
    {
<<<<<<< HEAD
        Debug.Log("충돌 중 " + collision.ToString());
=======
>>>>>>> parent of 7fc9e1a... 적 몬스터 공격 추가
    }
}