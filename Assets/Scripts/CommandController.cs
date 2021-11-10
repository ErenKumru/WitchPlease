using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    //Main class/loader/client
public class CommandController : MonoBehaviour
{
    //coroutine to execute, UI etc.

    private InputHandler inputHandler;
    private PotionMaker potionMaker = new PotionMaker();

    private void Awake()
    {
        inputHandler = FindObjectOfType<InputHandler>();    //finds the object with the given type (InputHandler) in the scene/hierarchy
        inputHandler.setPotionMaker(potionMaker);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) StartExecution();
        else AddCommand();
    }

    private void AddCommand()
    {
        Debug.Log("Add command called");
        ICommand newCommand = inputHandler.HandleInput();
        if (newCommand is ICommand && newCommand != null) potionMaker.SetCommand(newCommand);   //PotionMaker potionMaker = new PotionMaker(new ComplexCommand(reciever, methodName));
    }

    private void StartExecution()
    {
        Debug.Log("StartExecution");
        StartCoroutine(potionMaker.ExecuteCommand());
    }
}
