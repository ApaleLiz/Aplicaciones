//Calcular la distancia entre dos puntos, dadas las coodenadas del punto A y el punto B

Console.WriteLine("Calcular la distancia entre dos puntos, dadas las coodenadas del punto A y el punto B\n");
Console.Clear();

            Console.WriteLine("Ingrese las coordenadas del punto A:");
            Console.Write("ax: ");
            double ax = Convert.ToDouble(Console.ReadLine());
            Console.Write("ay: ");
            double ay = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese las coordenadas del punto B:");
            Console.Write("bx: ");
            double bx = Convert.ToDouble(Console.ReadLine());
            Console.Write("by: ");
            double by = Convert.ToDouble(Console.ReadLine());

            double distancia = CalcularDistancia(ax, ay, bx, by);

            Console.WriteLine($"La distancia entre A y B es: {distancia:f2}");

        static double CalcularDistancia(double ax, double ay, double bx, double by)
        {
            double diferenciaX = ax - bx;
            double diferenciaY = ay - by;
            double distancia = Math.Sqrt(Math.Pow(diferenciaX, 2) + Math.Pow(diferenciaY, 2));
            return distancia;
        }
    