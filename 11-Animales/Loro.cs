using System;

namespace _11_Animales {

    public class Loro : Aves {
        public void Hablar (){
            Console.WriteLine("Hablar");
        }

        public Loro(string color, string plumaje, string name): base( color, plumaje, name){
        
        }

    }
}