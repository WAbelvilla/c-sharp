using System;

namespace _11_Animales {
    public class Aguila : Aves {
        public void VolarAlto (){
            Console.WriteLine("Volar Alto");
        }

        public Aguila(string color, string plumaje, string name): base( color, plumaje, name){
        
        }
    }
}