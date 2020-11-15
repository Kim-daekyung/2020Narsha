using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private EmStats em_stat = null;
    public GameObject emgo = null;
    public MonsterMove Monster = null;

    // Start is called before the first frame update
    void Start()
    {
      emgo = GameObject.FindWithTag("Enermy");
        Monster = emgo.GetComponent<MonsterMove>();
        em_stat = GameObject.FindWithTag("Enermy").GetComponent<EmStats>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("공격");
        if (collision.gameObject.tag == "Enermy")
        {
            em_stat.curhp = -10;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
