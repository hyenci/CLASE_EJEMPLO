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

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("EJERCICIO 4: DIVISIBLES ENTRE 7 Y 11");

        int numdiv = 1;
        while (true)
        {
            if (numdiv % 7 == 0 && numdiv % 11 == 0)
            {
                Console.WriteLine($"El primer número entero positivo divisible entre 7 y 11 es: {numdiv}"); break;
            }
            numdiv++;
        }

        Console.WriteLine("");
        Console.WriteLine("EJERCICIO 5: USUARIO Y CONTRASEÑA");

        const string contrasenaCorrecta = "jutiapa";

     
        string contrasenaUsuario;

        do
        {
      
            Console.WriteLine("Introduzca la contraseña: ");
            contrasenaUsuario = Console.ReadLine();

        } while (contrasenaUsuario != contrasenaCorrecta);

        Console.WriteLine("¡Contraseña correcta!");

        Console.WriteLine("EJERCICIO 6: NUMERO ALEATORIO");
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);

  
        int numeroUsuario;

        do
        {
            Console.WriteLine("Introduzca un número entre 1 y 100: ");
            numeroUsuario = int.Parse(Console.ReadLine());

     
            if (numeroUsuario > numeroAleatorio)
            {
                Console.WriteLine("El número es menor que {0}", numeroUsuario);
            }
            else if (numeroUsuario < numeroAleatorio)
            {
                Console.WriteLine("El número es mayor que {0}", numeroUsuario);
            }

        } while (numeroUsuario != numeroAleatorio);

        Console.WriteLine("¡Felicidades! Has adivinado el número correctamente.");



        Console.WriteLine("");
        Console.WriteLine("EJERCICIO 7: ESTUDIANTE APROBADO");
        string nombreEstudiante;
        bool[] asignaturasAprobadas = new bool[5];
        float promedioGeneral;
        bool sancionadoMalComportamiento;

        
        Console.WriteLine("Introduznformación del estudianteca el nombre del estudiante: ");
        nombreEstudiante = Console.ReadLine();

        for (int i = 0; i < asignaturasAprobadas.Length; i++)
        {
            Console.WriteLine("¿{0} aprobó la asignatura {1}? (Si/No): ", nombreEstudiante, i + 1);
            string respuesta = Console.ReadLine().ToLower();
            asignaturasAprobadas[i] = respuesta == "si";
        }

        Console.WriteLine("Introduzca el promedio general del estudiante: ");
        promedioGeneral = float.Parse(Console.ReadLine());

        Console.WriteLine("¿{0} ha sido sancionado por mal comportamiento? (Si/No): ", nombreEstudiante);
        string respuestaSancion = Console.ReadLine().ToLower();
        sancionadoMalComportamiento = respuestaSancion == "si";

      
        bool puedeGraduarse = true;

       
        foreach (bool asignaturaAprobada in asignaturasAprobadas)
        {
            if (!asignaturaAprobada)
            {
                puedeGraduarse = false;
                break;
            }
        }

       
        if (promedioGeneral < 70)
        {
            puedeGraduarse = false;
        }

     
        if (sancionadoMalComportamiento)
        {
            puedeGraduarse = false;
        }

     
        if (puedeGraduarse)
        {
            Console.WriteLine("¡Felicidades {0}, puedes graduarte!", nombreEstudiante);
        }
        else
        {
            Console.WriteLine("Lo sentimos {0}, no puedes graduarte en este momento.", nombreEstudiante);
        }







        Console.WriteLine("");
        Console.WriteLine("EJERCICIO 8: BIBLIOTECA");


        string nombreLibro;
        string generoLibro;
        int edadUsuario;
        bool usuarioPremium;
        int librosPrestadosUsuario;

  
        while (true)
        {
          
            Console.WriteLine("Introduzca el nombre del libro (o 'salir' para terminar): ");
            nombreLibro = Console.ReadLine();

            if (nombreLibro.ToLower() == "salir")
            {
                break;
            }

            Console.WriteLine("Introduzca el género del libro (Ficción / No Ficción / Referencia): ");
            generoLibro = Console.ReadLine();

           
            Console.WriteLine("Introduzca la edad del usuario: ");
            edadUsuario = int.Parse(Console.ReadLine());

            Console.WriteLine("¿El usuario es miembro premium? (Si/No): ");
            string respuestaPremium = Console.ReadLine().ToLower();
            usuarioPremium = respuestaPremium == "si";

            Console.WriteLine("¿Cuántos libros tiene prestados el usuario actualmente? ");
            librosPrestadosUsuario = int.Parse(Console.ReadLine());

       
            bool puedePrestarse = false;

          
            if (generoLibro == "Ficción" && librosPrestadosUsuario < 3)
            {
                puedePrestarse = true;
            }

           
            if (generoLibro == "No Ficción" && edadUsuario >= 18 && librosPrestadosUsuario < 3)
            {
                puedePrestarse = true;
            }

       
            if (generoLibro == "Referencia" && usuarioPremium && librosPrestadosUsuario < 3)
            {
                puedePrestarse = true;
            }

            if (puedePrestarse)
            {
                Console.WriteLine("¡Felicidades! El libro '{0}' puede ser prestado.", nombreLibro);
            }
            else
            {
                Console.WriteLine("Lo sentimos, el libro '{0}' no puede ser prestado en este momento.", nombreLibro);
            }

          
            Console.WriteLine("¿Desea consultar otro libro? (Si/No): ");
            string respuestaContinuar = Console.ReadLine().ToLower();

          
            if (respuestaContinuar != "si")
            {
                break;
            }
        }




















    } //no borrar
}//no borrar