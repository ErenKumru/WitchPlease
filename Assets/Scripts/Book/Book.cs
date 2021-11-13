using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    [SerializeField] private GameObject open_book;
    [SerializeField] private GameObject close_book;
    private bool is_book_open=false;

    public void OpenBook()
    {
        Debug.Log("Open Book is called");
        if (!is_book_open)
        {
            open_book.SetActive(true);
            close_book.SetActive(false);
            is_book_open = true;
        }
    }

    public void CloseBook()
    {
        if (is_book_open)
        {
            open_book.SetActive(false);
            close_book.SetActive(true);
            is_book_open = false;
        }
    }
}
