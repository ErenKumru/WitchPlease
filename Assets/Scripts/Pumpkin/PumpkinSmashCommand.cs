using UnityEngine;

public class PumpkinSmashCommand : ICommand
{
      private Pumpkin pumpkin;

      public PumpkinSmashCommand(Pumpkin pumpkin)
      {
            this.pumpkin = pumpkin;
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
