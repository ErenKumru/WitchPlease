using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopCommend : ICommand
{

    private Plant plant;
    private Renderer plantObj;
    private string methodName;
    

    public ChopCommend(Plant plant, string methodName)
    {
        this.plant = plant;
        this.methodName = methodName;
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
