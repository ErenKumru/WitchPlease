using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandlesCommand : ICommand{
private Candle candles;

    public CandlesCommand(Candle candles)
    {
        this.candles = candles;
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