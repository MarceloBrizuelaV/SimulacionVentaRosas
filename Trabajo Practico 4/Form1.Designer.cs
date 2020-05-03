namespace Trabajo_Practico_4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataTablaBase = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCantidadDia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSimulaciones = new System.Windows.Forms.TextBox();
            this.cbDiaAnterior = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtReserva = new System.Windows.Forms.TextBox();
            this.txtPromedioGanancia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnF = new System.Windows.Forms.Button();
            this.cbPuedeComprar = new System.Windows.Forms.CheckBox();
            this.cbVariables = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtPrecioCompraFaltantes = new System.Windows.Forms.TextBox();
            this.txtPrecioVentaCementerio = new System.Windows.Forms.TextBox();
            this.txtPerdidaPorFaltante = new System.Windows.Forms.TextBox();
            this.gbVariables = new System.Windows.Forms.GroupBox();
            this.cbNumerosAleatorios = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablaBase)).BeginInit();
            this.gbVariables.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTablaBase
            // 
            this.dataTablaBase.AllowUserToAddRows = false;
            this.dataTablaBase.AllowUserToDeleteRows = false;
            this.dataTablaBase.AllowUserToResizeRows = false;
            this.dataTablaBase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTablaBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTablaBase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataTablaBase.Location = new System.Drawing.Point(12, 12);
            this.dataTablaBase.Name = "dataTablaBase";
            this.dataTablaBase.ReadOnly = true;
            this.dataTablaBase.RowHeadersVisible = false;
            this.dataTablaBase.RowHeadersWidth = 51;
            this.dataTablaBase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTablaBase.Size = new System.Drawing.Size(500, 308);
            this.dataTablaBase.TabIndex = 0;

            // 
            // Column1
            // 
            this.Column1.HeaderText = "Dia";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Clima";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Demanda";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Venta";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // txtCantidadDia
            // 
            this.txtCantidadDia.Location = new System.Drawing.Point(12, 438);
            this.txtCantidadDia.Name = "txtCantidadDia";
            this.txtCantidadDia.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadDia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad de Dias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reserva";
            // 
            // txtSimulaciones
            // 
            this.txtSimulaciones.Location = new System.Drawing.Point(12, 399);
            this.txtSimulaciones.Name = "txtSimulaciones";
            this.txtSimulaciones.Size = new System.Drawing.Size(100, 20);
            this.txtSimulaciones.TabIndex = 5;
            // 
            // cbDiaAnterior
            // 
            this.cbDiaAnterior.AutoSize = true;
            this.cbDiaAnterior.Location = new System.Drawing.Point(224, 363);
            this.cbDiaAnterior.Margin = new System.Windows.Forms.Padding(2);
            this.cbDiaAnterior.Name = "cbDiaAnterior";
            this.cbDiaAnterior.Size = new System.Drawing.Size(81, 17);
            this.cbDiaAnterior.TabIndex = 6;
            this.cbDiaAnterior.Text = "Dia Anterior";
            this.cbDiaAnterior.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad de simulaciones";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtReserva
            // 
            this.txtReserva.Location = new System.Drawing.Point(173, 422);
            this.txtReserva.Name = "txtReserva";
            this.txtReserva.Size = new System.Drawing.Size(100, 20);
            this.txtReserva.TabIndex = 9;
            // 
            // txtPromedioGanancia
            // 
            this.txtPromedioGanancia.Enabled = false;
            this.txtPromedioGanancia.Location = new System.Drawing.Point(415, 338);
            this.txtPromedioGanancia.Margin = new System.Windows.Forms.Padding(2);
            this.txtPromedioGanancia.Name = "txtPromedioGanancia";
            this.txtPromedioGanancia.Size = new System.Drawing.Size(97, 20);
            this.txtPromedioGanancia.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 323);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ganancia Promedio";
            // 
            // btnF
            // 
            this.btnF.Location = new System.Drawing.Point(412, 435);
            this.btnF.Margin = new System.Windows.Forms.Padding(2);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(100, 23);
            this.btnF.TabIndex = 13;
            this.btnF.Text = "Calcular F";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // cbPuedeComprar
            // 
            this.cbPuedeComprar.AutoSize = true;
            this.cbPuedeComprar.Location = new System.Drawing.Point(413, 363);
            this.cbPuedeComprar.Name = "cbPuedeComprar";
            this.cbPuedeComprar.Size = new System.Drawing.Size(99, 17);
            this.cbPuedeComprar.TabIndex = 14;
            this.cbPuedeComprar.Text = "Puede Comprar";
            this.cbPuedeComprar.UseVisualStyleBackColor = true;
            // 
            // cbVariables
            // 
            this.cbVariables.AutoSize = true;
            this.cbVariables.Location = new System.Drawing.Point(12, 464);
            this.cbVariables.Name = "cbVariables";
            this.cbVariables.Size = new System.Drawing.Size(173, 17);
            this.cbVariables.TabIndex = 15;
            this.cbVariables.Text = "Modificar variables del ejercicio";
            this.cbVariables.UseVisualStyleBackColor = true;
            this.cbVariables.CheckedChanged += new System.EventHandler(this.cbVariables_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 24);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Precio de Venta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 76);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Precio de Compra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 76);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Precio compra faltantes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 24);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Precio Venta cementerio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(185, 128);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Perdida por faltante";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(129, 40);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVenta.TabIndex = 21;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(129, 92);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrecioCompra.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioCompra.TabIndex = 22;
            // 
            // txtPrecioCompraFaltantes
            // 
            this.txtPrecioCompraFaltantes.Location = new System.Drawing.Point(242, 92);
            this.txtPrecioCompraFaltantes.Name = "txtPrecioCompraFaltantes";
            this.txtPrecioCompraFaltantes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrecioCompraFaltantes.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioCompraFaltantes.TabIndex = 23;
            // 
            // txtPrecioVentaCementerio
            // 
            this.txtPrecioVentaCementerio.Location = new System.Drawing.Point(242, 40);
            this.txtPrecioVentaCementerio.Name = "txtPrecioVentaCementerio";
            this.txtPrecioVentaCementerio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrecioVentaCementerio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVentaCementerio.TabIndex = 24;
            // 
            // txtPerdidaPorFaltante
            // 
            this.txtPerdidaPorFaltante.Location = new System.Drawing.Point(184, 144);
            this.txtPerdidaPorFaltante.Name = "txtPerdidaPorFaltante";
            this.txtPerdidaPorFaltante.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPerdidaPorFaltante.Size = new System.Drawing.Size(100, 20);
            this.txtPerdidaPorFaltante.TabIndex = 25;
            // 
            // gbVariables
            // 
            this.gbVariables.Controls.Add(this.label5);
            this.gbVariables.Controls.Add(this.txtPerdidaPorFaltante);
            this.gbVariables.Controls.Add(this.label6);
            this.gbVariables.Controls.Add(this.txtPrecioVentaCementerio);
            this.gbVariables.Controls.Add(this.label7);
            this.gbVariables.Controls.Add(this.txtPrecioCompraFaltantes);
            this.gbVariables.Controls.Add(this.label8);
            this.gbVariables.Controls.Add(this.txtPrecioCompra);
            this.gbVariables.Controls.Add(this.label9);
            this.gbVariables.Controls.Add(this.txtPrecioVenta);
            this.gbVariables.Location = new System.Drawing.Point(12, 487);
            this.gbVariables.Name = "gbVariables";
            this.gbVariables.Size = new System.Drawing.Size(500, 180);
            this.gbVariables.TabIndex = 26;
            this.gbVariables.TabStop = false;
            this.gbVariables.Text = "Variables";
            // 
            // cbNumerosAleatorios
            // 
            this.cbNumerosAleatorios.AutoSize = true;
            this.cbNumerosAleatorios.Location = new System.Drawing.Point(12, 363);
            this.cbNumerosAleatorios.Name = "cbNumerosAleatorios";
            this.cbNumerosAleatorios.Size = new System.Drawing.Size(117, 17);
            this.cbNumerosAleatorios.TabIndex = 27;
            this.cbNumerosAleatorios.Text = "Numeros Aleatorios";
            this.cbNumerosAleatorios.UseVisualStyleBackColor = true;
            this.cbNumerosAleatorios.CheckedChanged += new System.EventHandler(this.cbNumerosAleatorios_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 679);
            this.Controls.Add(this.cbNumerosAleatorios);
            this.Controls.Add(this.gbVariables);
            this.Controls.Add(this.cbVariables);
            this.Controls.Add(this.cbPuedeComprar);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPromedioGanancia);
            this.Controls.Add(this.txtReserva);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDiaAnterior);
            this.Controls.Add(this.txtSimulaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidadDia);
            this.Controls.Add(this.dataTablaBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTablaBase)).EndInit();
            this.gbVariables.ResumeLayout(false);
            this.gbVariables.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCantidadDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSimulaciones;
        private System.Windows.Forms.CheckBox cbDiaAnterior;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtReserva;
        private object dataGridView1;
        private System.Windows.Forms.TextBox txtPromedioGanancia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.CheckBox cbPuedeComprar;
        private System.Windows.Forms.DataGridView dataTablaBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.CheckBox cbVariables;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtPrecioCompraFaltantes;
        private System.Windows.Forms.TextBox txtPrecioVentaCementerio;
        private System.Windows.Forms.TextBox txtPerdidaPorFaltante;
        private System.Windows.Forms.GroupBox gbVariables;
        private System.Windows.Forms.CheckBox cbNumerosAleatorios;
    }
}

