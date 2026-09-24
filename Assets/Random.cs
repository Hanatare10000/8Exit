using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;
public class RandomSpawner : MonoBehaviour
{
    public Transform player;
    public Transform camera;
    public Transform obj;
    public Transform obj1;
    public Transform stage;
    public Transform stageA;
    public Transform stagea;
    public Transform element;
    public Transform element1;
    public Transform element2;
    public float length = 5;
    void Start()
    {
        if (camera.position == stage.position)
        {
            int anomalyID = Random.Range(0, 2);
            switch (anomalyID)
            {
                case 0:
                    obj.position = stage.position;
                    if (obj.position == stage.position)
                    {
                        if (player.position.x - stageA.position.x > length)
                        {
                            player.position = element.position;
                            camera.position = element1.position;
                            obj.position = element2.position;
                        }
                        if (-(player.position.x - stageA.position.x) > length)
                        {
                            player.position += new Vector3(player.position.x + 20f, 10f, 0f);
                            camera.position += new Vector3(camera.position.x * 0f, 10f, 0f);
                            obj.position = element2.position;
                        }
                    }
                    break;
                case 1:
                    obj.position = element2.position;
                    if (obj.position == element2.position)
                    {
                        if (player.position.x - stageA.position.x > length)
                        {
                            player.position += new Vector3(player.position.x + -10f, 10f, 0f);
                            camera.position += new Vector3(camera.position.x * 0f, 10f, 0f);
                        }
                        if (-(player.position.x - stageA.position.x) > length)
                        {
                            player.position = element.position;
                            camera.position = element1.position;
                        }
                    }
                    break;
                    /*else (Random.value < 0.2f)
                    {
                        obj1.position = stage.position;
                        if (stage.position == obj1.position)
                        {
                            if (player.position.x - stage.position.x > length)
                            {
                                player.position = element.position;
                                camera.position = element1.position;
                                obj1.position = element2.position;
                            }
                            if (-(player.position.x - stage.position.x) > length)
                            {
                                player.position += new Vector3(player.position.x * -1f, 10f, 0f);
                                camera.position += new Vector3(camera.position.x * 0f, 10f, 0f);
                                obj1.position = element.position;
                            }
                        }
                    }*/
            }
        }
    }
}