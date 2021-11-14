using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandlesBlowCommand : ICommand{
private Candle candles;
    private string name;
    public CandlesBlowCommand(Candle candles, string name)
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
        candles.fireOrBlowCandle();
    }

    public void Undo()
    {
        Debug.Log("Candles are fired");
        candles.fireOrBlowCandle();
    }

    public void Redo()
    {
        Debug.Log("Candles are fired");
        candles.fireOrBlowCandle();
    }
}