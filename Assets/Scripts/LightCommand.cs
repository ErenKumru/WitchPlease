using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCommand : ICommand
{
    private Fire fire;
    private string methodName;

    public LightCommand(Fire fire, string methodName)
    {
        this.fire = fire;
        this.methodName = methodName;
    }

    //methods
    public void Execute()
    {
        Debug.Log("Execute of LightCommand");
        fire.Light();
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
