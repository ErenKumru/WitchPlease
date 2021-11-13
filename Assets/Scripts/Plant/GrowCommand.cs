using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowCommand : ICommand
{

    private Plant plant;
    Renderer plantObj;
    private string methodName;
    float old;

    public GrowCommand(Plant plant, string methodName)
    {
        this.plant = plant;
        plantObj = plant.GetPlantObj();
        this.methodName = methodName;
    }

    public void Execute()
    {
        Debug.Log("Execute of GrowCommand");
        plant.Grow();
        this.old = this.plant.GetOldScale();
    }

    public void Undo()
    {
        Debug.Log(old);
        plantObj.transform.localScale = new Vector3(old,old,old);
    }

    public void Redo()
    {
        Execute();
    } 
}