using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public float maxYpos;
    public float SpawnTime;
    public GameObject pipe;


    // Use this for initialization
    void Start()
    {
       // StartSpawingPipes();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StopSpawnimgPipes()
    {
        CancelInvoke("SpawnPipe");


    }
    public void StartSpawingPipes()
    {

        InvokeRepeating("SpawnPipe", 0.2f, SpawnTime);


    }

    void SpawnPipe()
    {
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(-maxYpos, maxYpos), 0), Quaternion.identity);

    }

}
        