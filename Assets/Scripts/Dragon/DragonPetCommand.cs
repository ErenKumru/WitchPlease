using UnityEngine;

public class DragonPetCommand : ICommand
{
    private Dragon dragon;

    public DragonPetCommand(Dragon dragon)
    {
        this.dragon = dragon;
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