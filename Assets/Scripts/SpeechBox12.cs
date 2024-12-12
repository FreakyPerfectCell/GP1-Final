using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpeechBox12 : MonoBehaviour
{
    public Image targetImage;
    public Sprite[] imageSequence;
    public int maxChanges;
    public string sceneToLoad = "Ending";

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

            if (changeCount == 3)
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