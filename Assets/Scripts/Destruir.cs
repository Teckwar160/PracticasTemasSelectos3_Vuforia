using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    public void OnTriggerEnter(Collider collider){
        if(collider.gameObject.name == "Pelota"){
            Destroy(collider.gameObject);
        }
    }
}
