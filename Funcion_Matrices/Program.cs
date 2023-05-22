using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcion_Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimension;
            int[,] mata;
            int[,] matb;
            int[,] matc;
            int opcion=0;
            int opcion2 = 0; 

          do  // Do para salir
          { 
            
            Console.Clear(); 
            titulo();  //Se llama a la funcion "Titulo"
            Console.WriteLine(" ");
            Console.Write("Digite el numero de filas y columnas que tendra la matriz: ");
            dimension = int.Parse(Console.ReadLine().ToString());

            mata = new int[dimension, dimension];
            matb = new int[dimension, dimension];
            matc = new int[dimension, dimension];

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Llenado de matriz A");
            for (int x = 0; x < dimension; x++)  //Recorre las filas
            {
                for (int y = 0; y < dimension; y++) //Recorre columnas 
                {
                    Console.Write("Digite el número de la posiscion [" +x.ToString()+","+y.ToString()+ "]:"); //Llenado de la matriz A
                    mata[x, y] = int.Parse(Console.ReadLine().ToString()); 

                }

            }


            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Llenado de matriz B");
            for (int x = 0; x < dimension; x++)
            {
                for (int y = 0; y < dimension; y++)
                {
                    Console.Write("Digite el número de la posiscion [" + x.ToString() + "," + y.ToString() + "]:"); //Llenado de la matriz B
                    matb[x, y] = int.Parse(Console.ReadLine().ToString());

                }

            }

            do   //Do para el menu
            {
                Console.Clear(); 
                titulo(); 
                mostrar_matriz(dimension,mata,matb);
                Console.SetCursorPosition(5,18); 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("M E N U");
                Console.WriteLine("1.- Comparar elementos de la matriz A y de matriz B");
                Console.WriteLine("2.- Sumatoria de matriz A y de matriz B");
                Console.WriteLine("3.- Sumatoria de fila y columna de ambas matrices");
                Console.WriteLine("4.- Calcular transpuesta de la matriz");
                Console.WriteLine("5.- Salir"); 
                Console.WriteLine("SELECCIONE LA PCION CORRESPONDIENTE: ");
                opcion = int.Parse(Console.ReadLine().ToString());


                switch (opcion)
                {
                    case 1:
                        Console.Clear(); 
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(10, 1); 
                        Console.WriteLine("COMPARAR ELEMENTOS DE LA MATRIZ A Y DE MATRIZ B, GENERAR UNA NUEVA MATRIZ CON VALORES MINIMOS");

                        mostrar_matriz(dimension, mata, matb); //Se llama a la funcion que muestra las matrices que ya se llenaron
                        comparacion(dimension, mata, matb);   // Compara los elementos de las matrices y muestra una nueva matroz con los elemetos menores


                        Console.ReadLine(); 

                        break; 


                    case 2:
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.SetCursorPosition(40, 2);
                        Console.WriteLine("SUMA DE ELEMENTOS DE LAS MATRICES");
                        suma_matrices(dimension, mata,matb); //Llama a la funcion que suma los elementos de las matrices y muestra una nueva matriz con los resultados
                        Console.ReadKey(); 

                        break; 

                    case 3:

                        Console.Clear(); 

                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(30, 2);
                        Console.WriteLine("SUMA DE RENGLONES Y COLUMNAS DE LAS MATRICES");
                        Console.WriteLine(" ");
                        suma_renglones_columnas(dimension, mata, matb); //Llama a la funcion que suma las filas y columnas de las matrices y muestra los resultados

                        Console.ReadKey(); 

                        break; 

                    case 4:

                        Console.Clear();
                        Console.SetCursorPosition(40, 2);
                        Console.WriteLine("TRANSPUESTA DE LA MATRIZ A Y B");
                        transpuesta(dimension, mata, matb); //Llama a la funcion que cambia las filas y columnas
                        Console.ReadKey(); 

                        break; 

                    case 5:

                        Console.Clear(); 
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.SetCursorPosition(50, 2);
                        Console.WriteLine("SALIR DEL PROGRAMA");
                        Console.WriteLine(" ");
                        Console.WriteLine("¿Desea reiniciar la aplicación?");
                        Console.WriteLine("1.-Si   2.-No ");
                        opcion2 = int.Parse(Console.ReadLine().ToString());


                        break; 
                }


            }while(opcion!=5); //Fin del Do del menu
               
          }while (opcion2!=2); //Fin del Do del boton salir
          

        }

        public static void titulo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            string titulo = "M A T R I C E S";
            Console.SetCursorPosition(((Console.WindowWidth-titulo.Length)/2),1);
            Console.WriteLine(titulo);

        }


        public static void mostrar_matriz(int dimension, int[,]mata, int[,]matb)
        { 
            Console.ForegroundColor= ConsoleColor.Blue;
            for(int x=0; x<dimension; x++)
            {
                for(int y=0; y<dimension; y++)
                {
                    System.Console.SetCursorPosition(42+(x*4),4+(y*4));
                    Console.Write(mata[x,y].ToString());
                }
            }


            Console.ForegroundColor= ConsoleColor.Red; 
            for(int x=0; x<dimension; x++)
            {
                for(int y=0; y<dimension; y++)
                {
                    System.Console.SetCursorPosition(64+(x*4),4+(y*4));
                    Console.Write(matb[x,y].ToString());

                }
            }

        }




        public static void comparacion(int dimension, int[,] mata, int[,] matb)
        {
            int[,] matc = new int[dimension, dimension];


            for (int x = 0; x < dimension; x++)
            {
                for (int y = 0; y < dimension; y++)
                {
                    if (mata[x, y] < matb[x, y])
                    {
                        matc[x, y] = mata[x, y];
                    }

                    else
                    {
                        matc[x, y] = matb[x, y];
                    }

               
                 }

            }


                for (int x = 0; x < dimension; x++)
                {
                    for (int y = 0; y < dimension; y++)
                    {
                        Console.SetCursorPosition(54+(x*4), 20+(y*4));
                        Console.WriteLine(matc[x, y].ToString());
                    }
                }
            
            }



        public static void suma_matrices(int dimension, int[,]mata, int[,]matb)
        {
            int[,] suma = new int[dimension, dimension];

            for (int x = 0; x < dimension; x++)
            {
                for (int y = 0; y < dimension; y++)
                {
                   suma[x,y] = mata[x, y] + matb[x, y]; 
                   
                }
            }


            Console.ForegroundColor = ConsoleColor.DarkCyan;

            for (int x = 0; x < dimension; x++)
            {
                for (int y = 0; y < dimension; y++)
                {
                    Console.SetCursorPosition(50 + (x * 4), 10 + (y * 4));
                    Console.Write(suma[x, y].ToString());

                }
            }
        }



        public static void suma_renglones_columnas(int dimension, int [,]mata, int [,]matb)
        {
            int[] sumafilaA= new int[dimension];
            int[] sumacolumnaA= new int[dimension];
            int[] sumafilaB = new int[dimension];
            int[] sumacolumnaB = new int[dimension];


            Console.WriteLine(" ");
            Console.WriteLine("ELEMENTOS DE LA MATRIZ A");

            Console.ForegroundColor = ConsoleColor.Green; 

            for(int x=0; x<dimension; x++)
            {
                for (int y = 0; y < dimension; y++)
                {
                    sumafilaA[x] += mata[y, x]; 
                }

                Console.WriteLine("LA SUMA DE LA FILA " + x.ToString()+" ES: "+sumafilaA[x].ToString()); 
            }


            for (int x = 0; x < dimension; x++)
            {
                for (int y = 0; y < dimension; y++)
                {
                    sumacolumnaA[x] += mata[x,y];
                }
                Console.WriteLine("LA SUMA DE LA COLUMNA " + x.ToString() + " ES: " + sumacolumnaA[x].ToString());
            }

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White; 
            Console.WriteLine("ELEMENTOS DE LA MATRIZ B");

            Console.ForegroundColor = ConsoleColor.Red; 

            for (int x = 0; x < dimension; x++)
            {
                for (int y = 0; y < dimension; y++)
                {
                    sumafilaB[x] += matb[y,x];
                }

                Console.WriteLine("LA SUMA DE LA FILA " + x.ToString() + " ES: " + sumafilaB[x].ToString());
            }


            for (int x = 0; x < dimension; x++)
            {
                for (int y = 0; y < dimension; y++)
                {
                    sumacolumnaB[x] += matb[x,y];
                }

                Console.WriteLine("LA SUMA DE LA COLUMNA " + x.ToString() + " ES: " + sumacolumnaB[x].ToString());
            }



        }


        public static void transpuesta(int dimension, int[,] mata, int[,] matb)
        {


            int [,] matat = new int [dimension,dimension];
            int [,] matbt = new int [dimension,dimension];

           for(int x=0; x < dimension; x++)
            {
                for(int y=0; y < dimension; y++)
                 {
                     matat[x,y] = mata[y,x];
                     matbt[x,y] = matb[y,x];
                 }
            }


           Console.ForegroundColor = ConsoleColor.Blue;
            for (int x = 0; x < dimension; x++)
            {
                for (int y = 0; y < dimension; y++)
                {
                    Console.SetCursorPosition(44 + (x * 4), 5 + (y * 4));
                    Console.WriteLine(matat[x,y].ToString());  
                }

            }


            Console.ForegroundColor = ConsoleColor.Red;
            for (int x = 0; x < dimension; x++)
            {
                for (int y = 0; y < dimension; y++)
                {
                    Console.SetCursorPosition(64 + (x * 4), 5 + (y * 4));
                    Console.WriteLine(matbt[x,y].ToString());
                }

            }


        }




    }


}
