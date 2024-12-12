using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ToTheDungeon : MonoBehaviour
{
    public string sceneName;

    public void ChangeScene()
    {
        SceneManager.LoadScene("ToTheDungeon");
    }
}