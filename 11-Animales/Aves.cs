using System;

namespace _11_Animales {

    public class Aves : Animal{
        public string Color { get; set; }
        public string Plumaje { get; set; }

        public Aves(string color, string plumaje, string name): base (name)
        {
            Color = color;
            Plumaje = plumaje;
        }

        void Volar()
        {
            Console.WriteLine("Volar");
        }
    }
}