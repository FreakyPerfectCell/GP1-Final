using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LowTaper : MonoBehaviour
{
    public AudioSource audioSource;
    public string nextSceneName;

    void Start()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }

        if (audioSource != null)
        {
            audioSource.Play();
        }
    }

    void Update()
    {
        if (audioSource != null && !audioSource.isPlaying)
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}