using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Force : MonoBehaviour
{
    public static int Members = 0;
    public AudioClip destroySound;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Members++;

            if (destroySound != null)
            {
                AudioSource.PlayClipAtPoint(destroySound, transform.position);
            }

            Destroy(gameObject);

            if (Members >= 4)
            {
                SceneManager.LoadScene("Escape");
            }
        }
    }
}