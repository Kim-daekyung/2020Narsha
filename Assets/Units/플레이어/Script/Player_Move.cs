using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public float speed;
    private Vector3 vector;
    public Animator animator;
    private SpriteRenderer sprite;
    private float cooltime_attack = 0;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cooltime_attack > 0) cooltime_attack -= Time.deltaTime;
        animator.SetBool("isWalk", false);


        if (Input.GetKeyDown(KeyCode.Q) && cooltime_attack <= 0)
        {
            animator.SetBool("Attack", true);
            cooltime_attack = 1;

        }
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            vector.Set(Input.GetAxisRaw("Horizontal"), transform.position.y, transform.position.z);
            if (vector.x == 1)
            {
                animator.SetBool("isWalk", true);
                sprite.flipX = false;
                transform.Translate(vector.x * speed, 0, 0);


            }
            else if (vector.x == -1)
            {
                animator.SetBool("isWalk", true);
                sprite.flipX = true;
                transform.Translate(vector.x * speed, 0, 0);


            }

        }

    }

    
}