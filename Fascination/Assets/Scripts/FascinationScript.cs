using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class FascinationScript : MonoBehaviour
{
    public GameObject light00;
    public Color rend00;
    public GameObject light01;
    public Color rend01;
    public GameObject light02;
    public Color rend02;
    public GameObject light03;
    public Color rend03;
    public GameObject light04;
    public Color rend04;
    public GameObject light10;
    public Color rend10;
    public GameObject light11;
    public Color rend11;
    public GameObject light12;
    public Color rend12;
    public GameObject light13;
    public Color rend13;
    public GameObject light14;
    public Color rend14;
    public GameObject light20;
    public Color rend20;
    public GameObject light21;
    public Color rend21;
    public GameObject light22;
    public Color rend22;
    public GameObject light23;
    public Color rend23;
    public GameObject light24;
    public Color rend24;
    public GameObject light30;
    public Color rend30;
    public GameObject light31;
    public Color rend31;
    public GameObject light32;
    public Color rend32;
    public GameObject light33;
    public Color rend33;
    public GameObject light34;
    public Color rend34;
    public GameObject light40;
    public Color rend40;
    public GameObject light41;
    public Color rend41;
    public GameObject light42;
    public Color rend42;
    public GameObject light43;
    public Color rend43;
    public GameObject light44;
    public Color rend44;
    public Color altColor = Color.black;
    public Color winColor = Color.blue;
    public Stopwatch stopwatch;
    public bool win = true;
    // Start is called before the first frame update
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
    }

    // Update is called once per frame
    void Update()
    {
        rend00 = light00.GetComponent<Renderer>().material.color;
        rend01 = light01.GetComponent<Renderer>().material.color;
        rend02 = light02.GetComponent<Renderer>().material.color;
        rend03 = light03.GetComponent<Renderer>().material.color;
        rend04 = light04.GetComponent<Renderer>().material.color;
        rend10 = light10.GetComponent<Renderer>().material.color;
        rend11 = light11.GetComponent<Renderer>().material.color;
        rend12 = light12.GetComponent<Renderer>().material.color;
        rend13 = light13.GetComponent<Renderer>().material.color;
        rend14 = light14.GetComponent<Renderer>().material.color;
        rend20 = light20.GetComponent<Renderer>().material.color;
        rend21 = light21.GetComponent<Renderer>().material.color;
        rend22 = light22.GetComponent<Renderer>().material.color;
        rend23 = light23.GetComponent<Renderer>().material.color;
        rend24 = light24.GetComponent<Renderer>().material.color;
        rend30 = light30.GetComponent<Renderer>().material.color;
        rend31 = light31.GetComponent<Renderer>().material.color;
        rend32 = light32.GetComponent<Renderer>().material.color;
        rend33 = light33.GetComponent<Renderer>().material.color;
        rend34 = light34.GetComponent<Renderer>().material.color;
        rend40 = light40.GetComponent<Renderer>().material.color;
        rend41 = light41.GetComponent<Renderer>().material.color;
        rend42 = light42.GetComponent<Renderer>().material.color;
        rend43 = light43.GetComponent<Renderer>().material.color;
        rend44 = light44.GetComponent<Renderer>().material.color;
        if((rend00 == altColor && rend01 == altColor && rend02 == altColor && rend03 == altColor && rend04 == altColor) ||
        (rend10 == altColor && rend11 == altColor && rend12 == altColor && rend13 == altColor && rend14 == altColor) ||
        (rend20 == altColor && rend21 == altColor && rend22 == altColor && rend23 == altColor && rend24 == altColor) ||
        (rend30 == altColor && rend31 == altColor && rend32 == altColor && rend33 == altColor && rend34 == altColor) ||
        (rend40 == altColor && rend41 == altColor && rend42 == altColor && rend43 == altColor && rend44 == altColor) ||
        (rend00 == altColor && rend10 == altColor && rend20 == altColor && rend30 == altColor && rend40 == altColor) ||
        (rend01 == altColor && rend11 == altColor && rend21 == altColor && rend31 == altColor && rend41 == altColor) ||
        (rend02 == altColor && rend12 == altColor && rend22 == altColor && rend32 == altColor && rend42 == altColor) ||
        (rend03 == altColor && rend13 == altColor && rend23 == altColor && rend33 == altColor && rend43 == altColor) ||
        (rend04 == altColor && rend14 == altColor && rend24 == altColor && rend34 == altColor && rend44 == altColor) ||
        (rend00 == altColor && rend11 == altColor && rend22 == altColor && rend33 == altColor && rend44 == altColor) ||
        (rend04 == altColor && rend13 == altColor && rend22 == altColor && rend31 == altColor && rend40 == altColor))
        {
            while(win)
            {
                rend00 = winColor;
                rend01 = winColor;
                rend02 = winColor;
                rend03 = winColor;
                rend04 = winColor;
                rend10 = winColor;
                rend11 = winColor;
                rend12 = winColor;
                rend13 = winColor;
                rend14 = winColor;
                rend20 = winColor;
                rend21 = winColor;
                rend22 = winColor;
                rend23 = winColor;
                rend24 = winColor;
                rend30 = winColor;
                rend31 = winColor;
                rend32 = winColor;
                rend33 = winColor;
                rend34 = winColor;
                rend40 = winColor;
                rend41 = winColor;
                rend42 = winColor;
                rend43 = winColor;
                rend44 = winColor;
                stopwatch = Stopwatch.StartNew();
                while(true)
                {
                    if(stopwatch.ElapsedMilliseconds >= 1000)
                    {
                        break;
                    }
                }
                rend00 = altColor;
                rend01 = altColor;
                rend02 = altColor;
                rend03 = altColor;
                rend04 = altColor;
                rend10 = altColor;
                rend11 = altColor;
                rend12 = altColor;
                rend13 = altColor;
                rend14 = altColor;
                rend20 = altColor;
                rend21 = altColor;
                rend22 = altColor;
                rend23 = altColor;
                rend24 = altColor;
                rend30 = altColor;
                rend31 = altColor;
                rend32 = altColor;
                rend33 = altColor;
                rend34 = altColor;
                rend40 = altColor;
                rend41 = altColor;
                rend42 = altColor;
                rend43 = altColor;
                rend44 = altColor;
                stopwatch = Stopwatch.StartNew();
                while(true)
                {
                    if(stopwatch.ElapsedMilliseconds >= 1000)
                    {
                        break;
                    }
                }
            }
        }
    }
}
