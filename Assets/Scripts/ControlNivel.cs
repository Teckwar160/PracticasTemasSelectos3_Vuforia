using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlNivel : MonoBehaviour
{

    private Vector3[] posiciones = {new Vector3(0.024f,0.138f,0.961f), new Vector3(1f,1f,1f)};
    private int nivelActual = 0;

    public void decrementaNivelActual(){
        if(nivelActual > 0 ){
            nivelActual--;
            transform.position = posiciones[nivelActual];
        }
    }

    public void incrementaNivelActual(){
        if(nivelActual < 3){
            nivelActual++;
        }
    }

    public int getNivelActual(){
        return nivelActual;
    }

    public void OnTriggerEnter(Collider collider){
        if(collider.gameObject.name == "Pelota"){
            incrementaNivelActual();
            Destroy(collider.gameObject);
            transform.position = posiciones[nivelActual];
        }
    }

    void Start(){
        transform.position = posiciones[0];
    }

    void Update(){
        Debug.Log("Estamos en el nivel"+nivelActual);  
    }

}

