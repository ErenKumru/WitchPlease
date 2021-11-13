using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    //Command Interface
public interface ICommand
{
    public void Execute();
    public void Undo();
    public void Redo();
}
