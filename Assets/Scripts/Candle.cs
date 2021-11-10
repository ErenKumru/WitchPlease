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

    public void changeColor(){
        
        if (candles1.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("blue_flame")){
            
            candles1.GetComponent<Animator>().SetBool("undo_1",false);
            candles2.GetComponent<Animator>().SetBool("undo_1",false);
            candles3.GetComponent<Animator>().SetBool("undo_1",false);
            candles4.GetComponent<Animator>().SetBool("undo_1",false);
            candles5.GetComponent<Animator>().SetBool("undo_1",false);

            /////////////7///777/7/
            candles1.GetComponent<Animator>().SetBool("execute_1",true);
            candles2.GetComponent<Animator>().SetBool("execute_1",true);
            candles3.GetComponent<Animator>().SetBool("execute_1",true);
            candles4.GetComponent<Animator>().SetBool("execute_1",true);
            candles5.GetComponent<Animator>().SetBool("execute_1",true);

          
        }
        else if (candles1.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("green_flame")){

            candles1.GetComponent<Animator>().SetBool("undo_2",false);
            candles2.GetComponent<Animator>().SetBool("undo_2",false);
            candles3.GetComponent<Animator>().SetBool("undo_2",false);
            candles4.GetComponent<Animator>().SetBool("undo_2",false);
            candles5.GetComponent<Animator>().SetBool("undo_2",false);

            /////////////7///777/7/
            candles1.GetComponent<Animator>().SetBool("execute_2",true);
            candles2.GetComponent<Animator>().SetBool("execute_2",true);
            candles3.GetComponent<Animator>().SetBool("execute_2",true);
            candles4.GetComponent<Animator>().SetBool("execute_2",true);
            candles5.GetComponent<Animator>().SetBool("execute_2",true);
        
        }
        //candles4.GetComponent<Animator>().SetBool("execute",false);
    }

    public void undoChangeColor(){

        Debug.Log(candles1.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("green_flame"));

        if (candles1.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("red_flame")){
           

              /////////////7///777/7/
            candles1.GetComponent<Animator>().SetBool("undo_1",true);
            candles2.GetComponent<Animator>().SetBool("undo_1",true);
            candles3.GetComponent<Animator>().SetBool("undo_1",true);
            candles4.GetComponent<Animator>().SetBool("undo_1",true);
            candles5.GetComponent<Animator>().SetBool("undo_1",true);
          
        }
        else if (candles1.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("green_flame")){
           

            /////////////7///777/7/
            candles1.GetComponent<Animator>().SetBool("undo_2",true);
            candles2.GetComponent<Animator>().SetBool("undo_2",true);
            candles3.GetComponent<Animator>().SetBool("undo_2",true);
            candles4.GetComponent<Animator>().SetBool("undo_2",true);
            candles5.GetComponent<Animator>().SetBool("undo_2",true);
        
        }

    }

}