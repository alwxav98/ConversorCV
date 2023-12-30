// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Universidad Central del Ecuador");
        Console.WriteLine("Facultad de Ingeniería y Ciencias Aplicadas");
        Console.WriteLine("Sistemas de Información");
        Console.WriteLine("Marcos de Desarrollo II");
        Console.WriteLine("");
        Console.WriteLine("Control de versiones");
        Console.WriteLine("Tanya Alexandra Vaca Mena");
        Console.WriteLine("SIS6-002");
        Console.WriteLine("");
        Console.WriteLine("Bienvenido al Conversor de Unidades");
        Console.WriteLine("Seleccione la categoría de conversión:");
        Console.WriteLine("1. Temperatura");
        Console.WriteLine("2. Masa");
        Console.WriteLine("3. Energía");
        Console.WriteLine("0. Salir");

        int opcionCategoria = PedirNumero("Ingrese el número de la categoría: ");

        while (opcionCategoria != 0)
        {
            switch (opcionCategoria)
            {
                case 1:
                    ConvertirTemperatura();
                    break;
                case 2:
                    ConvertirMasa();
                    break;
                case 3:
                    ConvertirEnergia();
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una categoría válida.");
                    break;
            }

            Console.WriteLine("\nSeleccione la categoría de conversión:");
            Console.WriteLine("1. Temperatura");
            Console.WriteLine("2. Masa");
            Console.WriteLine("3. Energía");
            Console.WriteLine("0. Salir");

            opcionCategoria = PedirNumero("Ingrese el número de la categoría: ");
        }

        Console.WriteLine("Gracias por usar el Conversor de Unidades. ¡Hasta luego!");
    }

    static void ConvertirTemperatura()
    {
        Console.WriteLine("\nConversión de Temperatura");
        double temperaturaCelsius = PedirNumero("Ingrese la temperatura en grados Celsius: ");

        double temperaturaFahrenheit = CelsiusAFahrenheit(temperaturaCelsius);
        double temperaturaKelvin = CelsiusAKelvin(temperaturaCelsius);

        MostrarResultado("Fahrenheit", temperaturaFahrenheit);
        MostrarResultado("Kelvin", temperaturaKelvin);
    }

    static void ConvertirMasa()
    {
        Console.WriteLine("\nConversión de Masa");
        double masaGramos = PedirNumero("Ingrese la masa en gramos: ");

        double masaKilogramos = GramosAKilogramos(masaGramos);
        double masaLibras = GramosALibras(masaGramos);

        MostrarResultado("Kilogramos", masaKilogramos);
        MostrarResultado("Libras", masaLibras);
    }

    static void ConvertirEnergia()
    {
        Console.WriteLine("\nConversión de Energía");
        double energiaJoules = PedirNumero("Ingrese la energía en julios: ");

        double energiaCalorias = JoulesACalorias(energiaJoules);
        double energiaKilovatiosHora = JoulesAKilovatiosHora(energiaJoules);

        MostrarResultado("Calorías", energiaCalorias);
        MostrarResultado("Kilovatios-hora", energiaKilovatiosHora);
    }

    // Funciones de conversión específicas
    static double CelsiusAFahrenheit(double celsius) => celsius * 9 / 5 + 32;
    static double CelsiusAKelvin(double celsius) => celsius + 273.15;

    static double GramosAKilogramos(double gramos) => gramos / 1000;
    static double GramosALibras(double gramos) => gramos * 0.00220462;

    static double JoulesACalorias(double joules) => joules * 0.000239006;
    static double JoulesAKilovatiosHora(double joules) => joules / 3600000;

    // Funciones auxiliares
    static int PedirNumero(string mensaje)
    {
        Console.Write(mensaje);
        string input = Console.ReadLine();

        if (int.TryParse(input, out int numero))
            return numero;
        else
            return PedirNumero("Por favor, ingrese un número válido: ");
    }

    static void MostrarResultado(string unidad, double valor)
    {
        Console.WriteLine($"Resultado en {unidad}: {valor:F2}");
    }
}

