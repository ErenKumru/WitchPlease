using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCommand : ICommand
{
    private Fire fire;
    private string methodName;
    private Fire.FireState previousFireState;

    public LightCommand(Fire fire, string methodName)
    {
        this.fire = fire;
        this.methodName = methodName;
    }

    //methods
    public void Execute()
    {
        Debug.Log("Execute of LightCommand");
        previousFireState = fire.GetFireState();
        fire.Light();
    }

    public void Undo()
    {
        if (previousFireState == Fire.FireState.Lit) fire.Extinguish();
    }

    public void Redo()
    {
        Execute();
    }
}
