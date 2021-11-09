using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
    [SerializeField] private GameObject wood_A;


    public void AddWood()
    {
        Debug.Log("AddWood is called");
        wood_A.transform.position = new Vector3(0, 0, 0);
    }

    public void RemoveWood()
    {
        Debug.Log("RemoveWood is called");
        wood_A.transform.position = new Vector3(0, 0, 2);
    }
}
