using System;
using System.Collections.Generic;
using Jypeli;
using Jypeli.Assets;
using Jypeli.Controls;
using Jypeli.Effects;
using Jypeli.Widgets;

public class LiveOrDie : PhysicsGame
{


    

    Image maastonKuva = LoadImage("Map");
    

  

        public override void  Begin()
    {
        olio();
        LuoKentta();
    }

    void AsetaOhjaimet()

    {
       
        
    
        //TODO: Kirjoita ohjelmakoodisi tähän
       

        PhoneBackButton.Listen(ConfirmExit, "Lopeta peli");
        Keyboard.Listen(Key.Escape, ButtonState.Pressed, ConfirmExit, "Lopeta peli");
    }

    
    void olio()
    {
    
    PhysicsObject olio = new PhysicsObject(100, 50);
    olio.Shape = Shape.CreateRegularPolygon(10); // kymmenkulmio
    Add(olio);
    olio.Color = Color.Yellow;

    }

    void LuoKentta()
    {
        Shape shape = Shape.FromImage(maastonKuva);
        Surface maasto = new Surface(1000,50, 123, 50, 50);
        Add(maasto);


        Surfaces reunat = Level.CreateBorders();

        foreach (var reuna in reunat)
            reuna.Color = Color.Black;
        
        
    }


    void musiikki()
    {
        MediaPlayer.Play("pendulum_-_tarantula_hd-3ZR2p-DhSX4_fmt43.mp3");
        MediaPlayer.IsRepeating = true;
    }
  
}  
