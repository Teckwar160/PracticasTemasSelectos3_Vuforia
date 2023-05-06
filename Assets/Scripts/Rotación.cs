using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotación : MonoBehaviour
{
    private bool flag = false;

    private void OnMouseDown(){
        flag = !flag;
    }

    void Update()
    {
        if(flag){
            transform.Rotate(new Vector3(0f, 50f, 0f) * Time.deltaTime);
        }        
    }
}
