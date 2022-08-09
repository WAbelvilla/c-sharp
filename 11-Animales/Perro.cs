using System;

namespace _11_Animales {

public class Perro : Mamiferos
{
    public void Ladrar(){
        Console.WriteLine("Ladrar");
    }

    public Perro(int patas, string name): base (patas, name){
        Console.WriteLine("Numero de Patas");
    }
}
}