﻿
namespace TP3_VariablesAleatorias.Presentaciones
{
    partial class frm_principal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.gbValores = new System.Windows.Forms.GroupBox();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.nudValores = new System.Windows.Forms.NumericUpDown();
            this.lblValores = new System.Windows.Forms.Label();
            this.nudA = new System.Windows.Forms.NumericUpDown();
            this.lblIntervalo = new System.Windows.Forms.Label();
            this.nudB = new System.Windows.Forms.NumericUpDown();
            this.nudLambda = new System.Windows.Forms.NumericUpDown();
            this.lblMedia = new System.Windows.Forms.Label();
            this.nudMedia = new System.Windows.Forms.NumericUpDown();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.cboDistribucion = new System.Windows.Forms.ComboBox();
            this.lblDistribucion = new System.Windows.Forms.Label();
            this.lblLambda = new System.Windows.Forms.Label();
            this.lblDesviacion = new System.Windows.Forms.Label();
            this.nudDesviacion = new System.Windows.Forms.NumericUpDown();
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.lblIntervalos = new System.Windows.Forms.Label();
            this.cbIntervalos = new System.Windows.Forms.ComboBox();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbGrafico = new System.Windows.Forms.GroupBox();
            this.gbValores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLambda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesviacion)).BeginInit();
            this.gbParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.gbGrafico.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.Location = new System.Drawing.Point(27, 448);
            this.btnRestablecer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(146, 53);
            this.btnRestablecer.TabIndex = 4;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = true;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(193, 448);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(146, 53);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar Valores";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // gbValores
            // 
            this.gbValores.Controls.Add(this.dgvTabla);
            this.gbValores.Location = new System.Drawing.Point(366, 18);
            this.gbValores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbValores.Name = "gbValores";
            this.gbValores.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbValores.Size = new System.Drawing.Size(884, 375);
            this.gbValores.TabIndex = 34;
            this.gbValores.TabStop = false;
            this.gbValores.Text = "Tabla de Frecuencias de los Valores Generados";
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.AllowUserToResizeColumns = false;
            this.dgvTabla.AllowUserToResizeRows = false;
            this.dgvTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(12, 23);
            this.dgvTabla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowHeadersVisible = false;
            this.dgvTabla.RowHeadersWidth = 51;
            this.dgvTabla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTabla.RowTemplate.Height = 24;
            this.dgvTabla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTabla.Size = new System.Drawing.Size(860, 340);
            this.dgvTabla.TabIndex = 12;
            // 
            // nudValores
            // 
            this.nudValores.Location = new System.Drawing.Point(239, 67);
            this.nudValores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudValores.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudValores.Name = "nudValores";
            this.nudValores.Size = new System.Drawing.Size(100, 22);
            this.nudValores.TabIndex = 1;
            this.nudValores.Click += new System.EventHandler(this.numActive);
            this.nudValores.Enter += new System.EventHandler(this.numActive);
            // 
            // lblValores
            // 
            this.lblValores.AutoSize = true;
            this.lblValores.Location = new System.Drawing.Point(24, 69);
            this.lblValores.Name = "lblValores";
            this.lblValores.Size = new System.Drawing.Size(209, 17);
            this.lblValores.TabIndex = 33;
            this.lblValores.Text = "Cantidad de Valores a Generar:";
            // 
            // nudA
            // 
            this.nudA.DecimalPlaces = 2;
            this.nudA.Location = new System.Drawing.Point(180, 40);
            this.nudA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudA.Name = "nudA";
            this.nudA.Size = new System.Drawing.Size(100, 22);
            this.nudA.TabIndex = 0;
            this.nudA.Click += new System.EventHandler(this.numActive);
            this.nudA.Enter += new System.EventHandler(this.numActive);
            // 
            // lblIntervalo
            // 
            this.lblIntervalo.AutoSize = true;
            this.lblIntervalo.Location = new System.Drawing.Point(32, 42);
            this.lblIntervalo.Name = "lblIntervalo";
            this.lblIntervalo.Size = new System.Drawing.Size(108, 17);
            this.lblIntervalo.TabIndex = 26;
            this.lblIntervalo.Text = "Intervalo  [A; B]:";
            // 
            // nudB
            // 
            this.nudB.DecimalPlaces = 2;
            this.nudB.Location = new System.Drawing.Point(180, 75);
            this.nudB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudB.Name = "nudB";
            this.nudB.Size = new System.Drawing.Size(100, 22);
            this.nudB.TabIndex = 1;
            this.nudB.Click += new System.EventHandler(this.numActive);
            this.nudB.Enter += new System.EventHandler(this.numActive);
            // 
            // nudLambda
            // 
            this.nudLambda.DecimalPlaces = 2;
            this.nudLambda.Location = new System.Drawing.Point(180, 214);
            this.nudLambda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudLambda.Name = "nudLambda";
            this.nudLambda.Size = new System.Drawing.Size(100, 22);
            this.nudLambda.TabIndex = 4;
            this.nudLambda.Click += new System.EventHandler(this.numActive);
            this.nudLambda.Enter += new System.EventHandler(this.numActive);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(124, 124);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(50, 17);
            this.lblMedia.TabIndex = 23;
            this.lblMedia.Text = "Media:";
            // 
            // nudMedia
            // 
            this.nudMedia.DecimalPlaces = 2;
            this.nudMedia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nudMedia.Location = new System.Drawing.Point(180, 122);
            this.nudMedia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudMedia.Name = "nudMedia";
            this.nudMedia.Size = new System.Drawing.Size(100, 22);
            this.nudMedia.TabIndex = 2;
            this.nudMedia.Click += new System.EventHandler(this.numActive);
            this.nudMedia.Enter += new System.EventHandler(this.numActive);
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(153, 77);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(21, 17);
            this.lblB.TabIndex = 21;
            this.lblB.Text = "B:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(153, 42);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(21, 17);
            this.lblA.TabIndex = 20;
            this.lblA.Text = "A:";
            // 
            // cboDistribucion
            // 
            this.cboDistribucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistribucion.FormattingEnabled = true;
            this.cboDistribucion.Items.AddRange(new object[] {
            "Uniforme",
            "Exponencial Negativa",
            "Normal",
            "Poisson"});
            this.cboDistribucion.Location = new System.Drawing.Point(128, 21);
            this.cboDistribucion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboDistribucion.Name = "cboDistribucion";
            this.cboDistribucion.Size = new System.Drawing.Size(211, 24);
            this.cboDistribucion.TabIndex = 0;
            this.cboDistribucion.SelectedIndexChanged += new System.EventHandler(this.cboMetodo_SelectedIndexChanged);
            // 
            // lblDistribucion
            // 
            this.lblDistribucion.AutoSize = true;
            this.lblDistribucion.Location = new System.Drawing.Point(24, 24);
            this.lblDistribucion.Name = "lblDistribucion";
            this.lblDistribucion.Size = new System.Drawing.Size(86, 17);
            this.lblDistribucion.TabIndex = 27;
            this.lblDistribucion.Text = "Distribución:";
            // 
            // lblLambda
            // 
            this.lblLambda.AutoSize = true;
            this.lblLambda.Location = new System.Drawing.Point(111, 216);
            this.lblLambda.Name = "lblLambda";
            this.lblLambda.Size = new System.Drawing.Size(63, 17);
            this.lblLambda.TabIndex = 36;
            this.lblLambda.Text = "Lambda:";
            // 
            // lblDesviacion
            // 
            this.lblDesviacion.AutoSize = true;
            this.lblDesviacion.Location = new System.Drawing.Point(32, 170);
            this.lblDesviacion.Name = "lblDesviacion";
            this.lblDesviacion.Size = new System.Drawing.Size(142, 17);
            this.lblDesviacion.TabIndex = 38;
            this.lblDesviacion.Text = "Desviación Estándar:";
            // 
            // nudDesviacion
            // 
            this.nudDesviacion.DecimalPlaces = 2;
            this.nudDesviacion.Location = new System.Drawing.Point(180, 168);
            this.nudDesviacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudDesviacion.Name = "nudDesviacion";
            this.nudDesviacion.Size = new System.Drawing.Size(100, 22);
            this.nudDesviacion.TabIndex = 3;
            this.nudDesviacion.Click += new System.EventHandler(this.numActive);
            this.nudDesviacion.Enter += new System.EventHandler(this.numActive);
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.lblIntervalo);
            this.gbParametros.Controls.Add(this.lblDesviacion);
            this.gbParametros.Controls.Add(this.lblB);
            this.gbParametros.Controls.Add(this.nudDesviacion);
            this.gbParametros.Controls.Add(this.nudB);
            this.gbParametros.Controls.Add(this.lblLambda);
            this.gbParametros.Controls.Add(this.lblA);
            this.gbParametros.Controls.Add(this.nudMedia);
            this.gbParametros.Controls.Add(this.nudA);
            this.gbParametros.Controls.Add(this.nudLambda);
            this.gbParametros.Controls.Add(this.lblMedia);
            this.gbParametros.Location = new System.Drawing.Point(27, 157);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(312, 273);
            this.gbParametros.TabIndex = 39;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Parámetros";
            // 
            // lblIntervalos
            // 
            this.lblIntervalos.AutoSize = true;
            this.lblIntervalos.Location = new System.Drawing.Point(80, 113);
            this.lblIntervalos.Name = "lblIntervalos";
            this.lblIntervalos.Size = new System.Drawing.Size(153, 17);
            this.lblIntervalos.TabIndex = 41;
            this.lblIntervalos.Text = "Cantidad de Intervalos:";
            // 
            // cbIntervalos
            // 
            this.cbIntervalos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIntervalos.FormattingEnabled = true;
            this.cbIntervalos.Items.AddRange(new object[] {
            "8",
            "10",
            "15",
            "20"});
            this.cbIntervalos.Location = new System.Drawing.Point(239, 110);
            this.cbIntervalos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbIntervalos.Name = "cbIntervalos";
            this.cbIntervalos.Size = new System.Drawing.Size(100, 24);
            this.cbIntervalos.TabIndex = 2;
            // 
            // grafico
            // 
            chartArea1.AxisX.LabelStyle.Format = "0.00";
            chartArea1.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico.Legends.Add(legend1);
            this.grafico.Location = new System.Drawing.Point(11, 23);
            this.grafico.Margin = new System.Windows.Forms.Padding(4);
            this.grafico.Name = "grafico";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Frecuencia Esperada";
            series1.Name = "FrecuenciaEsperada";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.LegendText = "Frecuencia Obtenida";
            series2.Name = "FrecuenciaObtenida";
            this.grafico.Series.Add(series1);
            this.grafico.Series.Add(series2);
            this.grafico.Size = new System.Drawing.Size(860, 340);
            this.grafico.TabIndex = 44;
            this.grafico.Text = "chart1";
            // 
            // gbGrafico
            // 
            this.gbGrafico.Controls.Add(this.grafico);
            this.gbGrafico.Location = new System.Drawing.Point(366, 397);
            this.gbGrafico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGrafico.Name = "gbGrafico";
            this.gbGrafico.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGrafico.Size = new System.Drawing.Size(884, 375);
            this.gbGrafico.TabIndex = 35;
            this.gbGrafico.TabStop = false;
            this.gbGrafico.Text = "Histograma";
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1274, 795);
            this.Controls.Add(this.gbGrafico);
            this.Controls.Add(this.cbIntervalos);
            this.Controls.Add(this.lblIntervalos);
            this.Controls.Add(this.gbParametros);
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.gbValores);
            this.Controls.Add(this.nudValores);
            this.Controls.Add(this.lblValores);
            this.Controls.Add(this.cboDistribucion);
            this.Controls.Add(this.lblDistribucion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabajo Práctico 3 - Grupo E";
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.gbValores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLambda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesviacion)).EndInit();
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.gbGrafico.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.GroupBox gbValores;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.NumericUpDown nudValores;
        private System.Windows.Forms.Label lblValores;
        private System.Windows.Forms.NumericUpDown nudA;
        private System.Windows.Forms.Label lblIntervalo;
        private System.Windows.Forms.NumericUpDown nudB;
        private System.Windows.Forms.NumericUpDown nudLambda;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.NumericUpDown nudMedia;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.ComboBox cboDistribucion;
        private System.Windows.Forms.Label lblDistribucion;
        private System.Windows.Forms.Label lblLambda;
        private System.Windows.Forms.Label lblDesviacion;
        private System.Windows.Forms.NumericUpDown nudDesviacion;
        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.Label lblIntervalos;
        private System.Windows.Forms.ComboBox cbIntervalos;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.GroupBox gbGrafico;
    }
}