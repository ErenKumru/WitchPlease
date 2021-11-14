using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Main class/loader/client
public class CommandController : MonoBehaviour
{
    private TMP_Text textField;
    private InputHandler inputHandler;
    private Magic magic = new Magic();

    private void Awake()
    {
        inputHandler = FindObjectOfType<InputHandler>();
        textField = FindObjectOfType<TMP_Text>();
        inputHandler.setMagic(magic, textField);
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
        if (newCommand is ICommand && newCommand != null) magic.SetCommand(newCommand);
    }

    private void StartExecution()
    {
        Debug.Log("StartExecution");
        StartCoroutine(magic.ExecuteCommand());
    }
}
