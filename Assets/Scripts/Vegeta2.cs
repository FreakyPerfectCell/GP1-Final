using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vegeta2 : MonoBehaviour
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

            if (clickCount == 8)
            {
                animator.Play("vegetaBlock");
            }
            else if (clickCount == 9)
            {
                animator.Play("vegetaIdle");
            }
        }
    }
}