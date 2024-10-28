using System.Drawing;

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
                // Olha pra pasta de entrada, se tiver arquivo, redimensiona
                var arquivosEntrada = Directory.EnumerateFiles(entradas);

                // Ler o tamanho que irá redimensionar
                int novaAltura = 200;

                foreach (var arquivo in arquivosEntrada)
                {
                    FileStream fileStream = new FileStream(arquivo, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                    FileInfo fileInfo = new FileInfo(arquivo);

                    string caminho = Environment.CurrentDirectory + @"\" + redimensionados + @"\" + fileInfo.Name;

                    // Redimensiona
                    Redimensionador(Image.FromStream(fileStream), novaAltura, redimensionados);

                    // Fecha o arquivo
                    fileStream.Close();

                    // Copia os arquivos redimensionados para a pasta de redimensionados
                    fileInfo.MoveTo(Path.Combine(finalizados));

                    // Move o arquivo entrada para a pasta de finalizados
                }

                Thread.Sleep(new TimeSpan(0, 0, 5));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="imagem">Imagem a ser redimensionada</param>
        /// <param name="altura">Altura que desejamos redimensionar</param>
        /// <param name="caminho">Caminho aonde iremos gravar o arquivo redimensionado</param>
        /// <returns></returns>
        static void Redimensionador(Image imagem, int altura, string caminho)
        {
            double ratio = (double)altura / imagem.Height;
            int novaLargura = (int)(imagem.Width * ratio);
            int novaAltura = (int)(imagem.Height * ratio);

            Bitmap novaImage = new Bitmap(novaLargura, novaAltura);

            using (Graphics g = Graphics.FromImage(novaImage))
            {
                g.DrawImage(imagem, 0, 0, novaLargura, novaAltura);
            }

            novaImage.Save(caminho);
            imagem.Dispose();
        }
    }
}