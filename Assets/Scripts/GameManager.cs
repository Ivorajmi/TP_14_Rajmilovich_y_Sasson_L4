using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instancia;
    public UIManager uiManager;

    float timer = 60f;
    public bool juegoTerminado = false;

    void Awake()
    {
        instancia = this;
        Time.timeScale = 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (timer > 0)
        {
            timer -= Time.deltaTime;
            uiManager.UpdateTimer(timer);
        }
        else
        {
            timer = 0;
            uiManager.UpdateTimer(0);

            if (!juegoTerminado) // 👈 evita que se llame mil veces por frame
            {
                 juegoTerminado = true;
                 uiManager.MostrarPantallaGameOver();
                Time.timeScale = 0;
            }
        }
        if (juegoTerminado && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
