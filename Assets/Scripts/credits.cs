using UnityEngine;
using UnityEngine.SceneManagement;

public class credits : MonoBehaviour
{
    public void Quit ()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    public void Restart ()
    {
        SceneManager.LoadScene(1);
    }
}
