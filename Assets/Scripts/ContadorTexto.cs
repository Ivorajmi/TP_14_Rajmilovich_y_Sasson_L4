using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContadorTexto : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static ContadorTexto instancia;
    public TextMeshProUGUI textoUI;
    int contador = 0;

    void Awake()
    {
        instancia = this;
    }

    public void Recolectar()
    {
        contador++;
        textoUI.text = "Objetos recolectados: " + contador;
        
    }
}
