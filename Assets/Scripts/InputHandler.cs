using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Intermediate class for handling inputs
public class InputHandler : MonoBehaviour
{
    //Handles input for each distinct command type
    //Returns Concrete Complex Command(e.g. PourCommand)

    /*
    * Get the Reciever object
    * Instantiate/Create the Concrete Complex Command object/class with passing the Reciever and Parameter into the constructor that calls/holds the actual operation
    */

    private Magic magic;

    public ICommand HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            magic.Undo();
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            magic.Redo();
        }
        else if(Input.GetKeyDown(KeyCode.F))    //FeedFireCommand
        {
            Fire fire = FindObjectOfType<Fire>();
            return new FeedFireCommand(fire, "FeedFire");
        }
        else if(Input.GetKeyDown(KeyCode.L))    //LightCommand
        {
            Fire fire = FindObjectOfType<Fire>();
            return new LightCommand(fire, "Light");
        }
        else if(Input.GetKeyDown(KeyCode.E))    //ExtinguishCommand
        {
            Fire fire = FindObjectOfType<Fire>();
            return new ExtinguishCommand(fire, "Extinguish");
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            Wood wood = FindObjectOfType<Wood>();
            return new WoodCommand(wood, "Wood");
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            IceMagic iceMagic= FindObjectOfType<IceMagic>();
            return new IceMagicCommand(iceMagic, "IceMagic");
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            //Debug.log("hey");
            Candle candle= FindObjectOfType<Candle>();
            return new CandlesBlowCommand(candle, "CandlesBlow");
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            //Debug.log("hey");
            Candle candle= FindObjectOfType<Candle>();
            return new CandlesChangeColorCommand(candle, "CandlesChangeColor");
        }
        else if (Input.GetKeyDown(KeyCode.A)){
            Cage cage = FindObjectOfType<Cage>();
            return new CageCommand(cage, "Cage");
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Dragon dragon = FindObjectOfType<Dragon>();
            return new DragonSummonCommand(dragon, "DragonSummon");
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Dragon dragon = FindObjectOfType<Dragon>();
            return new DragonPetCommand(dragon, "DragonPet");
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            Pumpkin pumpkin = FindObjectOfType<Pumpkin>();
            return new PumpkinSmashCommand(pumpkin, "PumpkinSmash");
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            Book book = FindObjectOfType<Book>();
            return new OpenBookCommand(book, "OpenBook");
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            Book book = FindObjectOfType<Book>();
            return new CloseBookCommand(book, "CloseBook");
        }
        else if(Input.GetKeyDown(KeyCode.G))    //GrowCommand
        {
            Plant plant = FindObjectOfType<Plant>(); 
            return new GrowCommand(plant, "Grow");
        }
        else if(Input.GetKeyDown(KeyCode.R))
        {
            Plant plant = FindObjectOfType<Plant>(); 
            return new GrindCommand(plant, "Grind"); 
        }
        else if(Input.GetKeyDown(KeyCode.K))
        {
            Plant plant = FindObjectOfType<Plant>(); 
            return new ChopCommend(plant, "Chop"); 
        }

        return null;
    }

    public void setMagic(Magic magic, TMP_Text textField)
    {
        this.magic = magic;
        magic.SetTextField(textField);
    }
}
