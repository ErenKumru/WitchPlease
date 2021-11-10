using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceMagic : MonoBehaviour
{
    [SerializeField] private GameObject iceMagic;
    [SerializeField] private GameObject ice;

    public void MakeIceMagic() //IEnumerator
    {
        Debug.Log("Make Ice Magic is called");
        if (!iceMagic.activeSelf)
        {
            iceMagic.SetActive(true);
            ice.SetActive(true);
            {
                StartCoroutine(RemoveAfterSeconds(3, iceMagic));
            }
 
            IEnumerator RemoveAfterSeconds(int seconds, GameObject obj)
            {
                yield return new WaitForSeconds(seconds);
                obj.SetActive(false);
            }

        }
    }

    public void RemoveMagic()
    {
        ice.SetActive(false);
    }
}
