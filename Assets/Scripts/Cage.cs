using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cage : MonoBehaviour
{
   [SerializeField] private GameObject cage;
    private Vector3 cagePosition;

    public void OpenCage()
    {
        Debug.Log("cage is called");
        cagePosition = cage.transform.localPosition;
        cage.transform.localPosition = new Vector3(-0.56f, 1.19f, 0.23f);
        Debug.Log(cage.transform.position);
    }

    public void CloseCage()
    {
    
        cage.transform.localPosition = cagePosition;
    }
}
