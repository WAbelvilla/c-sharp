using System;

public class Aves
{
    public string Color { get; set; }
    public string Plumaje { get; set; }

    public Aves(string color, string plumaje)
    {
        Color = color;
        Plumaje = plumaje;
    }

    void Volar()
    {
        Volar();
    }
}