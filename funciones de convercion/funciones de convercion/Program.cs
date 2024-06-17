// See https://aka.ms/new-console-template for more information
int option;
double temperatura;

do
{
    Console.WriteLine("opcion 1 para pasar de Celsius A Fahrenheit");
    Console.WriteLine("opcion 2 para pasar de `Fahrenheit A Celsius");
    Console.WriteLine("opcion 3 para pasar Celsius A Kelvin ");
    Console.WriteLine("opcion 4 salir");

    if (!int.TryParse(Console.ReadLine(), out option))
    {
        Console.WriteLine("Por favor, ingrese un número válido.");
        continue;
    }

    switch (option)
    {
        case 1: // Celsius A Fahrenheit
            Console.WriteLine("ingrese la temperatura en grados Celsius:");
            temperatura = Convert.ToDouble(Console.ReadLine());

            static double celsiusAFahrenhei(double temperatura)
            {
                Console.WriteLine("la temperatura en grados celsius es equivalente a:");
                double fahrenhei = temperatura * 9 / 5 + 32;
                return fahrenhei;
              
            };

            double fahrenhei = celsiusAFahrenhei(temperatura);

            Console.WriteLine(fahrenhei + "grados fahrenhei.");
           break;

       
        case 2: // Fahrenheit A Celsius
            Console.WriteLine("ingrese la temperatura en grados fahrenhei:");
            temperatura = Convert.ToDouble(Console.ReadLine());

            static double FahrenheitACelsius(double temperatura)
            {
                Console.WriteLine("la temperatura en grados fahrenhei es equivalente a:");
                double celcius = (temperatura - 32) * 5 / 9;
                return celcius;
            };

            double celsius = FahrenheitACelsius(temperatura);
            Console.WriteLine(celsius + "grados celsius.");
            
            break;

            
        case 3: //  Celsius A Kelvin
            Console.WriteLine("ingrese la temperatura en grados celsius:");
            temperatura = Convert.ToDouble(Console.ReadLine());

            static double CelsiusAKelvin(double temperatura)
            {
                Console.WriteLine("la temperatura en grados celsius es equivalente a:");
                double kelvin = temperatura + 273.15;
                return kelvin;
            };

            double kelvin = CelsiusAKelvin(temperatura);
            Console.WriteLine(kelvin + "grados kelvin.");
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
