using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] private GameObject smallFire;
    [SerializeField] private GameObject bigFire;

    public void Light()
    {
        Debug.Log("Light is called");
        if (!smallFire.activeSelf) smallFire.SetActive(true);
        else Debug.Log("Fire is already lit");
    }

    public void Extinguish()
    {
        Debug.Log("Extinguish is called");
        if (bigFire.activeSelf)
        {
            smallFire.SetActive(true);
            bigFire.SetActive(false);
        }
        else if (smallFire.activeSelf) smallFire.SetActive(false);
        else Debug.Log("There is no fire to Extinguish");
    }

    public void FeedFire()
    {
        //implement adding wood or something
        Debug.Log("FeedFire is called");
        if (smallFire.activeSelf)
        {
            bigFire.SetActive(true);
            smallFire.SetActive(false);
        }
        else Debug.Log("You need to first light the fire to feed the fire");

    }
}
