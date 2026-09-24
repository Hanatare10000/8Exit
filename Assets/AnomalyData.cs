/*using UnityEngine;
using UnityEngine.UIElements;
public class AnomalyData : MonoBehaviour
{
    public Transform obj;
    public Transform stage;
    public Transform player;
    public Transform camera;
    public Transform mirror;
    public Transform mirror1;
    public float length = 5;
    void Start()
    {
        if (camera.position == stage.position)
        {
            if (Random.value < 1f)
            {
                obj.position = stage.position;
                if (obj.position == camera.position)
                {
                    if (player.position.x - stage.position.x > length)

                    {
                        player.position += mirror.position;
                        camera.position += mirror1.position;
                    }
                    if (-(player.position.x - stage.position.x) > length)
                    {
                        player.position += new Vector3(player.position.x + 10f, 10f, 0f);
                        camera.position += new Vector3(camera.position.x * 0f, 10f, 0f);
                    }
                }
            }
            else
            {
                if (player.position.x - stage.position.x > length)
                {
                    player.position += new Vector3(player.position.x + -10f, 10f, 0f);
                    camera.position += new Vector3(camera.position.x * 0f, 10f, 0f);
                }
                if (-(player.position.x - stage.position.x) > length)
                {
                    player.position += mirror.position;
                    camera.position += mirror1.position;
                }
            }
        }
    }
}*/