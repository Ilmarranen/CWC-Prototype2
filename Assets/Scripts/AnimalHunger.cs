using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AnimalHunger : MonoBehaviour
{

    public Slider hungerSlider;
    public int amountToBeFed;
    private int currentFedAmount;
    
    // Start is called before the first frame update
    void Start()
    {
        hungerSlider.maxValue = amountToBeFed;
        hungerSlider.value = 0;
        hungerSlider.fillRect.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Increase fed amount and destroy animal if needed
    public void FeedAnimal(int amount)
    {
        currentFedAmount += amount;
        hungerSlider.fillRect.gameObject.SetActive(true);
        hungerSlider.value = currentFedAmount;

        if(currentFedAmount >= amountToBeFed)
        {
            GameManager.Instance.AddScore(amountToBeFed);
            Destroy(gameObject, 0.1f);
        }

    }

}
