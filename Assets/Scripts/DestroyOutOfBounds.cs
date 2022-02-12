using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float topBoundary = 30;
    private float lowerBoundary = -10;
    private float rightBoundary = 25;
    private float leftBoundary = -25;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Destroy objects out of players view
        if (transform.position.z > topBoundary)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBoundary || transform.position.x > rightBoundary || transform.position.x < leftBoundary) 
        {
            GameManager.Instance.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
