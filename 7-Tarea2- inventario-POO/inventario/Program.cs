using System;

namespace inventario
{
    class program
    {
        static void Main(string[] args)
        {
            string opcion = "";
            Inventario inventario = new Inventario();

            while(true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Inventario");
                Console.WriteLine("*********************");
                Console.WriteLine("");
                Console.WriteLine("1 - Productos");
                Console.WriteLine("2 - Ingreso de inventario");
                Console.WriteLine("3 - Salida de inventario");
                Console.WriteLine("4 - Ajuste Positivo");
                Console.WriteLine("5 - Ajuste Negativo");
                Console.WriteLine("0 - Salir");
                Console.WriteLine("");
                Console.Write("Ingrese una opcion: ");
                opcion = Console.ReadLine();
                
                

                switch (opcion)
                {
                    case "1":
                        inventario.listarProductos();
                        break;

                    case"2":
                        inventario.ingresoDeInventario();
                        break;
                    case"3":
                        inventario.salidaDeInventario();
                        break;
                    case"4":
                        inventario.ajustePositivo();
                        break;
                    case"5":
                        inventario.ajusteNegativo();
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