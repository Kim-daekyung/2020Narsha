using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullEffect : MonoBehaviour
{
    public SpriteRenderer spt = null;
    private Animator animator = null;
    // Start is called before the first frame update
    void Start()
    {
        spt = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ONEffect()
    {
        this.gameObject.SetActive(true);
        animator.Play("effect");
    }
    public void OFFEffect()
    {
        this.gameObject.SetActive(false);
    }
}
