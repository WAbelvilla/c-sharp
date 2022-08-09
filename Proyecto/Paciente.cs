using System;

public class Paciente : Persona
{
    public string Edad { get; set; }
    public string Sexo { get; set; }
    public string Lugar { get; set; }

    public Paciente (int codigo, string nombre, string edad, string sexo, string lugar)
    {
        Codigo = codigo;
        Nombre = nombre;
        Edad = edad;
        Sexo = sexo;
        Lugar = lugar;
    }
}    