﻿//Un alumno curso el semestre en la Universidad, y obtuvo un promedio, hay que emitir una calificación con letra y un
//mensaje de acuerdo al promedio

string respuesta;

    do{
        Console.Clear();
        Console.Write("Nombre del estudiante: ");
            string nombre = Console.ReadLine();
                double promedio;
        do{
            Console.Write("Promedio del estudiante (entre 0 y 10): ");
            promedio = Convert.ToDouble(Console.ReadLine());

                if (promedio < 0 || promedio > 10){
                        Console.WriteLine("El promedio debe estar entre 0 y 10. Por favor, ingrese un valor válido.");
                    }
                } while (promedio < 0 || promedio > 10);
        string calificacion = CalcularCalificacion(promedio);
        string mensaje = ObtenerMensaje(calificacion);
        Console.WriteLine($"Calificación de {nombre}: {calificacion} - {mensaje}");
        Console.Write("¿Desea ingresar otro estudiante? (S/N): ");
            respuesta = Console.ReadLine();
            } while (respuesta.ToUpper() == "S");

        static string CalcularCalificacion(double promedio)
        {
            if (promedio >= 0 && promedio <= 5.9)
            {
                return "D";
            }
            else if (promedio <= 7.5)
            {
                return "C";
            }
            else if (promedio <= 8.5)
            {
                return "B";
            }
            else
            {
                return "A";
            }
        }

        static string ObtenerMensaje(string calificacion)
        {
            switch (calificacion)
            {
                case "D":
                    return "Andas mal";
                case "C":
                    return "Mucho mejor";
                case "B":
                    return "Muy bien";
                case "A":
                    return "Excelente";
                default:
                    return "Mensaje no disponible";
            }
        }