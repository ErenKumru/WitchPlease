using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtinguishCommand : ICommand
{
    private Fire fire;
    private string methodName;

    public ExtinguishCommand(Fire fire, string methodName)
    {
        this.fire = fire;
        this.methodName = methodName;
    }

    //methods
    public void Execute()
    {
        Debug.Log("Execute of ExtinguishCommand");
        fire.Extinguish();
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
