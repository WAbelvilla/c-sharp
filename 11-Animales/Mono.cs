using System;


namespace _11_Animales {

    public class Mono : Mamiferos{
        public void Maullar()
        {
            Console.WriteLine("Maullar");
        }

        public Mono(int patas, string name): base (patas, name){
            Console.WriteLine("Numero de Patas");
        }
    }
}