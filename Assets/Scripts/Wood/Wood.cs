using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
    [SerializeField] private GameObject wood;

    public void AddWood()
    {
        Debug.Log("AddWood is called");
        wood.transform.position = new Vector3(-0.2f, -0.5f, -2.1f);
    }

    public void RemoveWood()
    {
        Debug.Log("RemoveWood is called");
        wood.transform.position = new Vector3(0, 0, 0);
        //wood.transform.Rotate(0, -10, 0);
    }
}
