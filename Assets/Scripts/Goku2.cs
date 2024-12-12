using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goku2 : MonoBehaviour
{
    public Animator animator;
    private int clickCount = 0;

    void Start()
    {
        animator.Play("gokuIdle");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickCount++;

            if (clickCount == 10)
            {
                animator.Play("gokuSSJ");
            }
            else if (clickCount == 11)
            {
                animator.Play("gokuSSJIdle");
            }
        }
    }
}