using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public float speed;
    private Vector3 vector;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool press_left = Input.GetKey(KeyCode.LeftArrow);
        bool press_right = Input.GetKey(KeyCode.RightArrow);
        if (press_left || press_right)
        {
            animator.SetBool("Running", true);
            
            if (press_right)
            {
                animator.SetBool("GoRight", true);
                if (animator.GetCurrentAnimatorStateInfo(0).IsName("player_run_right")) transform.Translate(+speed, 0, 0);
            }
            if (press_left)
            {
                animator.SetBool("GoRight", false);
                if (animator.GetCurrentAnimatorStateInfo(0).IsName("player_run_left")) transform.Translate(-speed, 0, 0);
            }
        }
        else animator.SetBool("Running", false);
    }
}
