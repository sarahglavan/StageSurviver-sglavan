using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;


public class RandomGenerator : MonoBehaviour {

    public Text textname;

    void Start () {
        System.Random rnd = new System.Random(123);
        Debug.Log(rnd.Next(1, 5));
        Debug.Log(rnd.Next(1, 5));
        Debug.Log(rnd.Next(1, 5));

        Debug.Log(UnityEngine.Random.Range(1, 5));
        //Call
        RandomValue();
        RandomValueint();
        Debug.Log(RandomValueint(123));
        RandomValueint(123);
        textname.text = "hallo";

    }

    //Deklaration
    public void RandomValue()
    {
        System.Random rnd = new System.Random(123);
        Debug.Log(rnd.Next(1, 5));
    }

    public int RandomValueint()
    {
        System.Random rnd = new System.Random(123);
        return rnd.Next(1,5);
    }
   
    public int RandomValueint(int seed)
    {
        System.Random rnd = new System.Random(seed);
        return rnd.Next(1, 5);
    }



}

// Testskript für RandomGenereation von int
// public Datentyp Methodenname (Parameterliste, kann leer sein){}
//