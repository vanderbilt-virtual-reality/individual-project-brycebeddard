using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class FascinationScript : MonoBehaviour
{
    public GameObject light00;
    public Renderer rend00;
    public GameObject light01;
    public Renderer rend01;
    public GameObject light02;
    public Renderer rend02;
    public GameObject light03;
    public Renderer rend03;
    public GameObject light04;
    public Renderer rend04;
    public GameObject light10;
    public Renderer rend10;
    public GameObject light11;
    public Renderer rend11;
    public GameObject light12;
    public Renderer rend12;
    public GameObject light13;
    public Renderer rend13;
    public GameObject light14;
    public Renderer rend14;
    public GameObject light20;
    public Renderer rend20;
    public GameObject light21;
    public Renderer rend21;
    public GameObject light22;
    public Renderer rend22;
    public GameObject light23;
    public Renderer rend23;
    public GameObject light24;
    public Renderer rend24;
    public GameObject light30;
    public Renderer rend30;
    public GameObject light31;
    public Renderer rend31;
    public GameObject light32;
    public Renderer rend32;
    public GameObject light33;
    public Renderer rend33;
    public GameObject light34;
    public Renderer rend34;
    public GameObject light40;
    public Renderer rend40;
    public GameObject light41;
    public Renderer rend41;
    public GameObject light42;
    public Renderer rend42;
    public GameObject light43;
    public Renderer rend43;
    public GameObject light44;
    public Renderer rend44;
    public Color altColor = Color.black;
    public Color winColor = Color.black;
    public Stopwatch stopwatch;
    public bool win;
    void winCelebration(){
                        UnityEngine.Debug.Log("ENTERED LOOP");
                        rend00.material.color = winColor;
                                                rend01.material.color = winColor;
                                                rend02.material.color = winColor;
                                                rend03.material.color = winColor;
                                                rend04.material.color = winColor;
                                                rend10.material.color = winColor;
                                                rend11.material.color = winColor;
                                                rend12.material.color = winColor;
                                                rend13.material.color = winColor;
                                                rend14.material.color = winColor;
                                                rend20.material.color = winColor;
                                                rend21.material.color = winColor;
                                                rend22.material.color = winColor;
                                                rend23.material.color = winColor;
                                                rend24.material.color = winColor;
                                                rend30.material.color = winColor;
                                                rend31.material.color = winColor;
                                                rend32.material.color = winColor;
                                                rend33.material.color = winColor;
                                                rend34.material.color = winColor;
                                                rend40.material.color = winColor;
                                                rend41.material.color = winColor;
                                                rend42.material.color = winColor;
                                                rend43.material.color = winColor;
                                                rend44.material.color = winColor;
                    }
     //Start is called before the first frame update
    void Start()
    {
        light00 = GameObject.Find("Light0_0");
        light01 = GameObject.Find("Light0_1");
        light02 = GameObject.Find("Light0_2");
        light03 = GameObject.Find("Light0_3");
        light04 = GameObject.Find("Light0_4");
        light10 = GameObject.Find("Light1_0");
        light11 = GameObject.Find("Light1_1");
        light12 = GameObject.Find("Light1_2");
        light13 = GameObject.Find("Light1_3");
        light14 = GameObject.Find("Light1_4");
        light20 = GameObject.Find("Light2_0");
        light21 = GameObject.Find("Light2_1");
        light22 = GameObject.Find("Light2_2");
        light23 = GameObject.Find("Light2_3");
        light24 = GameObject.Find("Light2_4");
        light30 = GameObject.Find("Light3_0");
        light31 = GameObject.Find("Light3_1");
        light32 = GameObject.Find("Light3_2");
        light33 = GameObject.Find("Light3_3");
        light34 = GameObject.Find("Light3_4");
        light40 = GameObject.Find("Light4_0");
        light41 = GameObject.Find("Light4_1");
        light42 = GameObject.Find("Light4_2");
        light43 = GameObject.Find("Light4_3");
        light44 = GameObject.Find("Light4_4");
        win = false;
    }

    // Update is called once per frame
    void Update()
    {
        rend00 = light00.GetComponent<Renderer>();
        rend01 = light01.GetComponent<Renderer>();
        rend02 = light02.GetComponent<Renderer>();
        rend03 = light03.GetComponent<Renderer>();
        rend04 = light04.GetComponent<Renderer>();
        rend10 = light10.GetComponent<Renderer>();
        rend11 = light11.GetComponent<Renderer>();
        rend12 = light12.GetComponent<Renderer>();
        rend13 = light13.GetComponent<Renderer>();
        rend14 = light14.GetComponent<Renderer>();
        rend20 = light20.GetComponent<Renderer>();
        rend21 = light21.GetComponent<Renderer>();
        rend22 = light22.GetComponent<Renderer>();
        rend23 = light23.GetComponent<Renderer>();
        rend24 = light24.GetComponent<Renderer>();
        rend30 = light30.GetComponent<Renderer>();
        rend31 = light31.GetComponent<Renderer>();
        rend32 = light32.GetComponent<Renderer>();
        rend33 = light33.GetComponent<Renderer>();
        rend34 = light34.GetComponent<Renderer>();
        rend40 = light40.GetComponent<Renderer>();
        rend41 = light41.GetComponent<Renderer>();
        rend42 = light42.GetComponent<Renderer>();
        rend43 = light43.GetComponent<Renderer>();
        rend44 = light44.GetComponent<Renderer>();
        if(!win){

        if((rend00.material.color == altColor && rend01.material.color == altColor && rend02.material.color == altColor && rend03.material.color == altColor && rend04.material.color == altColor) ||
        (rend10.material.color == altColor && rend11.material.color == altColor && rend12.material.color == altColor && rend13.material.color == altColor && rend14.material.color == altColor) ||
        (rend20.material.color == altColor && rend21.material.color == altColor && rend22.material.color == altColor && rend23.material.color == altColor && rend24.material.color == altColor) ||
        (rend30.material.color == altColor && rend31.material.color == altColor && rend32.material.color == altColor && rend33.material.color == altColor && rend34.material.color == altColor) ||
        (rend40.material.color == altColor && rend41.material.color == altColor && rend42.material.color == altColor && rend43.material.color == altColor && rend44.material.color == altColor) ||
        (rend00.material.color == altColor && rend10.material.color == altColor && rend20.material.color == altColor && rend30.material.color == altColor && rend40.material.color == altColor) ||
        (rend01.material.color == altColor && rend11.material.color == altColor && rend21.material.color == altColor && rend31.material.color == altColor && rend41.material.color == altColor) ||
        (rend02.material.color == altColor && rend12.material.color == altColor && rend22.material.color == altColor && rend32.material.color == altColor && rend42.material.color == altColor) ||
        (rend03.material.color == altColor && rend13.material.color == altColor && rend23.material.color == altColor && rend33.material.color == altColor && rend43.material.color == altColor) ||
        (rend04.material.color == altColor && rend14.material.color == altColor && rend24.material.color == altColor && rend34.material.color == altColor && rend44.material.color == altColor) ||
        (rend00.material.color == altColor && rend11.material.color == altColor && rend22.material.color == altColor && rend33.material.color == altColor && rend44.material.color == altColor) ||
        (rend04.material.color == altColor && rend13.material.color == altColor && rend22.material.color == altColor && rend31.material.color == altColor && rend40.material.color == altColor))
        {
		    win = true;
		    UnityEngine.Debug.Log("YAY");
            winCelebration();
        }
        }
    }
}