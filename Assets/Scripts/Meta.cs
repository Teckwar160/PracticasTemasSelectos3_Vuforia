using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour
{
    public ControlNivel control;

    public void OnTriggerEnter(Collider collider){
        if(collider.gameObject.name == "Pelota"){
            control.incrementaNivelActual();
            control.visualizaNivel();
            Destroy(collider.gameObject);
        }
    }
}
