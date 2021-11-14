using System.Collections;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    [SerializeField] private GameObject waitingDragon;
    [SerializeField] private GameObject movingDragon;
    private bool isMoving;

    public void Summon()
    {
        Debug.Log("Summonning the dragon");
        if (!(waitingDragon.activeSelf || movingDragon.activeSelf))
        {
            waitingDragon.SetActive(true);
        }
        
    }

    public void GoAway()
    {
        if ((!movingDragon.activeSelf) && waitingDragon.activeSelf)
        {
            waitingDragon.SetActive(false);
            movingDragon.SetActive(false);
        }
        else if (isMoving)
        {
            Stop();
        }
    }

    public void Pet()
    {
        if (waitingDragon.activeSelf)
        {
            waitingDragon.SetActive(false);
            movingDragon.SetActive(true);
            isMoving = true;
        }
    }

    public void Stop()
    {
        if (movingDragon.activeSelf && isMoving) 
        {
            movingDragon.SetActive(false);
            waitingDragon.SetActive(true);
            isMoving = false;
        }
        else if (!isMoving)
        {
             GoAway();
        }
    }
    
}