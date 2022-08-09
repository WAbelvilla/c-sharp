using System;

namespace _11_Animales {
public class Mamiferos : Animal{
    public int Patas { get; set; }

    public Mamiferos ( int patas, string name): base(name){
    }

    // Si se refieren al numero de patas, entonces patas deberia ser de tipo Entero , integer


    public void Caminar(int numeroPatas)
    {
        Console.WriteLine("Camina con ", numeroPatas);
    }
}

}