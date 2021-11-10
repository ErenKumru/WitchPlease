using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : MonoBehaviour
{
[SerializeField] private GameObject candles1;
[SerializeField] private GameObject candles2;
[SerializeField] private GameObject candles3;
[SerializeField] private GameObject candles4;
[SerializeField] private GameObject candles5;

public void fireOrBlowCandle() //IEnumerator
    {
        //Debug.Log("Candles are not fired");
        if (!candles1.GetComponent<Renderer>().enabled)
        {
            candles1.GetComponent<Renderer>().enabled = true;
            candles2.GetComponent<Renderer>().enabled = true;
            candles3.GetComponent<Renderer>().enabled = true;
            candles4.GetComponent<Renderer>().enabled = true;
            candles5.GetComponent<Renderer>().enabled = true;
            Debug.Log("Candles are fired");
            ; 
            
        }
        else{
            candles1.GetComponent<Renderer>().enabled = false;
            candles2.GetComponent<Renderer>().enabled = false;
            candles3.GetComponent<Renderer>().enabled = false;
            candles4.GetComponent<Renderer>().enabled = false;
            candles5.GetComponent<Renderer>().enabled = false;
            Debug.Log("candles are blown");
        }
    }

}