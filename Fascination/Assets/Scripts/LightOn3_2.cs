using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOn3_2 : MonoBehaviour
{
    public Color altColor = Color.black;
    public Renderer rend;
    public GameObject correspondingLight;

    void Start(){
        correspondingLight = GameObject.Find("Light3_2");
    }

    void OnTriggerEnter (Collider other)
    {
        if(correspondingLight != null){
            rend = correspondingLight.GetComponent<Renderer>();
            rend.material.color = altColor;
        }
    }
}
