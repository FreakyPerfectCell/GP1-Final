using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpeechBox6 : MonoBehaviour
{
    public Image targetImage;
    public Sprite[] imageSequence;
    public int maxChanges;
    public string sceneToLoad = "InTheDungeon";

    private int changeCount = 0;
    private int currentImageIndex = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (changeCount < maxChanges && imageSequence.Length > 0)
            {
                ChangeImage();
            }

            if (changeCount == 4)
            {
                LoadNextScene();
            }
        }
    }

    void ChangeImage()
    {
        currentImageIndex = (currentImageIndex + 1) % imageSequence.Length;
        targetImage.sprite = imageSequence[currentImageIndex];
        changeCount++;
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}