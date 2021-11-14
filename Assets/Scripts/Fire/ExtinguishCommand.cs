using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtinguishCommand : ICommand
{
    private Fire fire;
    private string name;
    private Fire.FireState previousFireState;

    public ExtinguishCommand(Fire fire, string name)
    {
        this.fire = fire;
        this.name = name;
    }

    public string GetName()
    {
        return name;
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
        if (previousFireState == Fire.FireState.Light) fire.Light();
        else if (previousFireState == Fire.FireState.Small) fire.Extinguish();
        else if (previousFireState == Fire.FireState.Unlit) fire.Extinguish();
        else if (previousFireState == Fire.FireState.Big) fire.FeedFire();
    }

    public void Redo()
    {
        Execute();
    }
}
