public class Enfermera : Persona
{
    public string CodigoEnfermera { get; set; }

    public Enfermera(int codigo, string nombre, string codigoEnfermera)
    {
        Codigo = codigo;
        Nombre = nombre;
        CodigoEnfermera = codigoEnfermera;
    }


}           