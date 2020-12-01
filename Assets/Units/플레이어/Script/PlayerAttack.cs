using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private EmStats em_stat = null;
    private Animator animator = null;

    public GameObject emgo = null;
    public EmStats emStats = null;
    public MonsterMove Monster = null;
    public EmAttack Monem = null;
    public int attack = 0;
    public PlayerStats playerstat = null;
    private int Mhp = 300;
     

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enermy")
        {
            emgo = collision.gameObject;
            emStats = emgo.GetComponent<EmStats>();
            Monster = emgo.GetComponent<MonsterMove>();
            em_stat = emgo.GetComponent<EmStats>();
            animator = emgo.GetComponent<Animator>();
            playerstat = GameObject.FindWithTag("Player").GetComponent<PlayerStats>();

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enermy")
        {
            emgo = null;
            Monster = null;
            em_stat = null;
            animator = null;
        }
    }

    private void FallBack()
    {
        float x = 0.0f;
        float y = 0.0f;

        if (emgo != null)
        {
            x = emgo.transform.position.x;
            y = emgo.transform.position.y;

            if (emgo.transform.position.x > transform.position.x)
            {
                emgo.transform.position = new Vector3(x + 20, y, emgo.transform.position.z);
            }
            else
            {
                emgo.transform.position = new Vector3(x - 20, y,emgo.transform.position.z);
            }
        }
    }

    [System.Obsolete]
    public void AttackEnermy()
    {
        if (emStats.isDead)
        {
            return;
        }

        if (emgo != null)
        {
            em_stat.curhp -= 10;
            animator.Play("monster_dam");
                 playerstat.curhp += 1;
            FallBack();
           
        }
    }

    public void AttackEnermy2()
    {
        if (emStats.isDead)
        {
            return;
        }
        if (emgo != null)
        {
            em_stat.curhp -= 20;
            animator.Play("monster_dam");
            playerstat.curhp += 1;
            FallBack();
            
        }
    }

    public void PullAttackEnermy()
    {
        if (emStats.isDead)
        {
            return;
        }

        if (emgo != null)
        {
            em_stat.curhp -= 100;
            
            animator.Play("monster_dam");
            if (playerstat.curhp >= Mhp)
            {
                playerstat.curhp = Mhp;
            }
            else
            playerstat.curhp += 50;
            FallBack();
            
        }
    }
}