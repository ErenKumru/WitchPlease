using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] private GameObject smallFire;
    [SerializeField] private GameObject bigFire;

    private FireState fireState = FireState.Unlit;

    public void Light()
    {
        Debug.Log("Light is called");
        smallFire.SetActive(true);
        bigFire.SetActive(false);
        fireState = FireState.Light;      //undo: call Extinguish
    }

    public void Extinguish()
    {
        Debug.Log("Extinguish is called");
        if (bigFire.activeSelf)
        {
            smallFire.SetActive(true);
            bigFire.SetActive(false);
            fireState = FireState.Small;    //undo: call FeedFire
        }
        else if (smallFire.activeSelf)
        {
            smallFire.SetActive(false);
            fireState = FireState.Unlit;   //undo: call Light
        }
        else fireState = FireState.Unlit;   //undo: call Extinguish 
    }

    public void FeedFire()
    {
        //implement adding wood or something maybe
        Debug.Log("FeedFire is called");
        if (smallFire.activeSelf)
        {
            bigFire.SetActive(true);
            smallFire.SetActive(false);
            fireState = FireState.Big;  //undo: call Extinguish
        }
        else if (bigFire.activeSelf) fireState = FireState.Big;    //undo: call FeedFire
        else fireState = FireState.Unlit;      //undo: call FeedFire
    }

    public FireState GetFireState()
    {
        return fireState;
    }

    public enum FireState
    {
        Unlit,
        Light,
        Small,
        Big
    }
}
