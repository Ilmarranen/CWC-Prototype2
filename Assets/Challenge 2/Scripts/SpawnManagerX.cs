using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float lastSpawnTime, spawnInterval = 1.0f, spawnIntervalBegin = 3.0f, spawnIntervalEnd = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

        //InvokeRepeating("SpawnRandomBall", startDelay, spawnIntervalBegin);
    }

    // Update is called once per frame
    void Update()
    {
        //After random interval of time spawn new ball and redefine the interval
        if ((Time.realtimeSinceStartup - lastSpawnTime) > spawnInterval)
        {
            SpawnRandomBall();
            lastSpawnTime = Time.realtimeSinceStartup;
            spawnInterval = Random.Range(spawnIntervalBegin, spawnIntervalEnd);
        }

    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }

}
