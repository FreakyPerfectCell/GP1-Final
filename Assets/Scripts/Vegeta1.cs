using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vegeta1 : MonoBehaviour
{
    public Animator animator;
    private int clickCount = 0;

    void Start()
    {
        animator.Play("vegetaIdle");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickCount++;

            if (clickCount == 2)
            {
                animator.Play("vegetaOnGuard");
            }
            else if (clickCount == 3)
            {
                animator.Play("vegetaIdle");
            }
        }
    }
}