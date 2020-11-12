using UnityEngine;

public class EmStats : MonoBehaviour
{
    public int maxhp = 100;//최대 체력 변수
    public int curhp = 100;//현재 체력 변수
    public float Def = 100;//방어력 변수
    public int maxstemana = 0;//최대스테마나(플레이어가 방어 했을때 일저량 감소)
    public int curstemana = 0;//현재 스테마나
    public int attackpower = 10;//공격력 변수
    private bool isDead = false;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (curhp <= 0)
        {
            isDead = true;

            animator.SetBool("isDead", true);
        }
    }
}