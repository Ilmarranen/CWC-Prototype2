using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float spawnPause = 2.0f, lastSpawnTime;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (Time.realtimeSinceStartup - lastSpawnTime) > spawnPause)
        {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                lastSpawnTime = Time.realtimeSinceStartup;
        }
    }
}
