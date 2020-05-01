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
            this.Ganancias = new System.Windows.Forms.DataGridView();
            this.gananciaDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPromedioGanancia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablaBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ganancias)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTablaBase
            // 
            this.dataTablaBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTablaBase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataTablaBase.Location = new System.Drawing.Point(51, 43);
            this.dataTablaBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataTablaBase.Name = "dataTablaBase";
            this.dataTablaBase.RowHeadersWidth = 51;
            this.dataTablaBase.Size = new System.Drawing.Size(449, 236);
            this.dataTablaBase.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // txtCantidadDia
            // 
            this.txtCantidadDia.Location = new System.Drawing.Point(16, 406);
            this.txtCantidadDia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidadDia.Name = "txtCantidadDia";
            this.txtCantidadDia.Size = new System.Drawing.Size(132, 22);
            this.txtCantidadDia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 386);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad de Dia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 386);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reserva";
            // 
            // txtSimulaciones
            // 
            this.txtSimulaciones.Location = new System.Drawing.Point(325, 406);
            this.txtSimulaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSimulaciones.Name = "txtSimulaciones";
            this.txtSimulaciones.Size = new System.Drawing.Size(168, 22);
            this.txtSimulaciones.TabIndex = 5;
            // 
            // cbDiaAnterior
            // 
            this.cbDiaAnterior.AutoSize = true;
            this.cbDiaAnterior.Location = new System.Drawing.Point(122, 356);
            this.cbDiaAnterior.Name = "cbDiaAnterior";
            this.cbDiaAnterior.Size = new System.Drawing.Size(81, 17);
            this.cbDiaAnterior.TabIndex = 6;
            this.cbDiaAnterior.Text = "Dia Anterior";
            this.cbDiaAnterior.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 386);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad de simulaciones";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 484);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtReserva
            // 
            this.txtReserva.Location = new System.Drawing.Point(163, 406);
            this.txtReserva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReserva.Name = "txtReserva";
            this.txtReserva.Size = new System.Drawing.Size(132, 22);
            this.txtReserva.TabIndex = 9;
            // 
            // Ganancias
            // 
            this.Ganancias.AllowUserToAddRows = false;
            this.Ganancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ganancias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gananciaDia,
            this.Column5});
            this.Ganancias.Location = new System.Drawing.Point(507, 34);
            this.Ganancias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ganancias.Name = "Ganancias";
            this.Ganancias.RowHeadersWidth = 51;
            this.Ganancias.Size = new System.Drawing.Size(245, 236);
            this.Ganancias.TabIndex = 10;
            // 
            // gananciaDia
            // 
            this.gananciaDia.HeaderText = "Ganancia Dia";
            this.gananciaDia.MinimumWidth = 6;
            this.gananciaDia.Name = "gananciaDia";
            this.gananciaDia.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // txtPromedioGanancia
            // 
            this.txtPromedioGanancia.Enabled = false;
            this.txtPromedioGanancia.Location = new System.Drawing.Point(507, 330);
            this.txtPromedioGanancia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPromedioGanancia.Name = "txtPromedioGanancia";
            this.txtPromedioGanancia.Size = new System.Drawing.Size(100, 22);
            this.txtPromedioGanancia.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ganancia Promedio";
            // 
            // btnF
            // 
            this.btnF.Location = new System.Drawing.Point(305, 484);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(109, 28);
            this.btnF.TabIndex = 13;
            this.btnF.Text = "Calcular F";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 554);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPromedioGanancia);
            this.Controls.Add(this.Ganancias);
            this.Controls.Add(this.txtReserva);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDiaAnterior);
            this.Controls.Add(this.txtSimulaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidadDia);
            this.Controls.Add(this.dataTablaBase);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataTablaBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ganancias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTablaBase;
        private System.Windows.Forms.TextBox txtCantidadDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSimulaciones;
        private System.Windows.Forms.CheckBox cbDiaAnterior;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txtReserva;
        private object dataGridView1;
        private System.Windows.Forms.DataGridView Ganancias;
        private System.Windows.Forms.DataGridViewTextBoxColumn gananciaDia;
        private System.Windows.Forms.TextBox txtPromedioGanancia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnF;
    }
}

