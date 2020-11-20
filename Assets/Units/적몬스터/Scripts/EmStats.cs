using UnityEngine;

public class EmStats :Stats
{
    public bool isDead = false;
    private Animator animator;
    public PlayerAttack pattack = null;

    public void Awake()
    {
        maxhp = 100;//최대 체력 변수
        curhp = 100;//현재 체력 변수
        Def = 100;//방어력 변수
        maxstemana = 0;//최대스테마나(플레이어가 방어 했을때 일저량 감소)
        curstemana = 0;//현재 스테마나
        attackpower = 10;//공격력 변수
    }
    private void Start()
    {
        pattack = GameObject.FindWithTag("Player").GetComponent<PlayerAttack>();
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (curhp <= 0 || (Input.GetKeyDown(KeyCode.I)&& Input.GetKeyDown(KeyCode.Y)&& Input.GetKeyDown(KeyCode.E)))
        {

            isDead = true;

            animator.SetBool("isDead", true);


        }
    }
}