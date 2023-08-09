using System;
using System.IO;
using System.Threading;

namespace Redimensionador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando redimensionador.");

            Thread thread = new Thread(Redimensionar);
            thread.Start();



            Console.Read();
        }

        static void Redimensionar()
        {
            #region "Diretorios"
            string entradas = "ArquivosEntrada";
            string redimensionados = "ArquivosRedimensionado";
            string finalizados = "ArquivosFinalizados";

            if (!Directory.Exists(entradas))
            {
                Directory.CreateDirectory(entradas);
            }
            if (!Directory.Exists(redimensionados))
            {
                Directory.CreateDirectory(redimensionados);
            }
            if (!Directory.Exists(finalizados))
            {
                Directory.CreateDirectory(finalizados);
            }
            #endregion

            while (true)
            {
                var arquivosEntrada = Directory.EnumerateFiles(entradas);

                Thread.Sleep(new TimeSpan(0, 0, 5));
            }
        }
    }
}