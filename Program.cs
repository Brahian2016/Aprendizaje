using System;
using System.Collections;

namespace Aprendizaje
{
    class Program
    {
        static int opcion = 0;
        static void Main(string[] args)
        {

            while (opcion != 7)
            {
                Menu();

                switch (opcion)
                {
                    case 1:
                        Ejercicio1();
                        Console.WriteLine("\n Presionar cualquier tecla para continuar!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Ejercicio2();
                        Console.WriteLine("\n Presionar cualquier tecla para continuar!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Ejercicio3();
                        Console.WriteLine("\n Presionar cualquier tecla para continuar!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Ejercicio4();
                        Console.WriteLine("\n Presionar cualquier tecla para continuar!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Ejercicio5();
                        Console.WriteLine("\n Presionar cualquier tecla para continuar!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Ejercicio6();
                        Console.WriteLine("\n Presionar cualquier tecla para continuar!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7:
                        Environment.Exit(1);
                        break;
                }
            }

           
        }

        static void Ejercicio1()
        {
            int A = 0;
            int B = 0;
            int C = 0;
            Console.Clear();
            Console.WriteLine("Ingrese el valor del valor A");
            A = int.Parse(Console.ReadLine());

            bool flag = false;
            while (!flag)
            {
                Console.WriteLine("Ingrese el valor del valor B");
                B = int.Parse(Console.ReadLine());

                if (B == A)
                {
                    Console.WriteLine("Este valor es similar al valor A , por favor ingresar un valor distinto\n");
                }
                else
                {
                    flag = true;
                }
            }

            flag = false;
            while (!flag)
            {
                Console.WriteLine("Ingrese el valor del valor C");
                C = int.Parse(Console.ReadLine());

                if (C == A)
                {
                    Console.WriteLine("Este valor es similar al valor A , por favor ingresar un valor distinto\n");
                }
                else if (C == B)
                {
                    Console.WriteLine("Este valor es similar al valor B , por favor ingresar un valor distinto\n");
                }
                else
                {
                    flag = true;
                }
            }


            if (A > B)
            {
                if (B > C)
                {
                    Console.WriteLine("Mayor: A con: " + A);
                    Console.WriteLine("Menor: C con: " + C);
                }
                else
                {
                    Console.WriteLine("Mayor: A con: " + A);
                    Console.WriteLine("Menor: B con: " + B);
                }
            }
            else if (B > C)
            {
                if (A > C)
                {
                    Console.WriteLine("Mayor: B con: " + B);
                    Console.WriteLine("Menor: C con: " + C);
                }
                else
                {
                    Console.WriteLine("Mayor: B con: " + B);
                    Console.WriteLine("Menor: B con: " + C);
                }
            }
            else
            {
                if (A > B)
                {
                    Console.WriteLine("Mayor: A con: " + A);
                    Console.WriteLine("Menor: B con: " + B);
                }
                else
                {
                    Console.WriteLine("Mayor: C con: " + C);
                    Console.WriteLine("Menor: A con: " + A);

                }

            }

        }

        static void Ejercicio2()
        {

           

            // Evaluar si un número es primo o no
            int cont = 0;
            int suma = 0;

            Console.WriteLine("Por favor ingrese el número a evaludar");
            int NumEvaluar = int.Parse(Console.ReadLine());

            for (int i = 1; i <= NumEvaluar; i++)
            {
                if (NumEvaluar%i==0)
                {
                    cont++;
                }

                int contAux = 0;
                for (int k = 1; k <= i; k++)
                {
                    if (i % k == 0)
                    {
                        contAux++;
                    }

                    if (k == i)
                    {
                        if (contAux == 2)
                        {
                            if (i != NumEvaluar)
                            {
                                suma = suma + i;
                                // Console.WriteLine("\nNúmero iteración" + i);
                            }
                }
                    }
                }
                
            }

            if (cont == 2)
            {
                Console.WriteLine("\nEl número ingresado es primo");
            }
            else
            {
                Console.WriteLine("\nEl número ingresado NO es primo");
            }
            // Cierre evaluación



            Console.WriteLine("La suma de los primos anteriores es: "+suma);

        }

        static void Ejercicio3()
        {
            float HardDisk;
            float cantCDs;

            Console.WriteLine("Por favor ingresar el tamaño del disco duro en GB");
            HardDisk = float.Parse(Console.ReadLine());
            
            cantCDs = (HardDisk * 1024) / 700;

            Console.WriteLine("La cantidad de CD's virgenes necesarios para almacenar {0} GB, son {1} CD's virgenes",HardDisk,Math.Ceiling(cantCDs));
        }

        static void Ejercicio4() {

            float peopleAmount;
            float ricePrice;
            float chickenPrice;
            float riceUsed;
            float chickenUsed;

            Console.WriteLine("Insert the people amount");
            peopleAmount = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert the rice price");
            ricePrice = float.Parse(Console.ReadLine());

            Console.WriteLine("Insert the chicken price");
            chickenPrice = float.Parse(Console.ReadLine());

            riceUsed = ((peopleAmount / 4)*500)/1000;
            chickenUsed = ((peopleAmount / 4)*250)/1000;


            Console.WriteLine("Rice Price: {0}",ricePrice * Math.Round(riceUsed,1));
            Console.WriteLine("Chicken Price: {0}",chickenPrice * Math.Round(chickenUsed, 1));

        }

        static void Ejercicio5()
        {
            Console.WriteLine("Por favor ingrese la cantidad de horas trabajadas");
            int hoursAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingresar el valor de cada hora");
            float hourPrice = float.Parse(Console.ReadLine());

            double salary;

            if (hoursAmount <= 40)
            {
                salary = hourPrice * hoursAmount;
            }
            else
            {
                salary = ((hoursAmount - 40) * hourPrice*1.5)+(40*hourPrice);
            }

            Console.WriteLine("Se informa que el salario es: "+salary);
        }

        static void Ejercicio6()
        {
            double sueldo;
            double descuento = 0;

            Console.WriteLine("Por favor ingrese el sueldo del trabajador");
            sueldo = double.Parse(Console.ReadLine());

            if (sueldo <= 1000)
            {
                descuento = sueldo * 0.1;

            } else if (sueldo > 1000 && sueldo <= 2000)
            {
                descuento = sueldo * 0.03;
            } else if (sueldo > 2000) {
                descuento = sueldo * 0.05;
            }
            else
            {
                Console.WriteLine("El sueldo no puede ser 0 o menor a 0");
            }

            Console.WriteLine("El sueldo neto del trabajador es: {0} y el descuento es: {1}",sueldo-descuento,descuento);
        }
        static void Menu()
        {
            Console.WriteLine("¿Cuál algoritmo desea ejecutar? \n");

            Console.WriteLine("1: Ejercicio 1");
            Console.WriteLine("2: Ejercicio 2");
            Console.WriteLine("3: Ejercicio 3");
            Console.WriteLine("4: Ejercicio 4");
            Console.WriteLine("5: Ejercicio 5");
            Console.WriteLine("6: Ejercicio 6");
            Console.WriteLine("7: Cerrar");

            opcion = int.Parse(Console.ReadLine());
        }



    }




}
