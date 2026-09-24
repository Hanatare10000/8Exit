using System.Data;
using UnityEngine;

public class Up : MonoBehaviour
{

    public Transform player;
    public Transform camera;
    public Transform stage;
    public Transform element;
    public Transform element1;
    /*public Transform stage1;
    public Transform stage2;
    public Transform stage3;
    public Transform stage4;
    public Transform stage5;
    public Transform stage6;
    public Transform stage7;
    public Transform stage8;*/
    public float length = 5;
    void Update()
    {
        if (stage.position == camera.position)
        {
            if (player.position.x - transform.position.x > length)
            {
                player.position += new Vector3(player.position.x + -10f, 10f, 0f);
                camera.position += new Vector3(camera.position.x * 0f, 10f, 0f);
            }
            if (-(player.position.x - transform.position.x) > length)
            {
                player.position = element.position;
                camera.position = element1.position;
            }
        }
        /*if (stage1.position.y == camera.position.y)
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
        }*/
        /*if (stage2.position.x == camera.position.x)
        {
            if (player.position.x - transform.position.x > length)
            {
                player.position += new Vector3(player.position.x + -10f, 10f, 0f);
                camera.position += new Vector3(camera.position.x * 0f, 10f, 0f);
            }
            if (-(player.position.x - transform.position.x) > length)
            {
                player.position += new Vector3(player.position.x + 10f, -10f, 0f);
                camera.position += new Vector3(camera.position.x * 0f, -10f, 0f);
            }
        }
        if (stage3.position.x == camera.position.x)
        {
            if (player.position.x - transform.position.x > length)
            {
                player.position += new Vector3(player.position.x + -10f, 10f, 0f);
                camera.position += new Vector3(camera.position.x * 0f, 10f, 0f);
            }
            if (-(player.position.x - transform.position.x) > length)
            {
                player.position += new Vector3(player.position.x + 10f, -10f, 0f);
                camera.position += new Vector3(camera.position.x * 0f, -10f, 0f);
            }
        }
        if (stage4.position.x == camera.position.x)
        {
            if (player.position.x - transform.position.x > length)
            {
                player.position += new Vector3(player.position.x + -10f, 10f, 0f);
                camera.position += new Vector3(camera.position.x * 0f, 10f, 0f);
            }
            if (-(player.position.x - transform.position.x) > length)
            {
                player.position += new Vector3(player.position.x + 10f, -10f, 0f);
                camera.position += new Vector3(camera.position.x * 0f, -10f, 0f);
            }
        }
        if (stage5.position.x == camera.position.x)
        {
            if (player.position.x - transform.position.x > length)
            {
                player.position += new Vector3(player.position.x + -10f, 10f, 0f);
                camera.position += new Vector3(camera.position.x * 0f, 10f, 0f);
            }
            if (-(player.position.x - transform.position.x) > length)
            {
                player.position += new Vector3(player.position.x + 10f, -10f, 0f);
                camera.position += new Vector3(camera.position.x * 0f, -10f, 0f);
            }
        }
        if (stage6.position.x == camera.position.x)
        {
            if (player.position.x - transform.position.x > length)
            {
                player.position += new Vector3(player.position.x + -10f, 10f, 0f);
                camera.position += new Vector3(camera.position.x * 0f, 10f, 0f);
            }
            if (-(player.position.x - transform.position.x) > length)
            {
                player.position += new Vector3(player.position.x + 10f, -10f, 0f);
                camera.position += new Vector3(camera.position.x * 0f, -10f, 0f);
            }
        }
        if (stage7.position.x == camera.position.x)
        {
            if (player.position.x - transform.position.x > length)
            {
                player.position += new Vector3(player.position.x + -10f, 10f, 0f);
                camera.position += new Vector3(camera.position.x * 0f, 10f, 0f);
            }
            if (-(player.position.x - transform.position.x) > length)
            {
                player.position += new Vector3(player.position.x + 10f, -10f, 0f);
                camera.position += new Vector3(camera.position.x * 0f, -10f, 0f);
            }
        }
        if (stage8.position.x == camera.position.x)
        {
            if (player.position.x - transform.position.x > length)
            {
                player.position += new Vector3(player.position.x + -10f, 10f, 0f);
                camera.position += new Vector3(camera.position.x * 0f, 10f, 0f);
            }
            if (-(player.position.x - transform.position.x) > length)
            {
                player.position += new Vector3(player.position.x + 10f, -10f, 0f);
                camera.position += new Vector3(camera.position.x * 0f, -10f, 0f);
            }
        }*/
}
}