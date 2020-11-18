using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private EmStats em_stat = null;
    private Animator animator = null;

    public GameObject emgo = null;
    public MonsterMove Monster = null;
    public EmAttack Monem = null;
    public int attack = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enermy")
        {
            emgo = collision.gameObject;
            Monster = emgo.GetComponent<MonsterMove>();
            em_stat = emgo.GetComponent<EmStats>();
            animator = emgo.GetComponent<Animator>();
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

    [System.Obsolete]
    public void AttackEnermy()
    {
        if (emgo != null)
        {
            em_stat.curhp -= 10;
            animator.Play("monster_dam");
        }
    }

    public void AttackEnermy2()
    {
        if (emgo != null)
        {
            em_stat.curhp -= 20;
            animator.Play("monster_dam");
        }
    }

    public void PullAttackEnermy()
    {
        if (emgo != null)
        {
            em_stat.curhp -= 30;
            animator.Play("monster_dam");
        }
    }
}