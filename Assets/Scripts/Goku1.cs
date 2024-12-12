using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goku1 : MonoBehaviour
{
    public Animator animator;
    public float moveSpeed = 5f;
    private Vector2 targetPosition = new Vector2(-12f, -2.5f);
    private int clickCount = 0;
    private bool reachedTarget = false;

    void Start()
    {
        transform.position = new Vector3(-12f, -2.5f, 0f);
        animator.Play("gokuFly");
    }

    void Update()
    {
        if (!reachedTarget)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            if (Vector2.Distance(transform.position, targetPosition) <= 0.1f)
            {
                if (targetPosition == new Vector2(-3f, -2.5f))
                {
                    animator.Play("gokuStop");
                }
                reachedTarget = true;
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            clickCount++;

            if (clickCount == 1 && targetPosition == new Vector2(-12f, -2.5f))
            {
                targetPosition = new Vector2(-3f, -2.5f);
                reachedTarget = false;
            }
            else if (clickCount == 3)
            {
                animator.Play("gokuSorry");
            }
            else if (clickCount == 4)
            {
                animator.Play("gokuIdle");
            }
        }
    }
}