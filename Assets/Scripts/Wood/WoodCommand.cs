using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodCommand : ICommand
{
    private Wood wood;
    private string name;

    public WoodCommand(Wood wood, string name)
    {
        this.wood = wood;
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void Execute()
    {
        Debug.Log("Execute Wood Command");
        wood.AddWood();
    }

    public void Undo()
    {
        Debug.Log("Undo Wood Command");
        wood.RemoveWood();
    }

    public void Redo()
    {
        Debug.Log("Redo Wood Command");
        wood.AddWood();
    }
}
