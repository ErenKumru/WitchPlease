using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtinguishCommand : ICommand
{
    private Fire fire;
    private string methodName;
    private Fire.FireState previousFireState;

    public ExtinguishCommand(Fire fire, string methodName)
    {
        this.fire = fire;
        this.methodName = methodName;
    }

    //methods
    public void Execute()
    {
        Debug.Log("Execute of ExtinguishCommand");
        previousFireState = fire.GetFireState();
        fire.Extinguish();
    }

    public void Undo()
    {
        if (previousFireState == Fire.FireState.Small) fire.FeedFire();
        else if (previousFireState == Fire.FireState.Unlit) fire.Light();
        else if (previousFireState == Fire.FireState.UnlitE) fire.Extinguish();
    }

    public void Redo()
    {
        Execute();
    }
}
