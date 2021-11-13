using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    //Reciever Class
public class Liquid : MonoBehaviour
{
    [SerializeField] private GameObject cauldron; //referancing cauldron is subject to change

    //TODO: Change the dummy operations to real operations
    public void Pour(string methodNameForUI)
    {
        // GetComponent<T>() -> gets the component of the given game object
        Material liquidMaterial = GetComponent<Renderer>().material;
        Material cauldronMaterial = cauldron.GetComponent<Renderer>().material;

        //move + anims

        cauldronMaterial.color = Color.Lerp(liquidMaterial.color, cauldronMaterial.color, 0.5f);
        liquidMaterial.color = Color.grey;

        Debug.Log("Method name \"" + methodNameForUI + "\" is called from " + name);
    }
}
