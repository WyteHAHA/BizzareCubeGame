using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    float time = 0f;
    void Update()
    {
        time = time + Time.deltaTime;
        scoreText.text = time.ToString("0");
    }
}
