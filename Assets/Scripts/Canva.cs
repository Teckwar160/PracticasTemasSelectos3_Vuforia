using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Canva : MonoBehaviour
{
    public TMP_Text tiempoTexto;
    public TMP_Text intentosTexto;
    public TMP_Text estadoTexto;
    public TMP_Text nivelTexto;
    private float tiempo;
    private string intentos;
    private int nivel;
    public ControlJuego control;
    public ControlNivel controlN;

    public float getTiempo(){
        return tiempo;
    }

    void Update()
    {
        if(!control.getGameOver()){
            tiempo = Time.time;
            intentos = control.getIntentos().ToString();
            nivel = controlN.getNivelActual();
            if(nivel > 3){
                nivel = 3;
            }
        }

        tiempoTexto.text = "Tiempo: " + tiempo.ToString() + " [s]";
        intentosTexto.text = "Intentos: " + intentos;
        estadoTexto.text = control.getEstado();
        nivelTexto.text = "Nivel: " + nivel.ToString();
    }
}
