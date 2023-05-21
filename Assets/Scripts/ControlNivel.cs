using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlNivel : MonoBehaviour
{
    private int nivelActual = 1;
    public GameObject Nivel1;
    public GameObject Nivel2;
    public GameObject Nivel3;

    public void decrementaNivelActual(){
        if(nivelActual > 1 ){
            nivelActual--;
        }
    }

    public void incrementaNivelActual(){
        if(nivelActual < 4){
            nivelActual++;
        }
    }

    public int getNivelActual(){
        return nivelActual;
    }

    public void visualizaNivel(){
        if(nivelActual == 1){
            Nivel1.SetActive(true);
            Nivel2.SetActive(false);
            Nivel3.SetActive(false);

        }else if(nivelActual == 2){
            Nivel1.SetActive(false);
            Nivel2.SetActive(true);
            Nivel3.SetActive(false);

        }else{

            Nivel1.SetActive(false);
            Nivel2.SetActive(false);
            Nivel3.SetActive(true);
        }
    }

    void Start(){
        visualizaNivel();
    }
}

