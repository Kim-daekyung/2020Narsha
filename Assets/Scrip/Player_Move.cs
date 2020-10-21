using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public float speed;
    private Vector3 vector;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("Left", false);
        animator.SetBool("Right", false);
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            vector.Set(Input.GetAxisRaw("Horizontal"), transform.position.y, transform.position.z);
            if (vector.x == 1)
            {
                animator.SetBool("Right", true);
                transform.Translate(vector.x * speed, 0, 0);
                

            }
            else if (vector.x == -1)
            {
                animator.SetBool("Left", true);
                transform.Translate(vector.x * speed, 0, 0);
               

            }

        }
        
    }
}
