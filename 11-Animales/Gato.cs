using System;

namespace _11_Animales {
public class Gato : Mamiferos
{
    public void Maullar(){
        Console.WriteLine("Maullar");
    }

    public Gato(int patas, string name): base (patas, name){
        Console.WriteLine("Numero de Patas");
    }

}
}