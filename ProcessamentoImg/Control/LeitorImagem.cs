using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcessamentoImg.Model;
using System.Drawing;
using System.IO;

namespace ProcessamentoImg.Control
{
    class LeitorImagem
    {
        Imagem _imagem;
        String _caminho;

        public Imagem imagemCarregada { get { return _imagem; } }


        public LeitorImagem(Imagem img)
        {
            _imagem = img;
        }

        public LeitorImagem(String caminho)
        {
            _caminho = caminho;
        }

        public Bitmap ConverterParaBitmap()
        {
            Imagem imagemCarregada = CarregarImagem();
            Bitmap resultado = new Bitmap(imagemCarregada.width, imagemCarregada.height);
            int[][] matriz = (int[][])imagemCarregada.pixels.Clone();
            for (int i = 0; i < resultado.Width; i++)
            {
                for (int j = 0; j < resultado.Height; j++)
                {
                    resultado.SetPixel(j, i, Color.FromArgb(255, matriz[i][j], matriz[i][j], matriz[i][j]));
                }
            }
            return resultado;
        }


        private Imagem CarregarImagem()
        {
            if (_imagem == null)
            {
                FileStream ifs = new FileStream(_caminho, FileMode.Open);
                StreamReader br = new StreamReader(ifs);

                //P2 indica que é um arquivo PGM
                string magic = ProxLinha(br);
                if (magic != "P2")
                    throw new Exception("Tipo de imagem não identificado: " + magic);

                //Colocando a segunda linha no array Tokens que identifica largura e altura da imagem
                string widthHeight = ProxLinha(br);
                string[] tokens = widthHeight.Split(' ');
                int width = int.Parse(tokens[0]);
                int height = int.Parse(tokens[1]);

                //Terceira linha identifica o max valor da imagem
                string sMaxValor = ProxLinha(br);
                int maxValor = int.Parse(sMaxValor);

                //Lendo o valor dos pixels: width * height...
                int[][] pixels = new int[width][];
                for (int i = 0; i < width; ++i)
                    pixels[i] = new int[height];

                for (int i = 0; i < width; ++i)
                {
                    string[] line = br.ReadLine().Split(' ');
                    for (int j = 0; j < height; ++j)
                        pixels[i][j] = int.Parse(line[j]);
                }
                br.Close();
                ifs.Close();

                //Colocando os valores do array na imagem
                Imagem resultado = new Imagem(width, height, maxValor, pixels);
                _imagem = resultado;
                return resultado;
            }
            return _imagem;
        }

        private string ProxLinha(StreamReader br)
        {
            string s = br.ReadLine();
            while (s.StartsWith("#") || s == "")
                s = br.ReadLine();
            return s;
        }
    }
}
