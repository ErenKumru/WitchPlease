using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

    //Invoker/Sender class.
public class Magic
{
	//Don't create command objects on your own, but rather get them from the client code.

	/*
     * Parameters for Commands
     * Queue/List/Stack for neccessary elements
     */

    private Queue<ICommand> commands = new Queue<ICommand>(); 
	private Stack<ICommand> undo = new Stack<ICommand>();
	private Stack<ICommand> redo = new Stack<ICommand>();
	private TMP_Text commandText;

	public void SetTextField(TMP_Text textField)
	{
		commandText = textField;
	}

	public void SetCommand(ICommand command)
    {
        commands.Enqueue(command);
		commandText.text += command.GetName() + "\n";
    }

    public IEnumerator ExecuteCommand()
    {
        while (commands.Count > 0)
		{
			ICommand currentCommand = commands.Dequeue();

			int count = 0;
			while (commandText.text[count] != '\n')
			{
				count++;
			}
			commandText.text = commandText.text.Remove(0, count + 1);

			currentCommand.Execute();
			undo.Push(currentCommand);
            yield return new WaitForSeconds(2f);
		}       
    }
	
    public void Undo()
    {
	    if (undo.Count != 0)
	    {
		    ICommand currentCommand = undo.Pop();
		    currentCommand.Undo();
		    redo.Push(currentCommand); 
	    }
	    else
	    {
		    Debug.Log("Undo Stack is empty.");
	    }
    }
    
    public void Redo()
    {
	    if (redo.Count != 0)
	    {
		    ICommand currentCommand = redo.Pop();
		    undo.Push(currentCommand);
		    currentCommand.Redo();
	    }
	    else
	    {
		    Debug.Log("Redo Stack is empty.");
	    }
    }
}
