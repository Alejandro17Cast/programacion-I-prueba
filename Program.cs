// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //PRUEBA PROGRAMACION
        do
        {
            Console.WriteLine("====B I E N V E N I D O S====");
            Console.WriteLine("ELIGA UNA OPCION");
            Console.WriteLine("1. AREA Y PERIMETRO DE TRES FIGURAS");
            Console.WriteLine("2. DISEÑO DE ALGOT");
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
                    switch (opc1)
                    {
                        case 1:
                            Console.WriteLine("HAZ ELEGIDO EL ROMBO");
                            Console.WriteLine("P E R I M E T R O ");
                            Console.WriteLine("INGRESE EL VALOR DEL APOTEMA");
                            double a = double.Parse(Console.ReadLine());
                            double perimetro_rombo = 4 * a;

                            Console.WriteLine("A R E A");
                            Console.WriteLine("INGRESE LA DIAGONAL MAYOR ");
                            double diagonal_mayor = double.Parse(Console.ReadLine());
                            Console.WriteLine("INGRESE LA DIAGONAL MENOR ");
                            double diagonal_menor = double.Parse(Console.ReadLine());
                            double area_rombo = diagonal_mayor * diagonal_menor / 2;

                            Console.WriteLine("R E S U L T A D O S");
                            Console.WriteLine("EL PERIMETRO DEL ROMBO ES: " + perimetro_rombo);
                            Console.WriteLine("EL AREA DEL ROMBO ES: " + area_rombo);

                            break;
                        case 2:
                            Console.WriteLine("HAZ ELEGIDO EL PENTAGONO");
                            Console.WriteLine("P E R I M E T R O ");
                            Console.WriteLine("INGRESE EL VALOR DE LA LONGITUD DE LADO");
                            double L = double.Parse(Console.ReadLine());
                            double perimetro_PENTAGONO = 5 * L;

                            Console.WriteLine("A R E A");
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
                                Console.WriteLine("EL PERIMETRO DEL ROMBO ES: " + perimetro_PENTAGONO);
                                Console.WriteLine("EL AREA DEL ROMBO ES: " + area_PENTAGONO);

                            }
                            else if (respuesta == 1)
                            {
                                Console.WriteLine("EL PERIMETRO A UTILIZAR ES DE: " + perimetro_PENTAGONO);
                                Console.WriteLine("INGRESE EL APOTEMA");
                                double ap = double.Parse(Console.ReadLine());
                                double area_PENTAGONO = perimetro_PENTAGONO * ap / 2;


                                Console.WriteLine("R E S U L T A D O S");
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
                            Console.WriteLine("P E R I M E T R O ");
                            Console.WriteLine("INGRESA LA LONGITUD");
                            double longitud = double.Parse(Console.ReadLine());
                            double perimetro_HEXAGONO = 6 * longitud;
                            Console.WriteLine("A R E A");
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

                default:
                    break;
            }


        } while (true);
    }
}