using System;
using System.Threading;

namespace PII_Game_Of_Life
{

namespace ConwaysGameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la ruta del archivo del tablero: ");
            string rutaArchivo = Console.ReadLine();

            bool[,] board = ImportTablero.CargarTableroDesdeArchivo(rutaArchivo);
            int width = board.GetLength(0);
            int height = board.GetLength(1);

            LogicaJuego logica = new LogicaJuego();
            PrintTablero print = new PrintTablero();

            while (true)
            {
                Console.Clear();
                PrintTablero.Imprimir(board);
                Thread.Sleep(300);
                board = logica.CalcularSiguienteGeneracion(board);
            }
        }
    }
}
}
