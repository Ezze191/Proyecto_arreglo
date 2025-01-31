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
                case "G": 
                     valor = 6; 
                     break;
                case "g": 
                     valor = 6.5; 
                     break;
                case "H": 
                     valor = 7; 
                     break;
                case "h": 
                     valor = 7.5; 
                     break;
                case "I": 
                     valor = 8; 
                     break;
                case "i": 
                     valor = 8.5; 
                     break;
                case "J": 
                     valor = 9; 
                     break;
                case "j": 
                     valor = 9.5; 
                     break;
                case "K": 
                     valor = 10; 
                     break;
                case "k": 
                     valor = 10.5; 
                    break;
                case "L": 
                     valor = 11; 
                     break;
                case "l": 
                     valor = 11.5; 
                     break;
                case "M": 
                     valor = 12; 
                     break;
                case "m": 
                     valor = 12.5; 
                     break;
                case "N": 
                     valor = 13; 
                     break;
                case "n": 
                     valor = 13.5; 
                     break;
                case "Ñ": 
                     valor = 14; 
                     break;
                case "ñ": 
                     valor = 14.5; 
                     break;
                case "O": 
                     valor = 15; 
                     break;
                case "o": 
                     valor = 15.5; 
                     break;
                case "P": 
                     valor = 16; 
                     break;
                case "p": 
                     valor = 16.5; 
                     break;
                case "Q": 
                     valor = 17; 
                     break;
                case "q": 
                     valor = 17.5; 
                     break;
                case "R": 
                     valor = 18; 
                     break;
                case "r": 
                     valor = 18.5; 
                     break;
                case "S": 
                     valor = 19; 
                     break;
                case "s": 
                     valor = 19.5; 
                     break;
                case "T": 
                     valor = 20; 
                     break;
                case "t": 
                     valor = 20.5; 
                     break;
                case "U": 
                     valor = 21; 
                     break;
                case "u": 
                     valor = 21.5; 
                     break;
                case "V": 
                     valor = 22; 
                     break;
                case "v": 
                     valor = 22.5; 
                     break;
                case "W": 
                     valor = 23; 
                    break;
                case "w": 
                     valor = 23.5; 
                     break;
                case "X": 
                     valor = 24; 
                     break;
                case "x": 
                     valor = 24.5; 
                     break;
                case "Y": 
                     valor = 25; 
                     break;
                case "y": 
                     valor = 25.5; 
                     break;
                case "Z": 
                     valor = 26; 
                     break;
                case "z": 
                     valor = 26.5; 
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
                    case 6: 
                        arreglo_abc[j] = "G"; 
                        break;
                    case 6.5: 
                        arreglo_abc[j] = "g"; 
                        break;
                    case 7: 
                        arreglo_abc[j] = "H"; 
                        break;
                    case 7.5: 
                        arreglo_abc[j] = "h"; 
                        break;
                    case 8: 
                        arreglo_abc[j] = "I"; 
                        break;
                    case 8.5: 
                        arreglo_abc[j] = "i"; 
                        break;
                    case 9: 
                        arreglo_abc[j] = "J"; 
                        break;
                    case 9.5: 
                        arreglo_abc[j] = "j"; 
                        break;
                    case 10: 
                        arreglo_abc[j] = "K"; 
                        break;
                    case 10.5: 
                        arreglo_abc[j] = "k"; 
                        break;
                    case 11: 
                        arreglo_abc[j] = "L"; 
                        break;
                    case 11.5: 
                        arreglo_abc[j] = "l"; 
                        break;
                    case 12: 
                        arreglo_abc[j] = "M"; 
                        break;
                    case 12.5: 
                        arreglo_abc[j] = "m"; 
                        break;
                    case 13: 
                        arreglo_abc[j] = "N";
                         break;
                    case 13.5: 
                        arreglo_abc[j] = "n"; 
                        break;
                    case 14:
                    arreglo_abc[j] = "Ñ";
                    break;
                    case 14.5:
                    arreglo_abc[j] = "ñ";
                    break;
                    case 15:
                        arreglo_abc[j] = "O"; 
                        break;
                    case 15.5: 
                        arreglo_abc[j] = "o"; 
                        break;
                    case 16: 
                        arreglo_abc[j] = "P"; 
                        break;
                    case 16.5: 
                        arreglo_abc[j] = "p"; 
                        break;
                    case 17: 
                        arreglo_abc[j] = "Q"; 
                        break;
                    case 17.5: 
                        arreglo_abc[j] = "q"; 
                        break;
                    case 18: 
                        arreglo_abc[j] = "R"; 
                        break;
                    case 18.5: 
                        arreglo_abc[j] = "r"; 
                        break;
                    case 19: 
                        arreglo_abc[j] = "S"; 
                        break;
                    case 19.5: 
                        arreglo_abc[j] = "s"; 
                        break;
                    case 20: 
                        arreglo_abc[j] = "T"; 
                        break;
                    case 20.5: 
                        arreglo_abc[j] = "t"; 
                        break;
                         case 21: 
                        arreglo_abc[j] =  "U"; 
                     break;
                    case 21.5: 
                      arreglo_abc[j] = "u"; 
                     break;
                case 22: 
                     arreglo_abc[j]  = "V"; 
                     break;
                case  22.5: 
                      arreglo_abc[j]  ="v"; 
                     break;
                case  23: 
                      arreglo_abc[j]  ="W"; 
                    break;
                case 23.5: 
                      arreglo_abc[j] =   "w"; 
                     break;
                case   24: 
                      arreglo_abc[j] = "X"; 
                     break;
                case  24.5: 
                      arreglo_abc[j]  ="x"; 
                     break;
                case  25: 
                      arreglo_abc[j]  =  "Y"; 
                     break;
                case  25.5: 
                      arreglo_abc[j]  = "y" ; 
                     break;
                case 26 : 
                      arreglo_abc[j] = "Z" ; 
                     break;
                case 26.5: 
                      arreglo_abc[j]  = "z" ; 
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
