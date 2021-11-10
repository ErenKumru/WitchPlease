using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandlesChangeColorCommand : ICommand{
private Candle candles;

    public CandlesChangeColorCommand(Candle candles)
    {
        this.candles = candles;
    }

    public void Execute()
    {
        Debug.Log("Candles are fired");
        candles.changeColor();
    }

    public void Undo()
    {
        Debug.Log("Candles are fired");
        candles.undoChangeColor();
    }

    public void Redo()
    {
        Debug.Log("Candles are fired");
        candles.changeColor();
    }
}