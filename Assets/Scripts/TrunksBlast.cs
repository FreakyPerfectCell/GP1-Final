using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrunksBlast : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        animator.Play("trunksBlast");
    }
}
