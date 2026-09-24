using UnityEngine;

public class Stage0 : MonoBehaviour
{

    public Transform player;
    public Transform circle;
    public Transform target;
    public Transform target1;
    public float length;
    void Update()
    {
        if (player.position.y == target.position.y)
        {
            player.position += new Vector3(player.position.x + 10f, 10f, 0f);
        }
        if (circle.position.y == target1.position.y)
        {
            circle.position += new Vector3(circle.position.x * 0f, 10f, 0f);
        }
    }
}