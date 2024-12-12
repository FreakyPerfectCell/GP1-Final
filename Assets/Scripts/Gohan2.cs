using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gohan2 : MonoBehaviour
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

            if (clickCount == 7)
            {
                animator.Play("gohanSSJ");
            }
        }
    }
}