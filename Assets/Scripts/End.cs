using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;

    void Start()
    {
        audioSource.clip = audioClip;

        audioSource.Play();
    }

    void Update()
    {
        if (!audioSource.isPlaying)
        {
            Debug.Log("Audio has finished playing. Ending the game...");
            EndGame();
        }
    }

    void EndGame()
    {
        Application.Quit();
    }
}