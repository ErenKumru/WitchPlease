using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandlesChangeColorCommand : ICommand{
private Candle candles;
    private string name;

    public CandlesChangeColorCommand(Candle candles, string name)
    {
        this.candles = candles;
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void Execute()
    {
        Debug.Log("Candles are fired");
        candles.changeColor();
    }

    public void Undo()
    {
        Debug.Log("Candles are undo");
        candles.undoChangeColor();
    }

    public void Redo()
    {
        Debug.Log("Candles are fired");
        candles.changeColor();
    }
}