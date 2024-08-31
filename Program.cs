// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

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
                    double perimetro_rombo = (4 * a);

                    Console.WriteLine("A R E A");
                    Console.WriteLine("INGRESE LA DIAGONAL MAYOR ");
                    double diagonal_mayor = double.Parse(Console.ReadLine());
                    Console.WriteLine("INGRESE LA DIAGONAL MENOR ");
                    double diagonal_menor = double.Parse(Console.ReadLine());
                    double area_rombo = (diagonal_mayor * diagonal_menor) / 2;

                    Console.WriteLine("EL PERIMETRO DEL ROMBO ES: " + perimetro_rombo);
                    Console.WriteLine("EL AREA DEL ROMBO ES: " + area_rombo);

                    break;
                    case 2:
                    Console.WriteLine("HAZ ELEGIDO EL PENTAGONO");
                    Console.WriteLine("P E R I M E T R O ");
                    Console.WriteLine("INGRESE EL VALOR DE LA LONGITUD DE LADO");
                    double L = double.Parse(Console.ReadLine());
                    double perimetro_PENTAGONO = (5 * L);

                    Console.WriteLine("A R E A");
                    Console.WriteLine("INGRESE EL PERIMETRO DEL PENTAGONO");
                    Console.WriteLine("¿DESEA USAR EL PERIMETRO ANTERIOR?");
                    Consoe.WriteLine("1. Si");
                    Console.WriteLine("2. No");
                    r
                    double diagonal_mayor = double.Parse(Console.ReadLine());
                    Console.WriteLine("INGRESE LA DIAGONAL MENOR ");
                    double diagonal_menor = double.Parse(Console.ReadLine());
                    double area_rombo = (diagonal_mayor * diagonal_menor) / 2;

                    Console.WriteLine("EL PERIMETRO DEL ROMBO ES: " + perimetro_rombo);
                    Console.WriteLine("EL AREA DEL ROMBO ES: " + area_rombo);

                    break; 

                default:
                    break;
            }

            break;

        default:
            break;
    }


} while (true);
