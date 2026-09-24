using UnityEngine;

public class Upmodoki : MonoBehaviour
{

    public Transform player;
    public Transform camera;
    public float length = 5;
    void Update()
    {
        {
            if (player.position.x - transform.position.x > length)
            {
                player.position += new Vector3(player.position.x + -10f, 10f, 0f);
                camera.position += new Vector3(camera.position.x * 0f, 10f, 0f);
            }
            if (-(player.position.x - transform.position.x) > length)
            {
                player.position += new Vector3(player.position.x + 20f, -10f, 0f);
                camera.position += new Vector3(camera.position.x * 0f, -10f, 0f);
            }
        }
    }
}