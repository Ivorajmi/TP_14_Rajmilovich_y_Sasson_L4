using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickUp : MonoBehaviour
{
    int score = 0;
    int puntajeMaximo = 7; 
    UIManager uiManager;

    void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            score++;
            uiManager.UpdateScore(score);
            Destroy(other.gameObject);

            if (score >= puntajeMaximo)
            {
                GameManager.instancia.juegoTerminado = true;
                uiManager.MostrarPantallaWin();
                Time.timeScale = 0;
            }
        }
    }
}