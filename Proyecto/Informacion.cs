using System;
using System.Collections.Generic;
using System.Linq;

public class Informacion
{
    public List<Paciente> ListadePacientes { get; set; }
    public List<Enfermera> ListadeEnfermeras { get; set; }

    public Informacion()
    {
        ListadePacientes = new List<Paciente>();
        cargarPacientes();

        ListadeEnfermeras = new List<Enfermera>();
        cargarEnfermeras();

        
    }

    private void cargarPacientes()
    {
        Paciente p1 = new Paciente(1, "Juan Carlos Garcia Martinez ", "35", "Masculino", "Olancho");
        ListadePacientes.Add(p1);

        Paciente p2 = new Paciente(2, "Jose Patricio Zaldivar Tejeda ", "55", "Masculino", "Tegucigalpa");
        ListadePacientes.Add(p2);

        Paciente p3 = new Paciente(3, "Sthepany Gissela Portillo Hernandez ", "18", "Femenino", "Tela");
        ListadePacientes.Add(p3);

        Paciente p4 = new Paciente(4, "Patricia Rebeka Matute Sanchez ", "65", "Femenino", "Olanchito");
        ListadePacientes.Add(p4);

        Paciente p5 = new Paciente(5, "Marina Josefina Garcia Perdomo ", "20", "Femenino", "Copan");
        ListadePacientes.Add(p5);

        Paciente p6 = new Paciente(6, "Patrick Enos Palma Alvarenga ", "19", "Masculino", "Colon");
        ListadePacientes.Add(p6);

        Paciente p7 = new Paciente(7, "Skyler Paola Chinchilla Avila ", "25", "Femenino", "Ceiba");
        ListadePacientes.Add(p7);

        Paciente p8 = new Paciente(8, "Suandy Karina Padilla Suazo ", "48", "Femenino", "Villanueva");
        ListadePacientes.Add(p8);

        Paciente p9 = new Paciente(9, "Miriam Alejandra Moradel Manzano ", "28", "Femenino", "Santa Barbara");
        ListadePacientes.Add(p9);

        Paciente p10 = new Paciente(10, "Lionel Andre Messi Couchitini ", "35", "Masculino", " Argentina");
        ListadePacientes.Add(p10);
        
        Paciente p11;
        
    }

    private void cargarEnfermeras()
    {
        Enfermera e1 = new Enfermera(1, "Katia Funes", "E001");
        ListadeEnfermeras.Add(e1);

        Enfermera e2 = new Enfermera(2, "Maria Tejeda", "E002");
        ListadeEnfermeras.Add(e2);

        Enfermera e3 = new Enfermera(3, "Guadalupe Sagastume", "E003");
        ListadeEnfermeras.Add(e3);

        Enfermera e4 = new Enfermera(4, "Gissela Ochoa", "E004");
        ListadeEnfermeras.Add(e4);

        Enfermera e5 = new Enfermera(5, "Andrea Zapata", "E005");
        ListadeEnfermeras.Add(e5);
        
    }

    public void ListarPacientes()
    {
        Console.Clear();
        Console.WriteLine("Lista de Pacientes");
        Console.WriteLine("******************");
        Console.WriteLine("");

        foreach (var paciente in ListadePacientes)
        {
            Console.WriteLine(paciente.Codigo + " - " + paciente.Nombre + " | " + paciente.Edad + " | " + paciente.Sexo + " | " + paciente.Lugar + ".");
        }

        Console.ReadLine();
    }

    public void ListarEnfermeras()
    {
        Console.Clear();
        Console.WriteLine("Lista de Enfermeras");
        Console.WriteLine("******************");
        Console.WriteLine("");

        foreach (var enfermera in ListadeEnfermeras)
        {
            Console.WriteLine(enfermera.Codigo + " - " + enfermera.Nombre + " | " + enfermera.CodigoEnfermera + ".");
        }

        Console.ReadLine();
    }

    public void CrearPacienteNuevo()
    {
        Console.Clear();
        
        Console.WriteLine("Creando Paciente Nuevo");
        Console.WriteLine("*************");
        Console.WriteLine("");
        
        Console.Write("Nombre completo del paciente: ");
        string nombreCompleto = Console.ReadLine();

        Console.WriteLine("");
        Console.Write("Ingrese la edad del paciente: ");
        string edad = Console.ReadLine();
        
        Console.WriteLine("");
        Console.Write("Ingrese el Sexo del paciente: ");
        string sexo = Console.ReadLine();

        Console.WriteLine("");
        Console.Write("Ingrese el lugar de nacimiento del paciente: ");
        string lugar = Console.ReadLine();

        Console.WriteLine("");
        Console.Write("Ingrese el codigo de la Enfermera: ");
        string codigoEnfermera = Console.ReadLine();

        Enfermera enfermera = ListadeEnfermeras.Find(v => v.Codigo.ToString() == codigoEnfermera);
        if (enfermera == null)
        {
            Console.Write("Enfermera no encontrada");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Enfermera: " + enfermera.Nombre);
            Console.WriteLine("");
        }

        Paciente p11 = new Paciente(11, nombreCompleto, edad, sexo, lugar);
        ListadePacientes.Add(p11);
        
        
        while (true)
        {
            Console.Write("Desea continuar? s/n: ");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "s")
            {
                CrearPacienteNuevo();
            }
            else
            {
                break;
            }
        }


    }
}