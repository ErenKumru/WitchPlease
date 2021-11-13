using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrindCommand : ICommand
{

    private Plant plant;
    private string methodName;

    public GrindCommand(Plant plant, string methodName)
    {
        this.plant = plant;
        this.methodName = methodName;
    }

    //methods
    public void Execute()
    {
        Debug.Log("Execute of GrindCommand");
        plant.Grind();
    }

    public void Undo()
    {
        if(plant.executed == true){
            plant.VisiblePlant();
        }
    }

    public void Redo()
    {
        Execute();
    }
    
}