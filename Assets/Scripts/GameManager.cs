using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instancia;
    public UIManager uiManager;

    float timer = 60f;

    void Awake()
    {
        instancia = this;
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
        }
    }
}
