using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedFireCommand : ICommand
{
    private Fire fire;
    private string methodName;

    public FeedFireCommand(Fire fire, string methodName)
    {
        this.fire = fire;
        this.methodName = methodName;
    }

    //methods
    public void Execute()
    {
        Debug.Log("Execute of FeedFireCommand");
        fire.FeedFire();
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
