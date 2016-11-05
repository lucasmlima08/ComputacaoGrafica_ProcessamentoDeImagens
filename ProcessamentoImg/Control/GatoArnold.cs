using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcessamentoImg.Model;

namespace ProcessamentoImg.Control
{
    class GatoArnold
    {
        public Imagem resultadoImagem = null;
        
        public Bitmap Gato(Imagem img)
        {
            resultadoImagem = new Imagem(img.width, img.height, img.maxVal, (int[][])img.pixels.Clone());

            int xNew = 0;
            int yNew = 0;

            for (int i = 0; i < img.width; i++)
            {
                resultadoImagem.pixels[i] = new int[img.height];
            }


            for (int i = 0; i < img.width; i++)
            {
                for (int j = 0; j <img.height; j++)
                {
                    xNew = ((i + j) % resultadoImagem.pixels.Length);
                    yNew = ((j + 2 * i) % resultadoImagem.pixels[0].Length);
                    resultadoImagem.pixels[xNew][yNew] = img.pixels[i][j];
                }
            }
           img.pixels = resultadoImagem.pixels;

           LeitorImagem leitor = new LeitorImagem(resultadoImagem);
           return leitor.ConverterParaBitmap();
        }
        
       
    }
}
