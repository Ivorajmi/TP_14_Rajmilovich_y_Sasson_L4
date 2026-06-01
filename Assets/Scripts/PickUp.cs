using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PickUp : MonoBehaviour
{
   

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    int score = 0;
    UIManager uiManager;

    void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            score++;
            uiManager.UpdateScore(score);
            Destroy(other.gameObject);
        }
    }
}
