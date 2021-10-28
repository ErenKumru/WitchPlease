using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    //Intermediate class for handling inputs
public class InputHandler : MonoBehaviour
{
    //Handles input for each distinct command type
    //Returns Concrete Complex Command(e.g. LiquidCommand)
    public ICommand HandleInput()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            /*
             * Get the Reciever object
             * Instantiate/Create the Concrete Complex Command object/class with passing the Reciever and Parameter into the constructor that calls/holds the actual operation
             */

            Debug.Log("Input given for liquid and new LC created");
            Liquid liquid = FindObjectOfType<Liquid>(); //subject to change, might need to find a more suitable way
            return new LiquidCommand(liquid, "Pour");   //string "Pour" is given for UI element
        }

        return null;
    }
}
