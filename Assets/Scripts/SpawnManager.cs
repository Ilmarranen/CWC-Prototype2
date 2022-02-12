using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20, spawnPosZ = 15, spawnRangeZ = 14, spawnPosX = 20, startDelay = 2, spawnInterval = 4;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Spawn random animal from array on random position
    void SpawnRandomAnimal()
    {
        int animalIndex;
        Vector3 spawnPos;

        //Spawn up
        animalIndex = Random.Range(0, animalPrefabs.Length);
        spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

        //Spawn right
        animalIndex = Random.Range(0, animalPrefabs.Length);
        spawnPos = new Vector3(spawnPosX, 0, Random.Range(spawnPosZ - spawnRangeZ, spawnPosZ));
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, -90, 0));

        //Spawn left
        animalIndex = Random.Range(0, animalPrefabs.Length);
        spawnPos = new Vector3(-spawnPosX, 0, Random.Range(spawnPosZ - spawnRangeZ, spawnPosZ));
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, 90, 0));

    }



}
