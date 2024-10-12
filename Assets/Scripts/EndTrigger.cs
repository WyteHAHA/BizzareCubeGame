using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;
    public PlayerMovement canmove;

    void OnTriggerEnter ()
    {
        if (canmove.enabled == true)
        {
            gameManager.CompleteLevel();
            Debug.Log("Level Complete!");
        }
        else
        {
            Debug.LogWarning(canmove.enabled);
        }
    }
}
