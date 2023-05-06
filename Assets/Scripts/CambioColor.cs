using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColor : MonoBehaviour
{
    public GameObject cube;
    private int i = 0;
    private Color[] colors = {new Color(0,0,1,1), new Color(1,0,0,1), new Color(0,1,0,1), new Color(0,0,0,1)};

    public void ChangeColor(){
        cube.GetComponent<Renderer>().material.color = colors[i];
        i++;
        if(i > 3){
            i=0;
        }
            
    }
}
