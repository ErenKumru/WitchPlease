using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
    [SerializeField] private GameObject wood;
    private Vector3 woodPosition;

    public void AddWood()
    {
        Debug.Log("AddWood is called");
        woodPosition = wood.transform.position;
        wood.transform.position = new Vector3(-0.2f, -0.3f, 0);
        //wood.transform.Rotate(0, 10, 0);
    }

    public void RemoveWood()
    {
        Debug.Log("RemoveWood is called");
        wood.transform.position = woodPosition;
        //wood.transform.Rotate(0, -10, 0);
    }
}
