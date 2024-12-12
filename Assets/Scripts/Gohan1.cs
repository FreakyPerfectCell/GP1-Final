using UnityEngine;
using UnityEngine.SceneManagement;

public class Gohan1 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("shop") && gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Cells Shop");
        }
    }
}