// See https://aka.ms/new-console-template for more information
double Base;
double altura;
double radio;
int opcion;

do //menu de opciones

{Console.WriteLine("Menú de opciones:");
Console.WriteLine("1. Calcular área de un triángulo");
Console.WriteLine("2. Calcular área de un rectángulo");
Console.WriteLine("3. Calcular área de un círculo");
Console.WriteLine("4. Salir");
Console.Write("Seleccione una opción: ");

if (!int.TryParse(Console.ReadLine(), out opcion))
{
    Console.WriteLine("Por favor, ingrese un número válido.");
    continue;
}

switch (opcion)
    {
        case 1://calcular area de un triangulo
            Console.WriteLine("introduce la base de el triangulo");
            Base = double.Parse(Console.ReadLine());
            Console.WriteLine("introduce la altura");
            altura = double.Parse(Console.ReadLine());

 static double CalcularAreaTriangulo(double Base, double altura)
{
    Console.WriteLine ("la base de un triangulo es:");
    double area = (Base * altura) / 2;
    return area;
    };
double AreaTriangulo = CalcularAreaTriangulo(Base, altura);
Console.WriteLine(AreaTriangulo);
            


        break;


        case 2:// calular el area dee un rectangulo
            Console.WriteLine("introduce la base de el rectangulo");
            Base = double.Parse(Console.ReadLine());
            Console.WriteLine("introduce la altura");
            altura = double.Parse((string)Console.ReadLine());

            static double CalcularAreaRectangulo(double Base, double Altura)
            {
                Console.WriteLine("la base de un rectangulo es:");
                double area = (Base * Altura);
                return area;
            };
            double AreaRectangulo = CalcularAreaTriangulo(Base, altura);
            Console.WriteLine(AreaRectangulo);




            break;


        case 3://calcular el area de un circulo
            Console.WriteLine("introduce el radio");
            radio = double.Parse((string)Console.ReadLine());

            static double CalcularAreaCirculo(double radio)
            {
                Console.WriteLine("El radio de un circulo es:");
                double area = Math.PI * (radio * radio);
                return area;
            };

            double areaCirculo = CalcularAreaCirculo(radio);
         
            Console.WriteLine(areaCirculo);


            break;


        case 4:
        
            Console.WriteLine("Gracias por usar el programa. ¡Adiós!");
            
            break;

        default:
            Console.WriteLine("seleccione una opcion balida");
            break;
    }
    Console.WriteLine(" Presione cualquier tecla para continuar...");
    Console.ReadKey();
    Console.Clear();

} while (true);






