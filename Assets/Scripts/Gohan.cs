using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gohan : MonoBehaviour
{
    public Animator animator;
    private int clickCount = 0;

    void Start()
    {
        animator.Play("gohanIdle");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickCount++;

            if (clickCount == 2)
            {
                animator.Play("gohanSSJ");
            }
            else if (clickCount == 6)
            {
                animator.Play("gohanIdle");
            }
        }
    }
}