using System;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args) 
        {
            Informacion info = new Informacion();
            string opcion = "";
            

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Pacientes Covid-19");
                Console.WriteLine("******************");
                Console.WriteLine("");
                Console.WriteLine("1 - Crear Paciente nuevo.");
                Console.WriteLine("2 - Lista de Pacientes");
                Console.WriteLine("3 - Lista de Enfermeros.");
                Console.WriteLine("0 - Salir.");
                Console.WriteLine("");

                Console.Write("Elija una opcion: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        info.CrearPacienteNuevo();
                        break;
                    case "2":
                        info.ListarPacientes();
                        break;
                    case "3":
                        info.ListarEnfermeras();
                        break;
                    default:
                        break;
                }

                if (opcion == "0")
                {
                    break;
                }
            }    
        }
        
    }

}
