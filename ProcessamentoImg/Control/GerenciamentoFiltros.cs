using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcessamentoImg.Model;
using System.Drawing;

namespace ProcessamentoImg.Control
{
    class GerenciamentoFiltros
    {
        private Dictionary<int, int> _frequenciaInicial = null;
        private Dictionary<int, int> _frequenciaFinal = null;
        
        public Bitmap FiltroMedia(Imagem img)
        {
            Imagem resultadoImagem = new Imagem(img.width, img.height, img.maxVal, (int[][])img.pixels.Clone());

            for (int i = 1; i < img.width - 1; i++)
            {
                for (int j = 1; j < img.height - 1; j++)
                {
                    int mask1 = img.pixels[i - 1][j - 1] / 9;
                    int mask2 = img.pixels[i - 1][j] / 9;
                    int mask3 = img.pixels[i - 1][j + 1] / 9;
                    int mask4 = img.pixels[i][j - 1] / 9;
                    int mask5 = img.pixels[i][j] / 9;
                    int mask6 = img.pixels[i][j + 1] / 9;
                    int mask7 = img.pixels[i + 1][j - 1] / 9;
                    int mask8 = img.pixels[i + 1][j] / 9;
                    int mask9 = img.pixels[i + 1][j + 1] / 9;

                    int media = mask1 + mask2 + mask3 + mask4 + mask5 + mask6 + mask7 + mask8 + mask9;
                    resultadoImagem.pixels[i][j] = media;
                }
            }
            LeitorImagem leitor = new LeitorImagem(resultadoImagem);
            return leitor.ConverterParaBitmap();
        }

        public Bitmap FiltroMediana(Imagem img)
        {
            Imagem resultadoImagem = new Imagem(img.width, img.height, img.maxVal, (int[][])img.pixels.Clone());

            for (int i = 1; i < img.width - 1; i++)
            {
                for (int j = 1; j < img.height - 1; j++)
                {
                    int[] mask = new int[9];
                    mask[0] = img.pixels[i - 1][j - 1];
                    mask[1] = img.pixels[i - 1][j];
                    mask[2] = img.pixels[i - 1][j + 1];
                    mask[3] = img.pixels[i][j - 1];
                    mask[4] = img.pixels[i][j];
                    mask[5] = img.pixels[i][j + 1];
                    mask[6] = img.pixels[i + 1][j - 1];
                    mask[7] = img.pixels[i + 1][j];
                    mask[8] = img.pixels[i + 1][j + 1];

                    Array.Sort(mask);
                    int mediana = mask[4];
                    resultadoImagem.pixels[i][j] = mediana;
                }
            }

            LeitorImagem leitor = new LeitorImagem(resultadoImagem);
            return leitor.ConverterParaBitmap();
        }

        public Bitmap FiltroPassaAlta(Imagem img)
        {
            Imagem resultadoImagem = new Imagem(img.width, img.height, img.maxVal, (int[][])img.pixels.Clone());

            for (int i = 1; i < img.width - 1; i++)
            {
                for (int j = 1; j < img.height - 1; j++)
                {
                    int mask1 = img.pixels[i - 1][j - 1] * -1;
                    int mask2 = img.pixels[i - 1][j] * -1;
                    int mask3 = img.pixels[i - 1][j + 1] * -1;
                    int mask4 = img.pixels[i][j - 1] * -1;
                    int mask5 = img.pixels[i][j] * 8;
                    int mask6 = img.pixels[i][j + 1] * -1;
                    int mask7 = img.pixels[i + 1][j - 1] * -1;
                    int mask8 = img.pixels[i + 1][j] * -1;
                    int mask9 = img.pixels[i + 1][j + 1] * -1;

                    int passaAlta = mask1 + mask2 + mask3 + mask4 + mask5 + mask6 + mask7 + mask8 + mask9;
                    if (passaAlta > 255)
                    {
                        passaAlta = 255;
                    }
                    else
                    {
                        if (passaAlta < 0)
                        {
                            passaAlta = 0;
                        }
                    }
                    resultadoImagem.pixels[i][j] = passaAlta;
                }
            }

            LeitorImagem leitor = new LeitorImagem(resultadoImagem);
            return leitor.ConverterParaBitmap();
        }

        public Bitmap FiltroGradiente(Imagem img)
        {
            Imagem resultadoImagem = new Imagem(img.width, img.height, img.maxVal, (int[][])img.pixels.Clone());

            for (int i = 1; i < img.width - 1; i++)
            {
                for (int j = 1; j < img.height - 1; j++)
                {
                    int mask5 = img.pixels[i][j];
                    int mask6 = img.pixels[i + 1][j];
                    int mask8 = img.pixels[i][j + 1];
                    int gradiente = (mask5 - mask8) + (mask5 - mask6);

                    if (gradiente > 255)
                    {
                        gradiente = 255;
                    }
                    else
                    {
                        if (gradiente < 0)
                        {
                            gradiente = 0;
                        }
                    }
                    resultadoImagem.pixels[i][j] = gradiente;
                }
            }

            LeitorImagem leitor = new LeitorImagem(resultadoImagem);
            return leitor.ConverterParaBitmap();
        }

        public Bitmap FiltroGradienteCruzado(Imagem img)
        {
            Imagem resultadoImagem = new Imagem(img.width, img.height, img.maxVal, (int[][])img.pixels.Clone());

            for (int i = 1; i < img.width - 1; i++)
            {
                for (int j = 1; j < img.height - 1; j++)
                {
                    int mask5 = img.pixels[i][j];
                    int mask6 = img.pixels[i][j+1];
                    int mask8 = img.pixels[i+1][j];
                    int mask9 = img.pixels[i + 1][j + 1];
                    int gradiente = (mask5 - mask9) + (mask6 - mask8);

                    if (gradiente > 255)
                    {
                        gradiente = 255;
                    }
                    else
                    {
                        if (gradiente < 0)
                        {
                            gradiente = 0;
                        }
                    }

                    resultadoImagem.pixels[i][j] = gradiente;
                }
            }

            LeitorImagem leitor = new LeitorImagem(resultadoImagem);
            return leitor.ConverterParaBitmap();
        }

        public Bitmap FiltroAltoReforco(Imagem img, double a)
        {
           Imagem resultadoImagem = new Imagem(img.width, img.height, img.maxVal, (int[][])img.pixels.Clone());

            for (int i = 1; i < img.width - 1; i++)
            {
                for (int j = 1; j < img.height - 1; j++)
                {
                    int mask1 = img.pixels[i - 1][j - 1] * -1;
                    int mask2 = img.pixels[i - 1][j] * -1;
                    int mask3 = img.pixels[i - 1][j + 1] * -1;
                    int mask4 = img.pixels[i][j - 1] * -1;
                    int mask5 = Convert.ToInt32(img.pixels[i][j] * (9 * a - 1));
                    int mask6 = img.pixels[i][j + 1] * -1;
                    int mask7 = img.pixels[i + 1][j - 1] * -1;
                    int mask8 = img.pixels[i + 1][j] * -1;
                    int mask9 = img.pixels[i + 1][j + 1] * -1;

                    int altoReforco = mask1 + mask2 + mask3 + mask4 + mask5 + mask6 + mask7 + mask8 + mask9;
                    if (altoReforco > 255)
                    {
                        altoReforco = 255;
                    }
                    else
                    {
                        if (altoReforco < 0)
                        {
                            altoReforco = 0;
                        }
                    }
                    resultadoImagem.pixels[i][j] = altoReforco;
                }
            }

            LeitorImagem leitor = new LeitorImagem(resultadoImagem);
            return leitor.ConverterParaBitmap();
        }

        public Bitmap FiltroSobel(Imagem img)
        {
            Imagem resultadoImagem = new Imagem(img.width, img.height, img.maxVal, (int[][])img.pixels.Clone());

            for (int i = 1; i < img.width - 1; i++)
            {
                for (int j = 1; j < img.height - 1; j++)
                {
                    int mask1 = img.pixels[i - 1][j - 1];
                    int mask2 = img.pixels[i - 1][j];
                    int mask3 = img.pixels[i - 1][j + 1];
                    int mask4 = img.pixels[i][j - 1];
                    int mask6 = img.pixels[i][j + 1];
                    int mask7 = img.pixels[i + 1][j - 1];
                    int mask8 = img.pixels[i + 1][j];
                    int mask9 = img.pixels[i + 1][j + 1];
                    int sobel = Math.Abs((mask7 + (2 * mask8) + mask9) - (mask1 + (2 * mask2) + mask3)) +
                        Math.Abs((mask3 + (2 * mask6) + mask9) - (mask1 + (2 * mask4) + mask7));

                    if (sobel > 255)
                    {
                        sobel = 255;
                    }
                    else
                    {
                        if (sobel < 0)
                        {
                            sobel = 0;
                        }
                    }

                    resultadoImagem.pixels[i][j] = sobel;
                }
            }

            LeitorImagem leitor = new LeitorImagem(resultadoImagem);
            return leitor.ConverterParaBitmap();
        }

        public Bitmap FiltroPrewitt(Imagem img)
        {
            Imagem resultadoImagem = new Imagem(img.width, img.height, img.maxVal, (int[][])img.pixels.Clone());

            for (int i = 1; i < img.width - 1; i++)
            {
                for (int j = 1; j < img.height - 1; j++)
                {
                    int mask1 = img.pixels[i - 1][j - 1];
                    int mask2 = img.pixels[i - 1][j];
                    int mask3 = img.pixels[i - 1][j + 1];
                    int mask4 = img.pixels[i][j - 1];
                    int mask6 = img.pixels[i][j + 1];
                    int mask7 = img.pixels[i + 1][j - 1];
                    int mask8 = img.pixels[i + 1][j];
                    int mask9 = img.pixels[i + 1][j + 1];
                    int prewitt = Math.Abs((mask7 + mask8 + mask9) - (mask1 + mask2 + mask3)) +
                        Math.Abs((mask3 + mask6 + mask9) - (mask1 + mask4 + mask7));

                    if (prewitt > 255)
                    {
                        prewitt = 255;
                    }
                    else
                    {
                        if (prewitt < 0)
                        {
                            prewitt = 0;
                        }
                    }

                    resultadoImagem.pixels[i][j] = prewitt;
                }
            }
            LeitorImagem leitor = new LeitorImagem(resultadoImagem);
            return leitor.ConverterParaBitmap();
        }

        public Bitmap FiltroNegativo(Imagem img)
        {
            Imagem resultadoImagem = new Imagem(img.width, img.height, img.maxVal, (int[][])img.pixels.Clone());

            for (int i = 0; i < resultadoImagem.width; i++)
            {
                for (int j = 0; j < resultadoImagem.height; j++)
                {
                    resultadoImagem.pixels[i][j] = 255 - img.pixels[i][j];
                }
            }
            LeitorImagem leitor = new LeitorImagem(resultadoImagem);
            return leitor.ConverterParaBitmap();
        }

        public Bitmap FiltroGama(Imagem img, double gamma)
        {
            Imagem resultadoImagem = new Imagem(img.width, img.height, img.maxVal, (int[][])img.pixels.Clone());

            for (int i = 0; i < resultadoImagem.width; i++)
            {
                for (int j = 0; j < resultadoImagem.height; j++)
                {
                    resultadoImagem.pixels[i][j] = Convert.ToInt32(2 * Math.Pow(img.pixels[i][j], gamma));
                    if (resultadoImagem.pixels[i][j] > 255)
                    {
                        resultadoImagem.pixels[i][j] = 255;
                    }
                }
            }
           LeitorImagem leitor = new LeitorImagem(resultadoImagem);
            return leitor.ConverterParaBitmap();
        }

        public Bitmap FiltroLogaritmo(Imagem img, double c)
        {
            Imagem resultadoImaem = new Imagem(img.width, img.height, img.maxVal, (int[][])img.pixels.Clone());

            for (int i = 0; i < resultadoImaem.width; i++)
            {
                for (int j = 0; j < resultadoImaem.height; j++)
                {
                    resultadoImaem.pixels[i][j] = Convert.ToInt32(c * Math.Log10(img.pixels[i][j] + 1));
                    if (resultadoImaem.pixels[i][j] > 255)
                    {
                        resultadoImaem.pixels[i][j] = 255;
                    }
                }
            }
            LeitorImagem leitor = new LeitorImagem(resultadoImaem);
            return leitor.ConverterParaBitmap();
        }


        public Bitmap Equalizar(Imagem img)
        {
            Imagem resultadoImagem = new Imagem(img.width, img.height, img.maxVal, (int[][])img.pixels.Clone());
            _frequenciaInicial = new Dictionary<int, int>();
            _frequenciaFinal = new Dictionary<int, int>();
     
            Dictionary<int, List<double>> frequencia = new Dictionary<int, List<double>>();

            for (int i = 0; i < resultadoImagem.width; i++)
            {
                for (int j = 0; j < resultadoImagem.height; j++)
                {
                    int valor = img.pixels[i][j];
                    if (frequencia.Keys.Contains(valor))
                    {
                        frequencia[valor][0]++;
                        _frequenciaInicial[valor]++;
                    }
                    else
                    {
                        List<double> lista = new List<double>();
                        lista.Add(1);
                        frequencia.Add(valor, lista);
                        _frequenciaInicial.Add(valor, 1);
                    }
                }
            }

            foreach (var item in frequencia.OrderBy(k => k.Key))
            {
                //Calcula a frequencia
                frequencia[item.Key].Add(frequencia[item.Key][0] / (double)(img.height * img.width));
                frequencia[item.Key].Add(frequencia[item.Key][1]);
                if (item.Key != 0)
                {
                    frequencia[item.Key][2] += (frequencia[item.Key - 1][2]);
                }
            }

            Dictionary<int, int> escalaCinza = new Dictionary<int, int>();

            foreach (var item in frequencia.OrderBy(k => k.Key))
            {
                int novoValor = Convert.ToInt32(item.Value[2] * (img.maxVal - 1));
                escalaCinza.Add(Convert.ToInt32(item.Key), novoValor);
            }

            for (int i = 0; i < img.width; i++)
            {
                for (int j = 0; j < img.height; j++)
                {
                    int antigoValor = resultadoImagem.pixels[i][j];
                    resultadoImagem.pixels[i][j] = escalaCinza[antigoValor];
                }
            }

            for (int i = 0; i < resultadoImagem.width; i++)
            {
                for (int j = 0; j < resultadoImagem.height; j++)
                {
                    int valor = resultadoImagem.pixels[i][j];
                    if (_frequenciaFinal.Keys.Contains(valor))
                    {
                       _frequenciaFinal[valor]++;
                    }
                    else
                    {
                        _frequenciaFinal.Add(valor, 1);
                    }
                }
            }

            LeitorImagem leitor = new LeitorImagem(resultadoImagem);
            return leitor.ConverterParaBitmap();
        }


        public Dictionary<int, int> FrequenciaInicial { get { return _frequenciaInicial; } }

        public Dictionary<int, int> FrequenciaFinal { get { return _frequenciaFinal; } }
    }

}
