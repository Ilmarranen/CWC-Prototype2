using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    AnimalHunger animalHunger;

    // Start is called before the first frame update
    void Start()
    {
        animalHunger = GetComponent<AnimalHunger>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Change score and lives values and destroy objects if needed
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Player"))
        {
            GameManager.Instance.AddLives(-1);
        }
        else if (gameObject.CompareTag("Animal"))
        {
            animalHunger.FeedAnimal(1);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
