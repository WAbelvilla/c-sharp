using System;

namespace _11_Animales {

    public class PezGlobo: Peces {
        public void Inflarse (){
            Console.WriteLine("Inflarse");
        }

        public PezGlobo(double numeroAletas): base (numeroAletas)
        {
            
        }
    }
}