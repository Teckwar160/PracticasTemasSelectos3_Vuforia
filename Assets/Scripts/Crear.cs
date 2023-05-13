using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crear : MonoBehaviour
{
    public GameObject prefab;
    public GameObject spawn;

    void Update(){
        if (GameObject.Find("Pelota") == null){
            GameObject pelota = Instantiate(prefab, spawn.transform);
            pelota.name = "Pelota";
            pelota.transform.localPosition = Vector3.zero;
            pelota.transform.localRotation = Quaternion.identity;
        }
    }
}
