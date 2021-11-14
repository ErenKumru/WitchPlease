using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopCommend : ICommand
{

    private Plant plant;
    private Renderer plantObj;
    private string name;
    

    public ChopCommend(Plant plant, string name)
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
        Debug.Log("Execute of ChopCommand");
        plantObj = plant.GetPlantObj();
        plant.Chop();
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
