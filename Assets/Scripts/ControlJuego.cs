using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ControlJuego : MonoBehaviour
{
    private string estado = "";
    private bool gameOver = false;
    private int intentos = 0;
    public ControlNivel control;
    public Canva tiempo;
    

    public void incrementaIntentos(){
        intentos++;
    }

    public int getIntentos(){
        return intentos;
    }

    public bool getGameOver(){
        return gameOver;
    }

    public string getEstado(){
        return estado;
    }

    void Update(){
        if(tiempo.getTiempo() > 300){
            estado = "Perdiste";
            gameOver = true;
        } else if(control.getNivelActual() == 4){
            estado = "Ganaste";
            gameOver = true;
        }
    }
}
