using System;


public class ejercicio
{
    public static void Main(string[] args)
    {




        Console.WriteLine("EJERCICIO 1");
       for(int i = 1; i<=11; i++)
        {
           
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
                i++;
            }
           
           
        }




        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("EJERCICIO 2");
        int suma = 0;
        for (int j = 0; j<=10; j++)

        {
            suma += j;
           
           
        


        }

        Console.WriteLine($"EL TOTAL DE LA SUMA ES:  " + suma);



        int num1;
        int sumi = 0;


        do
        {
            Console.WriteLine("INGRESE NUMEROS POSITIVOS PARA INCIAR LA SUMA Y UN NEGATIVO PARA PARAR LA SUMA");
            num1 = int.Parse(Console.ReadLine());
            if (num1 >= 0)
            {
                sumi += num1;
            }


        } while (num1 >=0);
        Console.WriteLine($"EL TOTAL DE LA SUMA ES: " + sumi);


       










    } //no borrar
}//no borrar