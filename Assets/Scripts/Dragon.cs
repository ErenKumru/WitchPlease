using System.Collections;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    [SerializeField] private GameObject waitingDragon;
    [SerializeField] private GameObject movingDragon;

    public void Summon()
    {
        Debug.Log("Summonning the dragon");
        waitingDragon.SetActive(true);
    }

    public void GoAway()
    {
        waitingDragon.SetActive(false);
        movingDragon.SetActive(false);
    }

    public void Pet()
    {
        if (waitingDragon.activeSelf)
        {
            waitingDragon.SetActive(false);
            movingDragon.SetActive(true);
        }
    }

    public void Stop()
    {
        movingDragon.SetActive(false);
        waitingDragon.SetActive(true);
    }
    
}