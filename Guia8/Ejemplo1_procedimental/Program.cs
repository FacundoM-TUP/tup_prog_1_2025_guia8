namespace Ejemplo1_procedimental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region declarar variable
            int contador, acumulador;
            int cantidad;
            #endregion

            #region iniciar contador y acumulador
            contador = 0;
            acumulador = 0;
            #endregion

            #region solicitar de cantidad de ingresos
            Console.WriteLine("Ingrese la cantidad de ingresos a procesar");
            cantidad = Convert.ToInt32(Console.ReadLine());
            #endregion


        }
    }
}
