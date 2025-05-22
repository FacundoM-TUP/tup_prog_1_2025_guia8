namespace Ejemplo1_procedimental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region declarar variable
            int acumulador;
            int cantidad;
            int valor;
            int maximo = 0, minimo = 0;
            double promedio = 0;
            #endregion

            #region iniciar contador y acumulador
            acumulador = 0;
            #endregion

            #region solicitar cantidad de ingresos
            Console.WriteLine("Ingrese la cantidad de numeros a procesar");
            cantidad = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region iterar
            for (int n = 0; n < cantidad; n++)
            {
                #region solicitar valor
                Console.WriteLine($"ingrese el valor numero {n+1}");
                valor = Convert.ToInt32(Console.ReadLine());
                #endregion

                #region acumular valor
                //acumulador = acumulador + valor;
                acumulador += valor;
                #endregion

                #region verifico valor es maximo o primer valor
                if (valor > maximo || n == 0)
                {
                    maximo = valor;
                }
                #endregion

                #region verifico valor es minimo o primer valor
                if (valor < minimo || n == 0)
                {
                    minimo = valor;
                }
                #endregion
            }
            #endregion

            #region calcular promedio
            if (cantidad > 0)
            {
                promedio = 1d * acumulador / cantidad;
            }
            #endregion

            #region mostrar resultados
            Console.WriteLine($"valor maximo: {maximo}");
            Console.WriteLine($"valor minimo: {minimo}");
            Console.WriteLine($"promedio: {promedio}");
            #endregion
        }
    }
}
