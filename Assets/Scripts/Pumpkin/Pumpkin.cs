using UnityEngine;

public class Pumpkin : MonoBehaviour
{
    [SerializeField] private GameObject pumpkin;
    [SerializeField] private GameObject smashedPumpkin;

    public void Smash()
    {
        pumpkin.SetActive(false);
        smashedPumpkin.SetActive(true);
    }

    public void Glue()
    {
        smashedPumpkin.SetActive(false);
        pumpkin.SetActive(true);
    }

}