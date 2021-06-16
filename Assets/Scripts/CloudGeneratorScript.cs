using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudGeneratorScript : MonoBehaviour
{
    [SerializeField] GameObject cloud;
    [SerializeField] GameObject endPoint;
    float[] spawnInterval = { 8f, 11f, 13f, 15f };
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        var rand = spawnInterval[Random.Range(0, spawnInterval.Length)];
        Invoke("AttemptSpawn", rand);
    }

    void SpawnCloud()
    {
        GameObject clouds = Instantiate(cloud);
        clouds.transform.position = startPos;
        float speed = Random.Range(0.4f, 0.7f);
        clouds.GetComponent<CloudScript>().StartFloating(speed, endPoint.transform.position.y);
    }

    void AttemptSpawn()
    {
        SpawnCloud();
        var rand = spawnInterval[Random.Range(0, spawnInterval.Length)];
        Invoke("AttemptSpawn", rand);
    }
}
