
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Emit;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //PRUEBA PROGRAMACION
      bool salida=false;


        do
        {
            Console.WriteLine("====B I E N V E N I D O S====");
            Console.WriteLine("ELIGA UNA OPCION");
            Console.WriteLine("1. AREA Y PERIMETRO DE TRES FIGURAS");
            Console.WriteLine("2. DISEÑO DE ALGORITMOS");
            Console.WriteLine("3. SALIR");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.WriteLine("CALCULAR EL AREA Y PERIMETRO DE FIGURAS");
                    Console.WriteLine("ELIGA LA FIGURA QUE DESEE");
                    Console.WriteLine("1. ROMBO");
                    Console.WriteLine("2. PENTAGONO ");
                    Console.WriteLine("3. HEXAGONO");
                    int opc1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("");
                    switch (opc1)
                    {
                        case 1:
                            Console.WriteLine("HAZ ELEGIDO EL ROMBO");
                            Console.WriteLine("");
                            Console.WriteLine("P E R I M E T R O ");

                            Console.WriteLine("");
                            Console.WriteLine("INGRESE EL VALOR DEL APOTEMA");
                            double a = double.Parse(Console.ReadLine());
                            double perimetro_rombo = 4 * a;

                            Console.WriteLine("A R E A");

                            Console.WriteLine("");
                            Console.WriteLine("INGRESE LA DIAGONAL MAYOR ");
                            double diagonal_mayor = double.Parse(Console.ReadLine());
                            Console.WriteLine("INGRESE LA DIAGONAL MENOR ");
                            double diagonal_menor = double.Parse(Console.ReadLine());
                            double area_rombo = diagonal_mayor * diagonal_menor / 2;

                            Console.WriteLine("R E S U L T A D O S");

                            Console.WriteLine("");
                            Console.WriteLine("EL PERIMETRO DEL ROMBO ES: " + perimetro_rombo);
                            Console.WriteLine("EL AREA DEL ROMBO ES: " + area_rombo);

                            break;
                        case 2:
                            Console.WriteLine("HAZ ELEGIDO EL PENTAGONO");
                            Console.WriteLine("P E R I M E T R O ");

                            Console.WriteLine("");
                            Console.WriteLine("INGRESE EL VALOR DE LA LONGITUD DE LADO");
                            double L = double.Parse(Console.ReadLine());
                            double perimetro_PENTAGONO = 5 * L;

                            Console.WriteLine("A R E A");

                            Console.WriteLine("");
                            Console.WriteLine("INGRESE EL PERIMETRO DEL PENTAGONO");
                            Console.WriteLine("¿DESEA USAR EL PERIMETRO ANTERIOR?");
                            Console.WriteLine("1. Si");
                            Console.WriteLine("2. No");
                            int respuesta = int.Parse(Console.ReadLine());
                            if (respuesta == 2)
                            {
                                Console.WriteLine("INGRESE EL PERIMETRO POR UTILIZAR");
                                double perimetro_PENTAGONO1 = double.Parse(Console.ReadLine());
                                Console.WriteLine("INGRESE EL APOTEMA");
                                double ap = double.Parse(Console.ReadLine());
                                double area_PENTAGONO = (perimetro_PENTAGONO1 * ap) / 2;

                                Console.WriteLine("R E S U L T A D O S");

                                Console.WriteLine("");
                                Console.WriteLine("EL PERIMETRO DEL ROMBO ES: " + perimetro_PENTAGONO);
                                Console.WriteLine("EL AREA DEL ROMBO ES: " + area_PENTAGONO);

                            }
                            else if (respuesta == 1)
                            {
                                Console.WriteLine("EL PERIMETRO A UTILIZAR ES DE: " + perimetro_PENTAGONO);
                                Console.WriteLine("INGRESE EL APOTEMA");
                                double ap = double.Parse(Console.ReadLine());
                                double area_PENTAGONO = (perimetro_PENTAGONO * ap) / 2;


                                Console.WriteLine("R E S U L T A D O S");

                                Console.WriteLine("");
                                Console.WriteLine("EL PERIMETRO DEL PENTAGONO ES: " + perimetro_PENTAGONO);
                                Console.WriteLine("EL AREA DEL PENTAGONO ES: " + area_PENTAGONO);
                            }
                            else
                            {
                                Console.WriteLine("Respuesta no valida");
                            }

                            break;
                        case 3:
                            Console.WriteLine("HAZ ELEGIDO EL HEXAGONO");

                            Console.WriteLine("");
                            Console.WriteLine("P E R I M E T R O ");

                            Console.WriteLine("");
                            Console.WriteLine("INGRESA LA LONGITUD");
                            double longitud = double.Parse(Console.ReadLine());
                            double perimetro_HEXAGONO = 6 * longitud;
                            Console.WriteLine("A R E A");

                            Console.WriteLine("");
                            Console.WriteLine("INGRESE EL PERIMETRO DEL PENTAGONO");
                            Console.WriteLine("¿DESEA USAR EL PERIMETRO ANTERIOR?");
                            Console.WriteLine("1. Si");
                            Console.WriteLine("2. No");
                            int respuesta1 = int.Parse(Console.ReadLine());
                            if (respuesta1 == 2)
                            {
                                Console.WriteLine("INGRESE EL PERIMETRO POR UTILIZAR");
                                double perimetro_HEXAGONO1 = double.Parse(Console.ReadLine());
                                Console.WriteLine("INGRESE EL APOTEMA");
                                double aph = double.Parse(Console.ReadLine());
                                double area_HEXAGONO = perimetro_HEXAGONO1 * aph / 2;

                                Console.WriteLine("R E S U L T A D O S");

                                Console.WriteLine("");
                                Console.WriteLine("EL PERIMETRO DEL HEXAGONO ES: " + perimetro_HEXAGONO);
                                Console.WriteLine("EL AREA DEL HEXAGONO ES: " + area_HEXAGONO);

                            }
                            else if (respuesta1 == 1)
                            {
                                Console.WriteLine("EL PERIMETRO A UTILIZAR ES DE: " + perimetro_HEXAGONO);
                                Console.WriteLine("INGRESE EL APOTEMA");
                                double aph = double.Parse(Console.ReadLine());
                                double area_HEXAGONO = perimetro_HEXAGONO * aph / 2;


                                Console.WriteLine("R E S U L T A D O S");

                                Console.WriteLine("");
                                Console.WriteLine("EL PERIMETRO DEL HEXAGONO ES: " + perimetro_HEXAGONO);
                                Console.WriteLine("EL AREA DEL HEXAGONO ES: " + area_HEXAGONO);
                            }
                            else
                            {
                                Console.WriteLine("Respuesta no valida");
                            }

                            break;

                        default:
                            Console.WriteLine("OPCION INCORRECTA");
                            break;
                    }

                    break;

                case 2:
                    Console.WriteLine("===HAZ ELEGIDO EL DISEÑO DE ALGORITMOS===");

                    Console.WriteLine("");
                    Console.WriteLine("1. CALCULAR EDAD");
                    Console.WriteLine("2. AUMENTO DEL 5% O 10%");
                    Console.WriteLine("3. PROMEDIO");
                    Console.WriteLine("4. AUMENTO DEL 20%-25% Y 18%");
                    int opc2 = int.Parse(Console.ReadLine());
                    switch (opc2)
                    {
                        case 1:
                            Console.WriteLine("====HAZ ELEGIDO CALCULAR LA EDAD===");
                            Console.WriteLine("");
                            Console.WriteLine("INGRESE SU NOMBRE");
                            String nombre = Console.ReadLine();
                            Console.WriteLine("");
                            Console.WriteLine("DIGITE SU AÑO DE NACIMIENTO");
                            int año = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            int edad = 2024 - año;
                            Console.WriteLine("");
                            Console.WriteLine(nombre + " tiene: " + edad + " años");
                            break;
                        case 2:
                            Console.WriteLine("====HAZ ELEGIDO EL AUMENDO DE 5%-10%");
                            Console.WriteLine("");
                            Console.WriteLine("¿CUANTOS TRABAJADORES DESEA AGREGAR?");
                            int cantidad = int.Parse(Console.ReadLine());
                            String[] trabajadores = new String[cantidad];
                            for (int i = 0; i < trabajadores.Length; i++)
                            {
                                Console.WriteLine("INGRESA EL NOMBRE DEL TRABAJADOR " + (i + 1));
                                trabajadores[i] = Console.ReadLine();
                                Console.WriteLine("DIGITE LA EDAD DE: " + trabajadores[i]);
                                int edadt = int.Parse(Console.ReadLine());
                                Console.WriteLine("INGRESE EL SALARIO DE: " + trabajadores[i]);
                                double salario = double.Parse(Console.ReadLine());
                                Console.WriteLine("");

                                if (salario >= 2000)
                                {
                                    double aumento = salario * 0.5;
                                    Console.WriteLine("EL TRABJADOR " + trabajadores[i] + " tendra un aumento del 5% ");
                                    Console.WriteLine("SU SALARIO ACTUAL ES: " + salario);
                                    Console.WriteLine("EL AUMENTO ES DE: " + aumento);
                                    Console.WriteLine("");
                                    Console.WriteLine("SALARIO TOTAL: " + (salario + aumento));
                                    Console.WriteLine("");
                                }
                                else if (salario < 2000)
                                {
                                    double aumento = salario * 0.10;
                                    Console.WriteLine("EL TRABJADOR " + trabajadores[i] + " tendra un aumento del 10% ");
                                    Console.WriteLine("SU SALARIO ACTUAL ES: " + salario);
                                    Console.WriteLine("EL AUMENTO ES DE: " + aumento);
                                    Console.WriteLine("");
                                    Console.WriteLine("SALARIO TOTAL: " + (salario + aumento));
                                    Console.WriteLine("");
                                }


                            }

                            break;
                        case 3:

                            Console.WriteLine("====HAZ ELEGIDO PROMEDIO====");
                            Console.WriteLine("");
                            double[] notas = new double[5];
                            double suma = 0;

                            for (int i = 0; i < notas.Length; i++)
                            {
                                double nota;
                                do
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("INGRESE LA NOTA " + (i + 1));
                                    nota = double.Parse(Console.ReadLine());

                                    if (nota < 0 || nota > 100)
                                    {
                                        Console.WriteLine("INGRESE UNA NOTA VALIDA (0-100)");
                                    }

                                } while (nota < 0 || nota > 100);

                                notas[i] = nota;
                                suma += nota;
                            }

                            double promedio = suma / notas.Length;

                            if (promedio >= 90 && promedio <= 100)
                            {
                                Console.WriteLine("El promedio del estudiante es A con un promedio de: " + promedio);
                            }
                            else if (promedio >= 80 && promedio <= 89)
                            {
                                Console.WriteLine("El promedio del estudiante es B con un promedio de: " + promedio);
                            }
                            else if (promedio >= 70 && promedio <= 79)
                            {
                                Console.WriteLine("El promedio del estudiante es C con un promedio de: " + promedio);
                            }
                            else if (promedio >= 60 && promedio <= 69)
                            {
                                Console.WriteLine("El promedio del estudiante es D con un promedio de: " + promedio);
                            }
                            else if (promedio >= 0 && promedio <= 59)
                            {
                                Console.WriteLine("El promedio del estudiante es E con un promedio de: " + promedio);
                            }

                            break;

                        case 4:

                            //SALARIO DE UN TRABAJADOR 

                            Console.WriteLine("AUMENTO DE SALARIO");
                            Console.WriteLine("INGRESE SU SALARIO ");
                            double salario1 = double.Parse(Console.ReadLine());

                            if (salario1 < 1000 && salario1 > 900)
                            {
                                Console.WriteLine("Su salario actual es de: " + salario1);
                                Console.WriteLine("Tendra un aumento del 20% ");
                                double aumento = salario1 * 0.20;
                                Console.WriteLine("Su nuevo salario es de: " + (salario1 + aumento));
                            }
                            else if (salario1 <= 900)
                            {
                                Console.WriteLine("Su salario actual es de: " + salario1);
                                Console.WriteLine("Tendra un aumento del 25% ");
                                double aumento = salario1 * 0.25;
                                Console.WriteLine("Su nuevo salario es de: " + (salario1 + aumento));
                            }
                            else if (salario1 > 2000)
                            {
                                Console.WriteLine("Su salario actual es de: " + salario1);
                                Console.WriteLine("Tendra un aumento del 18% ");
                                double aumento = salario1 * 0.18;
                                Console.WriteLine("Su nuevo salario es de: " + (salario1 + aumento));
                            }


                            break;
                        default:
                        Console.WriteLine("OPCION NO VALIDA");
                            break;
                    }

                    break;

                    case 3:
                    salida=true; 
                    break;
                default:
                Console.WriteLine("OPCION NO VALIDA");
                    break;
            }
            
            

        } while (salida==false);
    }
}