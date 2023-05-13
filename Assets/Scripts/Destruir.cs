using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision){
        if(collision.collider.name == "Destruir"){
            Destroy(this.gameObject);
        }
    }
}
