using UnityEngine;

public class PlayerAttacked : MonoBehaviour
{
    // Start is called before the first frame update
    public void AttackEnermy()
    {
        transform.GetChild(0).GetComponent<PlayerAttack>().AttackEnermy();
    }

    public void AttackEnermy2()
    {
        transform.GetChild(0).GetComponent<PlayerAttack>().AttackEnermy2();
    }

    public void PullAttackEnermy()
    {
        transform.GetChild(0).GetComponent<PlayerAttack>().PullAttackEnermy();
    }
}