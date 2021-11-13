using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBookCommand : ICommand
{
    private Book book;

    public OpenBookCommand(Book book)
    {
        this.book = book;
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
