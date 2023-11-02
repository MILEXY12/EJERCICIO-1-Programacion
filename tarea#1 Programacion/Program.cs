
//Ejercicio 1



class Program
{
    static void Main()
    {
        // Crear un objeto de la clase Random para generar números aleatorios
        Random random = new Random();

        // Generar un número aleatorio entre 1 y 7 (inclusive)
        int numeroAleatorio = random.Next(1, 8);

        // Imprimir el número aleatorio
        Console.WriteLine("Número aleatorio: " + numeroAleatorio);

        // Asociar el número con el nombre del día de la semana usando switch
        string nombreDiaSemana = ObtenerNombreDiaSemana(numeroAleatorio);

        // Imprimir el nombre del día de la semana
        Console.WriteLine("Día de la semana: " + nombreDiaSemana);
    }

    static string ObtenerNombreDiaSemana(int numero)
    {
        string nombreDia = "";
        switch (numero)
        {
            case 1:
                nombreDia = "Lunes";
                break;
            case 2:
                nombreDia = "Martes";
                break;
            case 3:
                nombreDia = "Miércoles";
                break;
            case 4:
                nombreDia = "Jueves";
                break;
            case 5:
                nombreDia = "Viernes";
                break;
            case 6:
                nombreDia = "Sábado";
                break;
            case 7:
                nombreDia = "Domingo";
                break;
            default:
                nombreDia = "Número fuera de rango";
                break;
        }
        return nombreDia;
    }
}


