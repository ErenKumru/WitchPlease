using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrindCommand : ICommand
{

    private Plant plant;
    private string name;

    public GrindCommand(Plant plant, string name)
    {
        this.plant = plant;
        this.name = name;
    }

    public string GetName()
    {
        return name;
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