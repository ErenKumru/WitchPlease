using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    //Intermediate class for handling inputs
public class InputHandler : MonoBehaviour
{
    //Handles input for each distinct command type
    //Returns Concrete Complex Command(e.g. PourCommand)

    /*
    * Get the Reciever object
    * Instantiate/Create the Concrete Complex Command object/class with passing the Reciever and Parameter into the constructor that calls/holds the actual operation
    */

    public ICommand HandleInput()
    {
        if(Input.GetKeyDown(KeyCode.P))     //PourCommand
        {
            Debug.Log("Input given for liquid and new LC created");
            Liquid liquid = FindObjectOfType<Liquid>(); //subject to change, might need to find a more suitable way
            return new PourCommand(liquid, "Pour");   //string "Pour" is given for UI element
        }
        else if(Input.GetKeyDown(KeyCode.F))    //FeedFireCommand
        {
            Fire fire = FindObjectOfType<Fire>();
            return new FeedFireCommand(fire, "FeedFire");
        }
        else if(Input.GetKeyDown(KeyCode.L))    //LightCommand
        {
            Fire fire = FindObjectOfType<Fire>();
            return new LightCommand(fire, "Light");
        }
        else if(Input.GetKeyDown(KeyCode.E))    //ExtinguishCommand
        {
            Fire fire = FindObjectOfType<Fire>();
            return new ExtinguishCommand(fire, "Extinguish");
        }

        return null;
    }
}