// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    // Función para calcular el factorial
    static long Factorial(int n)
    {
        if (n == 0)
            return 1;
        long result = 1;
        for (int i = 1; i <= n; i++)
            result *= i;
        return result;
    }

    // Función para calcular combinaciones nCr
    static long Combinatoria(int n, int r)
    {
        return Factorial(n) / (Factorial(r) * Factorial(n - r));
    }

    // Función para calcular permutaciones nPr
    static long Permutacion(int n, int r)
    {
        return Factorial(n) / Factorial(n - r);
    }

    // Función principal
    static void Main(string[] args)
    {//alianza el mejor equipo//
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\t________________________________________");
        Console.WriteLine("\tOptimización de Distribución de Recursos");
        Console.WriteLine("\t________________________________________");
        Console.WriteLine();


        // Entrada de datos para las campañas de concientización y capacitación
        Console.WriteLine("******************************************");
        Console.WriteLine("Campañas de concientización y capacitación");
        Console.WriteLine("******************************************");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Para hallar las maneras en las que se pueden organizar los capacitadores:");

        Console.WriteLine("Ingrese el número total de capacitadores->");
        int totalCapacitadores = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el tamaño del grupo de capacitadores-> ");
        int grupoCapacitadores = int.Parse(Console.ReadLine());

        long manerasCapacitadores = Combinatoria(totalCapacitadores, grupoCapacitadores);
        Console.WriteLine($"Maneras de organizar {totalCapacitadores} capacitadores en grupos de {grupoCapacitadores}: {manerasCapacitadores}");
        Console.ReadKey();

        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine();
        Console.WriteLine("******************************************");
        Console.WriteLine("    Monitoreo y priorización de áreas");
        Console.WriteLine("******************************************");
        Console.WriteLine("");
        Console.WriteLine("Para hallar las formas de priorizar las áreas a monitorear según su prioridad:");
        Console.ForegroundColor = ConsoleColor.Cyan;

        // Entrada de datos para el sistema básico de monitoreo y priorización de áreas
        Console.WriteLine("Ingrese el número total de áreas->");
        int totalAreas = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el número de áreas a monitorear->");
        int areasMonitorear = int.Parse(Console.ReadLine());

        long manerasMonitorear = Permutacion(totalAreas, areasMonitorear);
        Console.WriteLine($"Formas de priorizar {areasMonitorear} áreas de {totalAreas} para el monitoreo: {manerasMonitorear}");
        Console.ReadKey();

        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine();
        Console.WriteLine("******************************************");
        Console.WriteLine("       Disponibilidad de equipos");
        Console.WriteLine("******************************************");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Para hallar las maneras de distribuir los equipos:");
        // Entrada de datos para la disponibilidad de equipos
        Console.WriteLine("Ingrese el número total de equipos->");
        int totalEquipos = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el número de equipos por centro->");
        int equiposPorCentro = int.Parse(Console.ReadLine());

        long manerasEquipos = Combinatoria(totalEquipos, equiposPorCentro);
        Console.WriteLine($"Maneras de distribuir {totalEquipos} equipos en grupos de {equiposPorCentro}: {manerasEquipos}");
        Console.ReadKey();
    }
}
