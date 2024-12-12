using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu: MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip soundEffect;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlaySoundAndChangeScene();
        }
    }

    void PlaySoundAndChangeScene()
    {
        audioSource.PlayOneShot(soundEffect);
        Invoke("ChangeScene", soundEffect.length);
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("Pre Story");
    }
}