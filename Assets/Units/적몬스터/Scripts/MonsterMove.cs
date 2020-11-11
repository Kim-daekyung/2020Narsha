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
        if (collision.gameObject.tag == "Player")
        {
            player_stat.curhp -= 10;
        }
    }
}