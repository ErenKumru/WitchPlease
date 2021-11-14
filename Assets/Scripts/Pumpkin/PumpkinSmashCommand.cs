using UnityEngine;

public class PumpkinSmashCommand : ICommand
{
      private Pumpkin pumpkin;
    private string name;

    public PumpkinSmashCommand(Pumpkin pumpkin, string name)
      {
            this.pumpkin = pumpkin;
        this.name = name;
      }

    public string GetName()
    {
        return name;
    }

    public void Execute()
      {
            pumpkin.Smash();
      }

      public void Undo()
      {
            pumpkin.Glue();
      }

      public void Redo()
      {
            pumpkin.Smash();
      }
}
