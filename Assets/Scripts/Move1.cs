using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1 : MonoBehaviour
{
    public float speed;
    public Vector2 startPosition = new Vector2();
    public float targetY;

    void Start()
    {
        transform.position = startPosition;
    }

    void Update()
    {
        if (transform.position.y > targetY)
        {
            transform.position = new Vector2(
                transform.position.x,
                Mathf.MoveTowards(transform.position.y, targetY, speed * Time.deltaTime)
            );
        }
    }
}
