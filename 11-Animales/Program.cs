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
                
                // Aqui vamos a crear las intancias de los objetos creados
                Perro pluto = new Perro(4, "Pluto");
                pluto.Caminar(4);
                pluto.Ladrar();

                Mono jorge = new Mono(4, "Jorge el Curioso");
                
                jorge.Caminar(2);
                jorge.Maullar();

                // El polimorfismo lo que permite es que diferentes objetos
                // utilicen el mismo metodo sin detectar ningun problema 

                Aguila aguilamexica = new Aguila("Negro", "Rojo", "Aguila Mexicana");


                switch (opcion)
                {
                    case "1":
                        pluto.Ladrar();
                        ;
                        break;

                    case"2":
                        aguilamexica.VolarAlto();
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
