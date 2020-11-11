using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    private PlayerStats player_stat = null;
    public GameObject playergo = null;
    public Player_Move player = null;

    private void Start()
    {
        playergo = GameObject.Find("플레이어");
        player = playergo.GetComponent < Player_Move >();
        player_stat = GameObject.Find("플레이어").GetComponent<PlayerStats>();
    }

    private void AttackPlayer()
    {
       
        if (cc && cc.gameObject.tag == "Player")
        {
            player_stat.curhp -= 10;
            if (player_stat.curhp <= 0)
            {
                player.animator.Play("player_death");
                Debug.Log("DEAD");
            }
        }
    }

    Collider2D cc;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        cc = collision;
    }
}