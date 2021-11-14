using UnityEngine;

public class DragonPetCommand : ICommand
{
    private Dragon dragon;
    private string name;

    public DragonPetCommand(Dragon dragon, string name)
    {
        this.dragon = dragon;
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void Execute()
    {
        dragon.Pet();
    }

    public void Undo()
    {
        dragon.Stop();
    }

    public void Redo()
    {
        dragon.Pet();
    }
}