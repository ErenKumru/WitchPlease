using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCommand : ICommand
{
    private Fire fire;
    private string name;
    private Fire.FireState previousFireState;

    public LightCommand(Fire fire, string name)
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
        Debug.Log("Execute of LightCommand");
        previousFireState = fire.GetFireState();
        fire.Light();
    }

    public void Undo()
    {
        if (previousFireState == Fire.FireState.Light) fire.Light();
        else if (previousFireState == Fire.FireState.Unlit) fire.Extinguish();
       
    }

    public void Redo()
    {
        Execute();
    }
}
