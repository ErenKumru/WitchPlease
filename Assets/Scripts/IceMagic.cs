using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceMagic : MonoBehaviour
{
    [SerializeField] private GameObject iceMagic;

    public void MakeIceMagic() //IEnumerator
    {
        Debug.Log("Make Ice Magic is called");
        if (!iceMagic.activeSelf)
        {
            iceMagic.SetActive(true);
            Debug.Log("Make Ice Magic is true");
            //yield return new WaitForSeconds(4);
            //yield return new WaitForSeconds(5);
            //Debug.Log("Make Ice Magic wait ended");
            //iceMagic.SetActive(false);
            //Debug.Log("Make Ice Magic is false");
            ; 
            
        }
    }
}
