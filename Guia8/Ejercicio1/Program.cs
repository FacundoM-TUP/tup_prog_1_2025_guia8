namespace Ejercicio1
{
    internal class Program
    {
        static int Acumulador;
        static int Contador;
        static int Maximo;
        static int Minimo;

        static void InicializarVariables()
        {
            Acumulador = 0;
            Contador = 0;
        }
        static void RegistrarValor(int valor)
        {
            Acumulador = Acumulador + valor;
            if (valor > Maximo || Contador == 0)
            {

            }
            if (valor < Minimo || Contador == 0)
            {

            }

            Contador = Contador + 1;
        }
           
        static void CalcularPromedio()
        {
            double promedio = 0;
        }

        static void MostrarPantallaSolicitarNumero()
        {

        }
        static void MostrarPantallaMaximoYMinimo()
        {
            Console.Clear();
            Console.WriteLine("\t\t Mostrar maximo y minimo. \n\n");

            if (Contador > 0)
            {
                Console.WriteLine($"Máximo: {Maximo}");
                Console.WriteLine($"Minimo: {Minimo}\n\n\n");
            }
            else
            {
                Console.WriteLine("no hubo ingresos todavia\n\n");
            }

            Console.WriteLine("\n\n Presione cualquier tecla para volver al menú principal");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
