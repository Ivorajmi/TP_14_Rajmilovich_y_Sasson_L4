using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI textScore;
    public TextMeshProUGUI textTimer;
    public GameObject panelWin;
    public GameObject panelGameOver;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int score)
    {
        textScore.text = "Score: " + score;
    }

    public void UpdateTimer(float timer)
    {
        textTimer.text = "00:" + Mathf.CeilToInt(timer).ToString("00");
    }
    public void MostrarPantallaWin()
    {
        panelWin.SetActive(true);
    }

    public void MostrarPantallaGameOver()
    {
        panelGameOver.SetActive(true);
    }
}
