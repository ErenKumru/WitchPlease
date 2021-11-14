using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceMagicCommand : ICommand
{
    private IceMagic iceMagic;
    private string name;

    public IceMagicCommand(IceMagic iceMagic, string name)
    {
        this.iceMagic = iceMagic;
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void Execute()
    {
        Debug.Log("Execute Ice Magic Command");
        iceMagic.MakeIceMagic();
    }

    public void Undo()
    {
        Debug.Log("Undo Ice Magic Command");
        iceMagic.RemoveMagic();
    }

    public void Redo()
    {
        Debug.Log("Redo Ice Magic Command");
        iceMagic.MakeIceMagic();
    }
}
