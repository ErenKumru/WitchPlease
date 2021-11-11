using System.Collections;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    [SerializeField] private GameObject dragon;

    public void Summon()
    {
        Debug.Log("Summonning the dragon");
        dragon.SetActive(true);
    }

    public void GoAway()
    {
        dragon.SetActive(false);
    }
    
}