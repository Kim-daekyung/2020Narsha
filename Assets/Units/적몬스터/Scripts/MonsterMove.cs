using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    private void AttackPlayer()
    {
        transform.GetChild(1).gameObject.GetComponent<EmAttack>().AttackPlayer();
    }
}