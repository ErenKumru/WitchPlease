using UnityEngine;

public class DragonSummonCommand : ICommand
{
    private Dragon dragon;

    public DragonSummonCommand(Dragon dragon)
    {
        this.dragon = dragon;
    }

    public void Execute()
    {
        Debug.Log("Execute dragon summon");
        dragon.Summon();
    }

    public void Undo()
    {
        Debug.Log("Undo dragon summon");
        dragon.GoAway();
    }

    public void Redo()
    {
        Debug.Log("Redo dragon summon");
        dragon.Summon();
    }
}
