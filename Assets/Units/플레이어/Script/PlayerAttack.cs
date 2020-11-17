using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private EmStats em_stat = null;
    private Animator animator = null;
    public GameObject emgo = null;
    public MonsterMove Monster = null;
    public EmAttack Monem = null;
    public int attack = 0;

    // Start is called before the first frame update
    private void Start()
    {
        emgo = GameObject.FindWithTag("Enermy");
        Monster = emgo.GetComponent<MonsterMove>();
        em_stat = emgo.GetComponent<EmStats>();
        animator = emgo.GetComponent<Animator>();
    }

    //    private void OnTriggerStay2D(Collider2D collision)
    //    {
    //        if (collision.gameObject.tag == "Enermy")
    //        {
    //            AttackEnermy();
    //        }
    //    }

    [System.Obsolete]
    public void AttackEnermy()
    {
        em_stat.curhp -= 10;
//        animator.SetTrigger("monster_dam");
        animator.Play("monster_dam");
    }
    public void AttackEnermy2()
    {
        em_stat.curhp -= 20;
        animator.Play("monster_dam");
    }
    public void PullAttackEnermy()
    {
        em_stat.curhp -= 30;
        animator.Play("monster_dam");
    }
}