using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    //Invoker/Sender class.
public class PotionMaker
{
    //Don’t create command objects on your own, but rather get them from the client code.

    /*
     * Parameters for Commands
     * Queue/List/Stack for neccessary elements
     */

    //public List<ICommand> commands = new List<ICommand>();
    public ICommand command;

    //setCommand(Command) -> subject to change
    public void SetCommand(ICommand command)
    {
        Debug.Log("set command");
        this.command = command;
    }

    //executeCommand
    public void ExecuteCommand()
    {
        if (command is ICommand && command != null)
        {
            Debug.Log("ExecuteCommand of PM");
            command.Execute();
        }
            
    }

    //undoCommand
    //redoCommand
}
