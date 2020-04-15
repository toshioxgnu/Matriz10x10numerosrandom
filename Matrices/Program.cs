using System;
using System.Collections.Generic;
using System.Drawing;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int largo = 0;
            string strMatriz1 = ""; 
            string strMatriz2 = "";
            string strRepetidos = "";
            List<int> repetidos = new List<int>();
            int[,] numeros1 = new int[10,10];
            int[,] numeros2= new int[10,10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                for(int  j = 0; j<10; j++)
                {
                    numeros1[i, j] = rnd.Next(0, 50);
                    numeros2[i, j] = rnd.Next(0, 50);
                    
                }
            }
            
            for (int i = 0; i < 10; i++)
            {
                for(int  j = 0; j<10; j++)
                {
                    if (numeros1[i,j] == numeros2[i, j])
                    {
                        repetidos.Add(numeros1[i,j]);
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for(int  j = 0; j<10; j++)
                {
                    strMatriz1 = strMatriz1 + numeros1[i, j].ToString() + " ";
                    strMatriz2 =  strMatriz2 + numeros2[i, j].ToString() + " ";

                }

                strMatriz1 = strMatriz1 + "\n";
                strMatriz2 = strMatriz2 + "\n";
            }

            for (int i = 0; i < repetidos.Count; i++)
            {
                strRepetidos = strRepetidos + repetidos[i].ToString()+ " ";
            }
            
            Console.WriteLine("Matriz 1 : ",Color.Green);
            Console.WriteLine(strMatriz1 , Color.Green);
            Console.WriteLine("Matriz 2 : ",Color.Green);
            Console.WriteLine(strMatriz2,Color.Green);
            Console.WriteLine("Repetidos: ",Color.Green);
            Console.WriteLine(strRepetidos,Color.Green);
        }
    }
}