using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    private PlayerStats player_stat = null;
    public GameObject playergo = null;
    public Player_Move player = null;

    private void Start()
    {
        playergo = GameObject.FindWithTag("Player");
        player = playergo.GetComponent<Player_Move>();
        player_stat = GameObject.FindWithTag("Player").GetComponent<PlayerStats>();
    }

    private void AttackPlayer()
    {
        player_stat.curhp -= 10;
        player.animator.Play("player_damzing");
        Debug.Log("데미지");
        if (player_stat.curhp <= 0)
        {
            player.animator.Play("player_death");
            Debug.Log("DEAD");
        }
    }


}