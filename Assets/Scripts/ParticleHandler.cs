using UnityEngine;

public class ParticleHandler : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public GameObject ps;
    float pos;
    string strpos;

    void Update()
    {
        pos = player.position.y;
        strpos = pos.ToString("0");
        if (strpos != "1") {
            ps.SetActive(false);
        }
        else {
            ps.SetActive(true);
        }
        transform.position = player.position + offset;
    }
}
