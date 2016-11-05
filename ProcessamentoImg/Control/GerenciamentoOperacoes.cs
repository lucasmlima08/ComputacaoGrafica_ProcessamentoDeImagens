using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcessamentoImg.Model;
using System.Drawing;

namespace ProcessamentoImg.Control
{
    class GerenciamentoOperacoes
    {

        private int menorWidth(int width1, int width2)
        {
            if (width1 <= width2)
            {
                return width1;
            }
            else
            {
                return width2;
            }
        }

        private int menorHeigth(int hegth1, int heigth2)
        {
            if (hegth1 <= heigth2)
            {
                return hegth1;
            }
            else
            {
                return heigth2;
            }
        }

        public Bitmap Soma(Imagem img1, Imagem img2)
        {
            int width = menorWidth(img1.width, img2.width);
            int heigth = menorHeigth(img1.height, img2.height);

            Imagem resultadoImagem = new Imagem(width, heigth, img1.maxVal, (int[][])img1.pixels.Clone());
            
            for (int i = 0; i < resultadoImagem.width; i++)
            {
                for (int j = 0; j < resultadoImagem.height; j++)
                {
                    resultadoImagem.pixels[i][j] = img1.pixels[i][j] + img2.pixels[i][j];
                    if (resultadoImagem.pixels[i][j] > resultadoImagem.maxVal)
                    {
                        resultadoImagem.pixels[i][j] = 255;
                    }
                }
            }
            LeitorImagem leitor = new LeitorImagem(resultadoImagem);
            return leitor.ConverterParaBitmap();
        }

        public Bitmap Subtracao(Imagem img1, Imagem img2)
        {
            int width = menorWidth(img1.width, img2.width);
            int heigth = menorHeigth(img1.height, img2.height);

            Imagem resultadoImagem = new Imagem(width, heigth, img1.maxVal, (int[][])img1.pixels.Clone());

            for (int i = 0; i < resultadoImagem.width; i++)
            {
                for (int j = 0; j < resultadoImagem.height; j++)
                {
                    resultadoImagem.pixels[i][j] = img1.pixels[i][j] - img2.pixels[i][j];
                    if (resultadoImagem.pixels[i][j] < 0)
                    {
                        resultadoImagem.pixels[i][j] = 0;
                    }
                }
            }
            LeitorImagem leitor = new LeitorImagem(resultadoImagem);
            return leitor.ConverterParaBitmap();
        }

        public Bitmap Multiplicacao(Imagem img1, Imagem img2)
        {
            int width = menorWidth(img1.width, img2.width);
            int heigth = menorHeigth(img1.height, img2.height);

            Imagem resultadoImagem = new Imagem(width, heigth, img1.maxVal, (int[][])img1.pixels.Clone());

            for (int i = 0; i < resultadoImagem.width; i++)
            {
                for (int j = 0; j < resultadoImagem.height; j++)
                {
                    resultadoImagem.pixels[i][j] = img1.pixels[i][j] * img2.pixels[i][j];
                    if (resultadoImagem.pixels[i][j] > resultadoImagem.maxVal)
                    {
                        resultadoImagem.pixels[i][j] = 255;
                    }
                }
            }
            LeitorImagem leitor = new LeitorImagem(resultadoImagem);
            return leitor.ConverterParaBitmap();
        }

        public Bitmap Divisao(Imagem img1, Imagem img2)
        {
            int width = menorWidth(img1.width, img2.width);
            int heigth = menorHeigth(img1.height, img2.height);

            Imagem resultadoImagem = new Imagem(width, heigth, img1.maxVal, (int[][])img1.pixels.Clone());

            for (int i = 0; i < resultadoImagem.width; i++)
            {
                for (int j = 0; j < resultadoImagem.height; j++)
                {
                    if (img2.pixels[i][j] == 0)
                    {
                        resultadoImagem.pixels[i][j] = 0;
                    }
                    else
                    {
                        resultadoImagem.pixels[i][j] = img1.pixels[i][j] / img2.pixels[i][j];
                    }

                }
            }
           LeitorImagem leitor = new LeitorImagem(resultadoImagem);
            return leitor.ConverterParaBitmap();
        }

        public Bitmap And(Imagem img1, Imagem img2)
        {
            int width = menorWidth(img1.width, img2.width);
            int heigth = menorHeigth(img1.height, img2.height);

            Imagem resultadoImagem = new Imagem(width, heigth, img1.maxVal, (int[][])img1.pixels.Clone());

            for (int i = 0; i < resultadoImagem.width; i++)
            {
                for (int j = 0; j < resultadoImagem.height; j++)
                {
                    resultadoImagem.pixels[i][j] = img1.pixels[i][j] & img2.pixels[i][j];
                    if (resultadoImagem.pixels[i][j] > resultadoImagem.maxVal)
                    {
                        resultadoImagem.pixels[i][j] = 255;
                    }
                }
            }
            LeitorImagem leitor = new LeitorImagem(resultadoImagem);
            return leitor.ConverterParaBitmap();
        }

        public Bitmap Or(Imagem img1, Imagem img2)
        {
            int width = menorWidth(img1.width, img2.width);
            int heigth = menorHeigth(img1.height, img2.height);

            Imagem resultadoImagem = new Imagem(width, heigth, img1.maxVal, (int[][])img1.pixels.Clone());

            for (int i = 0; i < resultadoImagem.width; i++)
            {
                for (int j = 0; j < resultadoImagem.height; j++)
                {
                    resultadoImagem.pixels[i][j] = img1.pixels[i][j] | img2.pixels[i][j];
                    if (resultadoImagem.pixels[i][j] > resultadoImagem.maxVal)
                    {
                        resultadoImagem.pixels[i][j] = 255;
                    }
                }
            }
            LeitorImagem leitor = new LeitorImagem(resultadoImagem);
            return leitor.ConverterParaBitmap();
        }

        public Bitmap Xor(Imagem img1, Imagem img2)
        {
            int width = menorWidth(img1.width, img2.width);
            int heigth = menorHeigth(img1.height, img2.height);

            Imagem resultadoImagem = new Imagem(width, heigth, img1.maxVal, (int[][])img1.pixels.Clone());

            for (int i = 0; i < resultadoImagem.width; i++)
            {
                for (int j = 0; j < resultadoImagem.height; j++)
                {
                    resultadoImagem.pixels[i][j] = img1.pixels[i][j] ^ img2.pixels[i][j];
                    if (resultadoImagem.pixels[i][j] > resultadoImagem.maxVal)
                    {
                        resultadoImagem.pixels[i][j] = 255;
                    }
                }
            }
            LeitorImagem leitor = new LeitorImagem(resultadoImagem);
            return leitor.ConverterParaBitmap();
        }
    }
}
