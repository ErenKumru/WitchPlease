using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    //Concrete Complex Command class
public class PourCommand : ICommand
{
    /*
     * Reciever
     * Parameters: name of the command+reciever, Cauldron gameobject
     */

    private Liquid liquid;
    private string methodName;

    //Constructor(Reciever, Parameter(commandName), Parameter(Cauldron))
    public PourCommand(Liquid liquid, string methodName /*Cauldron might be added here*/)
    {
        this.liquid = liquid;
        this.methodName = methodName;
    }

    //methods
    public void Execute()
    {
        Debug.Log("Execute of PourCommand");
        liquid.Pour(methodName);
    }

    public void Undo()
    {
        //implement me!
    }

    public void Redo()
    {
        //implement me!
    }
}
