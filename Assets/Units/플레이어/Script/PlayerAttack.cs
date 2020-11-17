using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private EmStats em_stat = null;
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
    }
}