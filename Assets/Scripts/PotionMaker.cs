using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    //Invoker/Sender class.
public class PotionMaker
{
    //Don�t create command objects on your own, but rather get them from the client code.

    /*
     * Parameters for Commands
     * Queue/List/Stack for neccessary elements
     */

    private Queue<ICommand> commands = new Queue<ICommand>(); 
	private Stack<ICommand> undo = new Stack<ICommand>();
	private Stack<ICommand> redo = new Stack<ICommand>();


    //setCommand(Command) -> subject to change
    public void SetCommand(ICommand command)
    {
        commands.Enqueue(command);
    }

    // execute commands
    public IEnumerator ExecuteCommand()
    {
        while (commands.Count > 0)
		{
			ICommand currentCommand = commands.Dequeue();
    		currentCommand.Execute();
			undo.Push(currentCommand);
            yield return new WaitForSeconds(2f);    //wait for certain amount of time (2f = 2 seconds) before executing the next command
		}       
    }
	
	// undo command
    public void Undo()
    {      
        ICommand currentCommand = undo.Pop();
		currentCommand.Undo();
		redo.Push(currentCommand);    
    }
    
	// redo command
    public void Redo()
    {      
        ICommand currentCommand = redo.Pop();
		currentCommand.Redo();
    }
}
