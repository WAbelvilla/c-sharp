using System;

namespace _11_Animales {

    public class Peces {
        public double NumeroAletas { get; set; }
        
        public Peces (double numeroAletas)
        {
            NumeroAletas = numeroAletas;
            
        }
        void Nadar(){
            Console.WriteLine("Nadar");
        }
    }

}