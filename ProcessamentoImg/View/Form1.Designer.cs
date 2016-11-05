namespace ProcessamentoImg
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.btn_carregarImg2 = new System.Windows.Forms.Button();
            this.comboBoxOpcoes = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.inputPanel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.inputPanel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btn_aplicar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureResultado = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_carregarImg1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.inputPanel2.SuspendLayout();
            this.inputPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureResultado)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // btn_carregarImg2
            // 
            this.btn_carregarImg2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_carregarImg2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_carregarImg2.Location = new System.Drawing.Point(322, 347);
            this.btn_carregarImg2.Name = "btn_carregarImg2";
            this.btn_carregarImg2.Size = new System.Drawing.Size(263, 34);
            this.btn_carregarImg2.TabIndex = 1;
            this.btn_carregarImg2.Text = "Carregar Imagem 2...";
            this.btn_carregarImg2.UseVisualStyleBackColor = true;
            this.btn_carregarImg2.Click += new System.EventHandler(this.btn_carregarImg2_Click);
            // 
            // comboBoxOpcoes
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.comboBoxOpcoes, 2);
            this.comboBoxOpcoes.DisplayMember = "Filtros";
            this.comboBoxOpcoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxOpcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOpcoes.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOpcoes.FormattingEnabled = true;
            this.comboBoxOpcoes.Items.AddRange(new object[] {
            "Filtros",
            "Operações Numéricas",
            "Gato de Arnold",
            "Histograma",
            "Operações Geométricas"});
            this.comboBoxOpcoes.Location = new System.Drawing.Point(53, 25);
            this.comboBoxOpcoes.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.comboBoxOpcoes.Name = "comboBoxOpcoes";
            this.comboBoxOpcoes.Size = new System.Drawing.Size(532, 30);
            this.comboBoxOpcoes.TabIndex = 5;
            this.comboBoxOpcoes.SelectedValueChanged += new System.EventHandler(this.comboBoxOpcoes_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(53, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 242);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.inputPanel2);
            this.panel3.Controls.Add(this.inputPanel1);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.btn_aplicar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(591, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 242);
            this.panel3.TabIndex = 3;
            // 
            // inputPanel2
            // 
            this.inputPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputPanel2.Controls.Add(this.label3);
            this.inputPanel2.Controls.Add(this.textBox3);
            this.inputPanel2.Location = new System.Drawing.Point(37, 98);
            this.inputPanel2.Name = "inputPanel2";
            this.inputPanel2.Size = new System.Drawing.Size(177, 35);
            this.inputPanel2.TabIndex = 4;
            this.inputPanel2.Visible = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(89, 8);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(36, 20);
            this.textBox3.TabIndex = 2;
            // 
            // inputPanel1
            // 
            this.inputPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputPanel1.Controls.Add(this.label2);
            this.inputPanel1.Controls.Add(this.textBox2);
            this.inputPanel1.Controls.Add(this.textBox1);
            this.inputPanel1.Controls.Add(this.label1);
            this.inputPanel1.Location = new System.Drawing.Point(37, 98);
            this.inputPanel1.Name = "inputPanel1";
            this.inputPanel1.Size = new System.Drawing.Size(177, 35);
            this.inputPanel1.TabIndex = 2;
            this.inputPanel1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(36, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "Média",
            "Mediana",
            "Passa Alta",
            "Passa Baixa",
            "Alto Reforço",
            "Sobel",
            "Gradiente",
            "Gradiente Cruzado",
            "Negativo",
            "Gama",
            "Logaritmo"});
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(51, 71);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(153, 26);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // btn_aplicar
            // 
            this.btn_aplicar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_aplicar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aplicar.Location = new System.Drawing.Point(51, 139);
            this.btn_aplicar.Name = "btn_aplicar";
            this.btn_aplicar.Size = new System.Drawing.Size(149, 29);
            this.btn_aplicar.TabIndex = 0;
            this.btn_aplicar.Text = "Aplicar";
            this.btn_aplicar.UseVisualStyleBackColor = true;
            this.btn_aplicar.Click += new System.EventHandler(this.btn_aplicar_Click);
            // 
            // panel4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel4, 2);
            this.panel4.Controls.Add(this.pictureResultado);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(860, 96);
            this.panel4.Name = "panel4";
            this.tableLayoutPanel1.SetRowSpan(this.panel4, 2);
            this.panel4.Size = new System.Drawing.Size(316, 285);
            this.panel4.TabIndex = 4;
            // 
            // pictureResultado
            // 
            this.pictureResultado.AccessibleDescription = "";
            this.pictureResultado.AccessibleName = "";
            this.pictureResultado.BackColor = System.Drawing.Color.Transparent;
            this.pictureResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureResultado.Location = new System.Drawing.Point(0, 0);
            this.pictureResultado.Name = "pictureResultado";
            this.pictureResultado.Size = new System.Drawing.Size(316, 285);
            this.pictureResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureResultado.TabIndex = 0;
            this.pictureResultado.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Tan;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxOpcoes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_carregarImg2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.chart1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.chart2, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_carregarImg1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.10527F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.10527F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1179, 654);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // chart1
            // 
            this.chart1.AccessibleDescription = "";
            chartArea5.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea5.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            this.tableLayoutPanel1.SetColumnSpan(this.chart1, 2);
            this.chart1.Location = new System.Drawing.Point(53, 387);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series5.ChartArea = "ChartArea1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(370, 174);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "Histograma Original";
            title5.Name = "Title1";
            title5.Text = "Histograma da Imagem Original";
            this.chart1.Titles.Add(title5);
            this.chart1.Visible = false;
            // 
            // chart2
            // 
            chartArea6.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea6.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            this.tableLayoutPanel1.SetColumnSpan(this.chart2, 2);
            this.chart2.Location = new System.Drawing.Point(591, 387);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series6.ChartArea = "ChartArea1";
            series6.Name = "Series1";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(370, 174);
            this.chart2.TabIndex = 10;
            this.chart2.Text = "Histograma Equalizado";
            title6.Name = "Title1";
            title6.Text = "Histograma da Imagem Equalizada";
            this.chart2.Titles.Add(title6);
            this.chart2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(322, 632);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Processamento de Imagens";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(591, 632);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Computação Gráfica";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(322, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(263, 242);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // btn_carregarImg1
            // 
            this.btn_carregarImg1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_carregarImg1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_carregarImg1.Location = new System.Drawing.Point(53, 350);
            this.btn_carregarImg1.Name = "btn_carregarImg1";
            this.btn_carregarImg1.Size = new System.Drawing.Size(263, 31);
            this.btn_carregarImg1.TabIndex = 15;
            this.btn_carregarImg1.Text = "Carregar Imagem...";
            this.btn_carregarImg1.UseVisualStyleBackColor = true;
            this.btn_carregarImg1.Click += new System.EventHandler(this.btn_carregarImg1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 654);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Processamento de Imagens";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.inputPanel2.ResumeLayout(false);
            this.inputPanel2.PerformLayout();
            this.inputPanel1.ResumeLayout(false);
            this.inputPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureResultado)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button btn_carregarImg2;
        private System.Windows.Forms.ComboBox comboBoxOpcoes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureResultado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel inputPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel inputPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btn_aplicar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_carregarImg1;
    }
}

