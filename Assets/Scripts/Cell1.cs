using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell1 : MonoBehaviour
{
    public Animator animator;
    private int clickCount = 0;

    void Start()
    {
        animator.Play("Cell");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickCount++;

            if (clickCount == 8)
            {
                animator.Play("cellWaveBeam");
            }
            else if (clickCount == 9)
            {
                animator.Play("Cell");
            }
        }
    }
}