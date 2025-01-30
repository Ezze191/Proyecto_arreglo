using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Arreglo_abc
{
    internal class Program
    {
        static double[] arreglo_numero = new double[30];
        static string[] arreglo_abc = new string[30];
        static int puntero = -1;
        static double valor = -1;
        static string entrada = null;
        static void Main(string[] args)
        {
            for (int i = 0; i < arreglo_numero.Length; i++) {
                arreglo_numero[i] = -1;
                arreglo_abc[i] = "";
            }

            menu();
        
            

        }

        static void menu()
        {
           
            int input;
            Console.WriteLine("puntero : " + puntero);
            Console.WriteLine("1.Borrar Arreglo");
            Console.WriteLine("2.Mostrar Arreglo");
            Console.WriteLine("3.Buscar Letra");
            Console.WriteLine("4.Insertar Letra");
            Console.WriteLine("5.Elimiar Letra");
            Console.WriteLine("6.Creditos");
            input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.Clear();
                    borrar();
                    break;
                case 2:
                    Console.Clear();
                    mostrar();
                    break;
                case 3:
                    Console.Clear();
                    buscar();
                    break;
                case 4:
                    Console.Clear();
                    insertar();
                    break;
                case 5:
                    Console.Clear();
                    eliminarLetra();
                    break;
                case 6:
                    Console.Clear();
                    creditos();
                    break;
                default:
                    Console.Clear();
                    menu();
                    break;
            }
        }
        static void borrar()
        {
            if(puntero == -1)
            {
                Console.WriteLine("el arreglo no tiene datos");
                menu();
            }


            puntero = puntero - 1;
            menu();
        
        
        }
        static void mostrar()
        {
            for (int x = 0; x < arreglo_numero.Length; x++)
            {
                
                if (arreglo_numero[x] != -1) {
                    Console.WriteLine("[" + arreglo_abc[x] + "]");
                }
            
            }
            menu();
        }

        static void buscar()
        {
            bool encontrado = false;
            string input;
            Console.WriteLine("cual letra quieres buscar?");
            input= Console.ReadLine();

            for(int i = 0; i <= puntero; i++)
            {
                if (arreglo_abc[i] == input)
                {
                    
                    Console.WriteLine("la letra " + input + " esta en la posicion :" + i);
                    encontrado = true;

                }
            }
            if(encontrado == false)
            {
                Console.WriteLine("la letra no existe en el arreglo");
            }

            menu();
            
        }


        static void insertar()
        {
            if (puntero > 30)
            {
                Console.WriteLine("arreglo lleno");
                menu();
            }
            puntero++;
            int i = puntero;
            Console.WriteLine("cual es tu letra");
            entrada = Console.ReadLine();
            switch (entrada)
            {
                case "A":
                    valor = 0;
                    break;
                case "a":
                    valor = 0.5;
                    break;
                case "B":
                    valor = 1;
                    break;
                case "b":
                    valor = 1.5;
                    break;
                case "C":
                    valor = 2;
                    break;
                case "c":
                    valor = 2.5;
                    break;
                case "D":
                    valor = 3;
                    break;
                case "d":
                    valor = 3.5;
                    break;
                case "E":
                    valor = 4;
                    break;
                case "e":
                    valor = 4.5;
                    break;
                case "F":
                    valor = 5;
                    break;
                case "f":
                    valor = 5.5;
                    break;
                default:
                    Console.WriteLine("no existe esa letra");
                    break;

            }

            while (i > 0 && arreglo_numero[i - 1] > valor)
            {
                arreglo_numero[i] = arreglo_numero[i - 1];
                i--;
            }

            arreglo_numero[i] = valor;

            

            for (int j = 0; j <= puntero; j++) {
                switch (arreglo_numero[j])
                {
                    case 0:
                        arreglo_abc[j] = "A";
                        break;
                    case 0.5:
                        arreglo_abc[j] = "a";
                        break;
                    case 1:
                        arreglo_abc[j] = "B";
                        break;
                    case 1.5:
                        arreglo_abc[j] = "b";
                        break;
                    case 2:
                        arreglo_abc[j] = "C";
                        break;
                    case 2.5:
                        arreglo_abc[j] = "c";
                        break;
                    case 3:
                        arreglo_abc[j] = "D";
                        break;
                    case 3.5:
                        arreglo_abc[j] = "d";
                        break;
                    case 4:
                        arreglo_abc[j] = "E";
                        break;
                    case 4.5:
                        arreglo_abc[j] = "e";
                        break;
                    case 5:
                        arreglo_abc[j] = "F";
                        break;
                    case 5.5:
                        arreglo_abc[j] = "f";
                        break;
                }
            }
            menu();
          
        }
        static void eliminarLetra()
        {
            int contador = 0;
            string input;
            Console.WriteLine("cual letra quieres eliminar?");
            input = Console.ReadLine();

            for (int i = 0; i <= puntero; i++) {
                if (arreglo_abc[i] == input)
                {
                    arreglo_numero[i] = -1;
                    arreglo_abc[i] = "";
                    contador++;
                }
            }
            puntero = puntero - contador;

            menu();


        }
        static void creditos()
        {
            Console.WriteLine("MATERIA : ESTRUCTURA DE DATOS");
            Console.WriteLine("INTEGRANTES");
            Console.WriteLine("Sergio Gonzalez Acosta #23170137");
            Console.WriteLine("Erik Fernando Hernandez Ayala #20170131");
            Console.WriteLine("Cesar Fabian Reyes Cortinas #22170039");
            menu();

        }
        
    }
}
