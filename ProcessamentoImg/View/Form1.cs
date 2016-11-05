using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProcessamentoImg.Control;
using ProcessamentoImg.Model;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProcessamentoImg
{
    public partial class Form1 : Form
    {
        Imagem _imagem1 = null;
        Imagem _imagem2 = null;

        public Form1()
        {
            InitializeComponent();
        }



        private void comboBoxOpcoes_SelectedValueChanged(object sender, EventArgs e)
        {
            chart1.Visible = false;
            chart2.Visible = false;
            inputPanel1.Visible = false;
            inputPanel2.Visible = false;
            pictureResultado.Image = null;

            if (comboBoxOpcoes.Text.Equals("Filtros"))
            {
                pictureBox2.Visible = false;
                btn_carregarImg2.Visible = false;
                comboBox2.Visible = true;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Média");
                comboBox2.Items.Add("Mediana");
                comboBox2.Items.Add("Passa Alta");
                comboBox2.Items.Add("Prewitt");
                comboBox2.Items.Add("Alto Reforço");
                comboBox2.Items.Add("Sobel");
                comboBox2.Items.Add("Gradiente");
                comboBox2.Items.Add("Gradiente Cruzado");
                comboBox2.Items.Add("Negativo");
                comboBox2.Items.Add("Gamma");
                comboBox2.Items.Add("Logaritmo");
                
            }
            else if (comboBoxOpcoes.Text.Equals("Operações Numéricas"))
            {
                pictureBox2.Visible = true;
                btn_carregarImg2.Visible = true;
                comboBox2.Visible = true;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Soma");
                comboBox2.Items.Add("Subtração");
                comboBox2.Items.Add("Multiplicação");
                comboBox2.Items.Add("Divisão");
                comboBox2.Items.Add("AND");
                comboBox2.Items.Add("OR");
                comboBox2.Items.Add("XOR");
            }
            else if (comboBoxOpcoes.Text.Equals("Gato de Arnold"))
            {
                pictureBox2.Visible = false;
                btn_carregarImg2.Visible = false;
                comboBox2.Visible = false;
            }
            else if (comboBoxOpcoes.Text.Equals("Histograma"))
            {
                chart1.Visible = true;
                chart2.Visible = true;
                pictureBox2.Visible = false;
                btn_carregarImg2.Visible = false;
                comboBox2.Visible = false;
            }
            else if (comboBoxOpcoes.Text.Equals("Operações Geométricas"))
            {
                pictureBox2.Visible = false;
                comboBox2.Visible = true;
                btn_carregarImg2.Visible = false;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Escala");
                comboBox2.Items.Add("Rotação");
                comboBox2.Items.Add("Cisalhamento");
                comboBox2.Items.Add("Translação");

            }
        }

        private void btn_carregarImg1_Click(object sender, EventArgs e)
        {
            DialogResult userResult = openFileDialog1.ShowDialog();
            if (userResult == DialogResult.OK)
            {
                LeitorImagem leitor = new LeitorImagem(openFileDialog1.FileName);
                pictureBox1.Image = (Image)leitor.ConverterParaBitmap().Clone();
                _imagem1 = leitor.imagemCarregada;
                pictureBox1.Update();
            }
        }

        private void btn_carregarImg2_Click(object sender, EventArgs e)
        {
            DialogResult userResult = openFileDialog2.ShowDialog();
            if (userResult == DialogResult.OK)
            {
                LeitorImagem leitor = new LeitorImagem(openFileDialog2.FileName);
                pictureBox2.Image = (Image)leitor.ConverterParaBitmap().Clone();
                _imagem2 = leitor.imagemCarregada;
                pictureBox2.Update();
            }
        }

        private void btn_aplicar_Click(object sender, EventArgs e)
        {
            if(_imagem1 == null)
                MessageBox.Show("Por favor selecione uma imagem!");


            if (comboBoxOpcoes.Text.Equals("Filtros"))
            {
                filtros();
            }

            else if (comboBoxOpcoes.Text.Equals("Operações Numéricas"))
            {
                if (_imagem2 == null)
                    MessageBox.Show("Por favor carregue a segunda imagem!");
                else
                    opNumericas();
            }

            else if (comboBoxOpcoes.Text.Equals("Gato de Arnold"))
            {
                gatoArnold();
            }

            else if (comboBoxOpcoes.Text.Equals("Histograma"))
            {
                histograma();
            }

            else if (comboBoxOpcoes.Text.Equals("Operações Geométricas"))
            {
                opGeometricas();
            }

            else
            {
                MessageBox.Show("Por favor selecione uma opção!");
            }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox3.Text = "";

            if (comboBox2.Text.Equals("Alto Reforço")){
                inputPanel1.Visible = false;
                inputPanel2.Visible = true;
                label3.Text = "A: ";
                MessageBox.Show("A>=1\nUtilize ',' para números decimais!");

            }
            else if (comboBox2.Text.Equals("Gamma")){
                inputPanel1.Visible = false;
                inputPanel2.Visible = true;
                label3.Text = "Gamma: ";
                MessageBox.Show("0<=Gamma<=1 \nUse ',' para números decimais!");
            }
            else if (comboBox2.Text.Equals("Logaritmo"))
            {
                inputPanel1.Visible = false;
                inputPanel2.Visible = true;
                label3.Text = "Constante: ";
                MessageBox.Show("Utilize ',' para números decimais!");
            }
            else if (comboBox2.Text.Equals("Escala")| comboBox2.Text.Equals("Translação")| comboBox2.Text.Equals("Cisalhamento"))
            {
                inputPanel2.Visible = false;
                inputPanel1.Visible = true;
                label1.Text = "X: ";
                label2.Text = "Y: ";
            }
            else if (comboBox2.Text.Equals("Rotação"))
            {
                inputPanel1.Visible = false;
                inputPanel2.Visible = true;
                label3.Text = "Ângulo: ";
            }

            else
            {
                inputPanel1.Visible = false;
                inputPanel2.Visible = false;
            }
        }

        private void filtros()
        {
            GerenciamentoFiltros gerFiltros = new GerenciamentoFiltros();
            
            string op = comboBox2.Text;
            switch (op)
            {
                case "Média":
                    pictureResultado.Image = (Image)gerFiltros.FiltroMedia(_imagem1).Clone();
                    pictureResultado.Update();
                    break;
                case "Mediana":
                    pictureResultado.Image = (Image)gerFiltros.FiltroMediana(_imagem1).Clone();
                    pictureResultado.Update();
                    break;
                case "Passa Alta":
                    pictureResultado.Image = (Image)gerFiltros.FiltroPassaAlta(_imagem1).Clone();
                    pictureResultado.Update();
                    break;
                case "Prewitt":
                    pictureResultado.Image = (Image)gerFiltros.FiltroPrewitt(_imagem1).Clone();
                    pictureResultado.Update();
                    break;
                case "Alto Reforço":
                    if (textBox3.Text.Equals(""))
                    {
                        MessageBox.Show("Por favor preencha o valor de A");
                    }
                    else
                    {
                        double a = Convert.ToDouble(textBox3.Text);
                        pictureResultado.Image = (Image)gerFiltros.FiltroAltoReforco(_imagem1, a).Clone();
                        pictureResultado.Update();
                    }
                    break;
                case "Sobel":
                    pictureResultado.Image = (Image)gerFiltros.FiltroSobel(_imagem1).Clone();
                    pictureResultado.Update();
                    break;
                case "Gradiente":
                    pictureResultado.Image = (Image)gerFiltros.FiltroGradiente(_imagem1).Clone();
                    pictureResultado.Update();
                    break;
                case "Gradiente Cruzado":
                    pictureResultado.Image = (Image)gerFiltros.FiltroGradienteCruzado(_imagem1).Clone();
                    pictureResultado.Update();
                    break;
                case "Negativo":
                    pictureResultado.Image = (Image)gerFiltros.FiltroNegativo(_imagem1).Clone();
                    pictureResultado.Update();
                    break;
                case "Gamma":
                    if (textBox3.Text.Equals(""))
                    {
                        MessageBox.Show("Por favor preencha o valor de Gamma");
                    }
                    else
                    {
                        double gamma = Convert.ToDouble(textBox3.Text);
                        pictureResultado.Image = (Image)gerFiltros.FiltroGama(_imagem1, gamma).Clone();
                        pictureResultado.Update();
                    }
                    break;
                case "Logaritmo":
                    if (textBox3.Text.Equals(""))
                    {
                        MessageBox.Show("Por favor preencha o valor da Constante");
                    }
                    else
                    {
                        double c = Convert.ToDouble(textBox3.Text);
                        pictureResultado.Image = (Image)gerFiltros.FiltroLogaritmo(_imagem1, c).Clone();
                        pictureResultado.Update();
                    }
                    break;
                default:
                    MessageBox.Show("Por favor selecione o filtro que deseja utilizar!");
                    break;

            }
        }

        private void opNumericas()
        {
            GerenciamentoOperacoes gerOperacoes = new GerenciamentoOperacoes();

            string op = comboBox2.Text;
            switch (op)
            {
                case "Soma":
                    pictureResultado.Image = gerOperacoes.Soma(_imagem1, _imagem2);
                    pictureResultado.Refresh();
                    break;
                case "Subtração":
                    pictureResultado.Image = gerOperacoes.Subtracao(_imagem1, _imagem2);
                    pictureResultado.Refresh();
                    break;
                case "Multiplicação":
                    pictureResultado.Image = gerOperacoes.Multiplicacao(_imagem1, _imagem2);
                    pictureResultado.Refresh();
                    break;
                case "Divisão":
                    pictureResultado.Image = gerOperacoes.Divisao(_imagem1, _imagem2);
                    pictureResultado.Refresh();
                    break;
                case "AND":
                    pictureResultado.Image = gerOperacoes.And(_imagem1, _imagem2);
                    pictureResultado.Refresh();
                    break;
                case "OR":
                    pictureResultado.Image = gerOperacoes.Or(_imagem1, _imagem2);
                    pictureResultado.Refresh();
                    break;
                case "XOR":
                    pictureResultado.Image = gerOperacoes.Xor(_imagem1, _imagem2);
                    pictureResultado.Refresh();
                    break;
                default:
                    MessageBox.Show("Por favor selecione a operação que deseja fazer!");
                    break;


            }
        }

        private void opGeometricas()
        {
            GerenciamentoTransformacoes gerTransformacoes = new GerenciamentoTransformacoes();
            string op = comboBox2.Text;
            switch (op)
            {
                case "Escala":
                    pictureResultado.Image = (Image)gerTransformacoes.opEscalonar(_imagem1, Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).Clone();
                    pictureResultado.Update();
                    break;
                case "Rotação":
                    pictureResultado.Image = (Image)gerTransformacoes.opRotacionar(_imagem1, Convert.ToInt32(textBox3.Text)).Clone();
                    pictureResultado.Update();
                    break;
                case "Cisalhamento":
                    pictureResultado.Image = (Image)gerTransformacoes.opCisalhar(_imagem1, Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).Clone();
                    pictureResultado.Update();
                    break;
                case "Translação":
                    pictureResultado.Image = (Image)gerTransformacoes.opTransladar(_imagem1, Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox1.Text)).Clone();
                    pictureResultado.Update();
                    break;

                default:
                    MessageBox.Show("Por favor selecione a operação que deseja fazer!");
                    break;

            }
        }

        private void gatoArnold()
        {
            Imagem imagemComparar = new Imagem(_imagem1.width, _imagem1.height, _imagem1.maxVal, (int[][])_imagem1.pixels.Clone());
            GatoArnold gato = new GatoArnold();
            while (true)
            {
                pictureResultado.Image = gato.Gato(_imagem1);
                pictureResultado.Refresh();
                Thread.Sleep(10);
                if (imagemComparar.Equals(gato.resultadoImagem))
                {
                 MessageBox.Show("Miau!");
                 break;
               }
            }
           
        }

        private void histograma()
        {
            GerenciamentoFiltros gerFiltros = new GerenciamentoFiltros();
            pictureResultado.Image = gerFiltros.Equalizar(_imagem1);
            pictureResultado.Refresh();


            if (gerFiltros.FrequenciaInicial != null)
            {
                Dictionary<int, int> sourceFrequency = gerFiltros.FrequenciaInicial;
                foreach (var item in sourceFrequency)
                {
                    Series series = chart1.Series.Add(item.Key.ToString());
                    series.Points.Add(item.Value);
                    series.Color = Color.Blue;
                }

            }
            if (gerFiltros.FrequenciaFinal != null)
            {
                Dictionary<int, int> targetFrequency = gerFiltros.FrequenciaFinal;

                foreach (var item in targetFrequency)
                {
                    Series series = chart2.Series.Add(item.Key.ToString());
                    series.Points.Add(item.Value);
                    series.Color = Color.Blue;
                }

            }

        }
    }
}
