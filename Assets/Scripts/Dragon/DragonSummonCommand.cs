using UnityEngine;

public class DragonSummonCommand : ICommand
{
    private Dragon dragon;
    private string name;

    public DragonSummonCommand(Dragon dragon, string name)
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
