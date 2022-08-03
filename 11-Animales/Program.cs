using System;

namespace _11_Animales
{
    class program
    {
        static void Main(string[] args)
        {
            string opcion = "";
            
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Lista de Animales");
                Console.WriteLine("*********************");
                Console.WriteLine("");
                Console.WriteLine("1 - Mamiferos");
                Console.WriteLine("2 - Aves");
                Console.WriteLine("3 - Peces");
                Console.WriteLine("0 - Salir");
                Console.WriteLine("");
                Console.Write("Ingrese una opcion: ");
                opcion = Console.ReadLine();
                
                

                switch (opcion)
                {
                    case "1":
                        ;
                        break;

                    case"2":
                        ;
                        break;
                    case"3":
                        ;
                        break;
                    case"4":
                        ;
                        break;
                    case"5":
                        ;
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
