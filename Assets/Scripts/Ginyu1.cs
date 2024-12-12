using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ginyu1 : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        animator.Play("ginyuIdle");
    }

    void OnMouseDown()
    {
        SceneManager.LoadScene("Ginyu");
    }
}
