using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBookCommand : ICommand
{
    private Book book;
    private string name;

    public OpenBookCommand(Book book, string name)
    {
        this.book = book;
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void Execute()
    {
        Debug.Log("Execute Open Book Command");
        book.OpenBook();
    }

    public void Undo()
    {
        Debug.Log("Undo Open Book Command");
        book.CloseBook();
    }

    public void Redo()
    {
        Debug.Log("Redo Open Book Command");
        book.OpenBook();
    }
}
