using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcessamentoImg.Model;
using System.Drawing;

namespace ProcessamentoImg.Control
{
    class GerenciamentoTransformacoes
    {
        // Retorna a matriz de translação.
        public List<double[]> transladar(double X, double Y)
        {
            List<double[]> matrizTranslacao = new List<double[]>();
            matrizTranslacao.Add(new double[] { 1, 0, 0 });
            matrizTranslacao.Add(new double[] { 0, 1, 0 });
            matrizTranslacao.Add(new double[] { X, Y, 1 });

            return matrizTranslacao;
        }

        // Retorna a matriz de escala.
        public List<double[]> escalonar(double X, double Y)
        {
            List<double[]> matrizEscala = new List<double[]>();
            matrizEscala.Add(new double[] { X, 0, 0 });
            matrizEscala.Add(new double[] { 0, Y, 0 });
            matrizEscala.Add(new double[] { 0, 0, 1 });

            return matrizEscala;
        }

        // Retorna a matriz de rotação.
        public List<double[]> rotacionar(double angulo)
        {
            double anguloRadianos = Math.PI * angulo / 180;

            List<double[]> matrizRotacao = new List<double[]>();
            matrizRotacao.Add(new double[] { Math.Cos(anguloRadianos), -Math.Sin(anguloRadianos), 0 });
            matrizRotacao.Add(new double[] { Math.Sin(anguloRadianos), Math.Cos(anguloRadianos), 0 });
            matrizRotacao.Add(new double[] { 0, 0, 1 });

            return matrizRotacao;
        }

        // Retorna a matriz de cisalhamento.
        public List<double[]> cisalhar(double X, double Y)
        {
            List<double[]> matrizCisalhamento = new List<double[]>();
            matrizCisalhamento.Add(new double[] { 1, X, 0 });
            matrizCisalhamento.Add(new double[] { Y, 1, 0 });
            matrizCisalhamento.Add(new double[] { 0, 0, 1 });

            return matrizCisalhamento;
        }

        // Retorna a multiplicação de duas matrizes.
        public List<double[]> multiplicar(List<double[]> matriz1, List<double[]> matriz2)
        {
            List<double[]> novaMatriz = new List<double[]>();

            int a = matriz1.Count;
            int b = matriz2[0].Length;
            double[,] array = new double[a, b];

            for (int i = 0; i < matriz1.Count; i++) // Linhas da matriz 1.
            {
                for (int j = 0; j < matriz2[0].Length; j++) // Colunas da matriz 2.
                {
                    for (int k = 0; k < matriz1[0].Length; k++)
                    { // Linhas da matriz 2. 
                        array[i, j] += (matriz1[i][k] * matriz2[k][j]);
                    }
                }
            }
            // Passando para a lista.
            for (int i = 0; i < a; i++)
            {
                double[] linha = new double[b];
                for (int j = 0; j < b; j++)
                {
                    linha[j] = array[i, j];
                }
                novaMatriz.Add(linha);
            }

            return novaMatriz;
        }

        // Limpa a imagem para uma única cor.
        private Imagem limparImagem(Imagem img)
        {
            Imagem imagemFormatada = new Imagem(img.width, img.height, img.maxVal, (int[][])img.pixels.Clone());

            for (int i = 1; i < img.width - 1; i++)
            {
                for (int j = 1; j < img.height - 1; j++)
                {
                    imagemFormatada.pixels[i][j] = 255;
                }
            }
            return imagemFormatada;
        }

        private double[] origemPixelCentro = new double[] { 0, 0 };

        public Imagem transformar(Imagem img, int tipoTransformacao, double[] parametros)
        {
            Imagem resultadoImagem = limparImagem(img);
            for (int i = 0; i < img.width; i++)
            {
                for (int j = 0; j < img.height; j++)
                {
                    List<double[]> pixel = new List<double[]>();
                    pixel.Add(new double[] { i, j, 1 });

                    int hwidth = img.width / 2;
                    int hheight = img.height / 2;

                    int xt = i - hwidth;
                    int yt = j - hheight;

                    List<double[]> transformado = new List<double[]>();
                    
                    if (tipoTransformacao == 1) // Translação.
                    {
                        transformado = multiplicar(pixel, transladar(parametros[0], parametros[1]));
                    }
                    else if (tipoTransformacao == 2) // Escalonamento.
                    {
                        transformado = multiplicar(pixel, escalonar(parametros[0], parametros[1]));
                    }
                    else if (tipoTransformacao == 3) // Rotação.
                    {
                        transformado = multiplicar(pixel, rotacionar(parametros[0]));
                    }
                    else if (tipoTransformacao == 4) // Cisalhamento
                    {
                        transformado = multiplicar(pixel, cisalhar(parametros[0], parametros[1]));
                    }
                    else if (tipoTransformacao == 5) // Escala com translação para origem.
                    {
                        transformado = multiplicar(escalonar(parametros[0], parametros[1]), transladar(parametros[2], parametros[3]));
                        transformado = multiplicar(pixel, transformado);
                    }
                    else if (tipoTransformacao == 6) // Rotação com translação para origem.
                    {
                        transformado = multiplicar(rotacionar(parametros[0]), transladar(parametros[1], parametros[2]));
                        transformado = multiplicar(pixel, transformado);
                    }
                    else if (tipoTransformacao == 7) // Cisalhamento com translação para origem.
                    {
                        transformado = multiplicar(cisalhar(parametros[0], parametros[1]), transladar(parametros[2], parametros[3]));
                        transformado = multiplicar(pixel, transformado);
                    }

                    int pixelX = (int)transformado[0][0];
                    int pixelY = (int)transformado[0][1];
                    
                    // Transforma o pixel.
                    if (pixelX < img.width && pixelX > 0 && pixelY < img.height && pixelY > 0)
                    {
                        resultadoImagem.pixels[pixelX][pixelY] = img.pixels[i][j];
                    }

                    // Guarda a origem.
                    if ((int)(img.width / 2) == i && (int)(img.height / 2) == j)
                    {
                        origemPixelCentro = new double[] { i - pixelX, j - pixelY };
                    }
                }
            }
            return resultadoImagem;
        }
        
        public Bitmap opTransladar(Imagem img, double x, double y)
        {
            Imagem imagemTransformada = transformar(img, 1, new double[] { x, y }); // Transforma.
            LeitorImagem leitor = new LeitorImagem(imagemTransformada);
            return leitor.ConverterParaBitmap();
        }

        public Bitmap opEscalonar(Imagem img, double x, double y)
        {
            Imagem imagemTransformadaAux = transformar(img, 2, new double[] { x, y }); // Transforma.
            Imagem imagemTransformada = transformar(img, 5, new double[] { x, y, origemPixelCentro[0], origemPixelCentro[1] }); // Transforma.
            LeitorImagem leitor = new LeitorImagem(imagemTransformada);
            return leitor.ConverterParaBitmap();
        }

        public Bitmap opRotacionar(Imagem img, double angle)
        {
            Imagem imagemTransformadaAux = transformar(img, 3, new double[] { angle }); // Transforma.
            Imagem imagemTransformada = transformar(img, 6, new double[] { angle, origemPixelCentro[0], origemPixelCentro[1] }); // Transforma.
            LeitorImagem leitor = new LeitorImagem(imagemTransformada);
            return leitor.ConverterParaBitmap();
        }

        public Bitmap opCisalhar(Imagem img, double x, double y)
        {
            Imagem imagemTransformadaAux = transformar(img, 4, new double[] { x, y }); // Transforma.
            Imagem imagemTransformada = transformar(img, 7, new double[] { x, y, origemPixelCentro[0], origemPixelCentro[1] }); // Transforma.
            LeitorImagem leitor = new LeitorImagem(imagemTransformada);
            return leitor.ConverterParaBitmap();
        }
        

        private Bitmap ConverteParaBitmap(int[][] matrizImagem, int width, int height)
        {
            Bitmap resultado = new Bitmap(width, height);


            for (int i = 0; i < resultado.Width; i++)
            {
                for (int j = 0; j < resultado.Height; j++)
                {
                    resultado.SetPixel(j, i, Color.FromArgb(255, matrizImagem[i][j], matrizImagem[i][j], matrizImagem[i][j]));
                }
            }
            return resultado;
        }
    }









    

}
