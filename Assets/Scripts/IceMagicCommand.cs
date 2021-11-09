using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceMagicCommand : ICommand
{
    private IceMagic iceMagic;

    public IceMagicCommand(IceMagic iceMagic)
    {
        this.iceMagic = iceMagic;
    }

    public void Execute()
    {
        Debug.Log("Execute Ice Magic Command");
        iceMagic.MakeIceMagic();
    }

    public void Undo()
    {
        
    }

    public void Redo()
    {
        
    }
}
