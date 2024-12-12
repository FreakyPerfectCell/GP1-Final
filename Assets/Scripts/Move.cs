using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 2f;
    public Vector2 startPosition = new Vector2(0.05f, -14f);
    public float targetY = -3f;

    void Start()
    {
        transform.position = startPosition;
    }

    void Update()
    {
        if (transform.position.y < targetY)
        {
            transform.position = new Vector2(
                transform.position.x,
                Mathf.MoveTowards(transform.position.y, targetY, speed * Time.deltaTime)
            );
        }
    }
}
