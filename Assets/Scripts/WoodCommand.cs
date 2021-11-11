using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodCommand : ICommand
{
    private Wood wood;

    public WoodCommand(Wood wood)
    {
        this.wood = wood;
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
