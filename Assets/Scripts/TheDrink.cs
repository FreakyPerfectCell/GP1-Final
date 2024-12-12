using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheDrink : MonoBehaviour
{
    public Animator animator;
    private int clickCount = 0;

    void Start()
    {
        animator.Play("trunksIdle");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickCount++;

            if (clickCount == 8)
            {
                animator.Play("Trunks");
            }
        }
    }
}