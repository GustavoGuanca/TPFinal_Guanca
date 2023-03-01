using System;

namespace TPFinal_Guanca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:

            //             a. El mayor de los números pares.
            //             b. La cantidad de números impares.
            //             c. El menor de los números primos.

            // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.
            Console.Clear();

            int numero = 0;
            int contadorImpares = 0;
            bool banderaPar = false;
            bool banderaPrimo = false;
            int mayorPar = 0;
            int menorPrimo = 0;

            Console.WriteLine("Bienvenido. Por favor, ingrese un número.");
            Console.WriteLine("Si desea salir del programa ingrese el número 0.");
            Console.Write("Numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero == 0)
                Console.Write("Fin del Programa.");

            else
            {

                while (numero != 0)
                {

                    if (numero % 2 == 0) //apartado A
                    {
                        if (banderaPar == false)
                        {
                            mayorPar = numero;
                            banderaPar = true;
                        }
                        else if (numero > mayorPar)
                            mayorPar = numero;

                    }

                    else //apartado B
                        contadorImpares++;



                    if (primo(numero)) //apartado C
                    {
                        if (banderaPrimo == false)
                        {
                            menorPrimo = numero;
                            banderaPrimo = true;
                        }
                        else if (numero < menorPrimo)
                            menorPrimo = numero;
                    }

                    Console.Write("Numero: ");
                    numero = int.Parse(Console.ReadLine());

                }

                Console.WriteLine("El número par mayor es: " + mayorPar);
                Console.WriteLine("La cantidad de números impares es: " + contadorImpares);
                Console.WriteLine("El menor de los números primos es: " + menorPrimo);

                Console.ReadKey();

                Console.WriteLine("Fin del programa.");

            }//fin del primer else 

        }//fin de la función Main

        static bool primo(int a)//funcion del apartado C
        {
            int contador = 0;

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                    contador++;
            }

            if (contador == 2)
                return true;

            else
                return false;
        }
    }
}