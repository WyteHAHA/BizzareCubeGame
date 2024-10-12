using UnityEngine;
using UnityEngine.SceneManagement;

public class skiptutorial : MonoBehaviour
{
    // Start is called before the first frame update
    public void SkipTutorial()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
}
