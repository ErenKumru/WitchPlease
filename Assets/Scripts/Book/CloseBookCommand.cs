using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseBookCommand : ICommand
{
    private Book book;
    private string name;

    public CloseBookCommand(Book book, string name)
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
        Debug.Log("Execute Close Book Command");
        book.CloseBook();
    }

    public void Undo()
    {
        Debug.Log("Undo Close Book Command");
        book.OpenBook();
    }

    public void Redo()
    {
        Debug.Log("Redo Close Book Command");
        book.CloseBook();
    }
}
