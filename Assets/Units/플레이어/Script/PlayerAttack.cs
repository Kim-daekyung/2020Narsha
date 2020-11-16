using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private EmStats em_stat = null;
    public GameObject emgo = null;
    public MonsterMove Monster = null;
    public EmAttack Monem = null;
    public int attack = 0;

    // Start is called before the first frame update
    void Start()
    {
      emgo = GameObject.FindWithTag("Enermy");
        Monster = emgo.GetComponent<MonsterMove>();
        Monem = emgo.GetComponent<EmAttack>();
        em_stat = GameObject.FindWithTag("Enermy").GetComponent<EmStats>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ccc = collision;
    }
    private void AttackEnermy()
    {
        
       
        
         
            Debug.Log("공격");
            attack = 1;
        
    }
    private Collider2D ccc;

   

    // Update is called once per frame
    void Update()
    {
        
    }
}
