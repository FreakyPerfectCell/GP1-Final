using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GohanBlast : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        animator.Play("gohanBlast");
    }
}
