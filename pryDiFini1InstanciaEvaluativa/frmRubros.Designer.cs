namespace pryDiFini1InstanciaEvaluativa
{
    partial class frmRubros
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRubros));
            label1 = new Label();
            cmbRubros = new ComboBox();
            dgbRubros = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            ValorStock = new DataGridViewTextBoxColumn();
            label2 = new Label();
            lblCantidadArticulosListados = new Label();
            label3 = new Label();
            lblTotal = new Label();
            btnMostrar = new Button();
            btnExportar = new Button();
            lnkInformacion = new LinkLabel();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgbRubros).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(166, 31);
            label1.TabIndex = 0;
            label1.Text = "Elige un rubro";
            // 
            // cmbRubros
            // 
            cmbRubros.FormattingEnabled = true;
            cmbRubros.Location = new Point(184, 39);
            cmbRubros.Name = "cmbRubros";
            cmbRubros.Size = new Size(151, 28);
            cmbRubros.TabIndex = 1;
            // 
            // dgbRubros
            // 
            dgbRubros.AllowUserToAddRows = false;
            dgbRubros.AllowUserToDeleteRows = false;
            dgbRubros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbRubros.Columns.AddRange(new DataGridViewColumn[] { Codigo, Descripcion, Costo, Stock, ValorStock });
            dgbRubros.Location = new Point(12, 90);
            dgbRubros.Name = "dgbRubros";
            dgbRubros.ReadOnly = true;
            dgbRubros.RowHeadersWidth = 51;
            dgbRubros.Size = new Size(677, 214);
            dgbRubros.TabIndex = 2;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 125;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Width = 125;
            // 
            // Costo
            // 
            Costo.HeaderText = "Costo";
            Costo.MinimumWidth = 6;
            Costo.Name = "Costo";
            Costo.ReadOnly = true;
            Costo.Width = 125;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 125;
            // 
            // ValorStock
            // 
            ValorStock.HeaderText = "Valor en stock";
            ValorStock.MinimumWidth = 6;
            ValorStock.Name = "ValorStock";
            ValorStock.ReadOnly = true;
            ValorStock.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(225, 318);
            label2.Name = "label2";
            label2.Size = new Size(337, 31);
            label2.TabIndex = 3;
            label2.Text = "Cantidad de articulos listados:";
            // 
            // lblCantidadArticulosListados
            // 
            lblCantidadArticulosListados.BorderStyle = BorderStyle.Fixed3D;
            lblCantidadArticulosListados.Location = new Point(562, 318);
            lblCantidadArticulosListados.Name = "lblCantidadArticulosListados";
            lblCantidadArticulosListados.Size = new Size(127, 34);
            lblCantidadArticulosListados.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(489, 364);
            label3.Name = "label3";
            label3.Size = new Size(73, 31);
            label3.TabIndex = 5;
            label3.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.BorderStyle = BorderStyle.Fixed3D;
            lblTotal.Location = new Point(562, 361);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(127, 34);
            lblTotal.TabIndex = 6;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(139, 369);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(121, 29);
            btnMostrar.TabIndex = 7;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(266, 369);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(121, 29);
            btnExportar.TabIndex = 8;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            // 
            // lnkInformacion
            // 
            lnkInformacion.AutoSize = true;
            lnkInformacion.Location = new Point(12, 426);
            lnkInformacion.Name = "lnkInformacion";
            lnkInformacion.Size = new Size(168, 20);
            lnkInformacion.TabIndex = 9;
            lnkInformacion.TabStop = true;
            lnkInformacion.Text = "Informacion del alumno";
            lnkInformacion.LinkClicked += lnkInformacion_LinkClicked;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 369);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(121, 29);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmRubros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 465);
            Controls.Add(btnSalir);
            Controls.Add(lnkInformacion);
            Controls.Add(btnExportar);
            Controls.Add(btnMostrar);
            Controls.Add(lblTotal);
            Controls.Add(label3);
            Controls.Add(lblCantidadArticulosListados);
            Controls.Add(label2);
            Controls.Add(dgbRubros);
            Controls.Add(cmbRubros);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRubros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rubros ";
            WindowState = FormWindowState.Maximized;
            Load += frmRubros_Load;
            ((System.ComponentModel.ISupportInitialize)dgbRubros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbRubros;
        private DataGridView dgbRubros;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Costo;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn ValorStock;
        private Label label2;
        private Label lblCantidadArticulosListados;
        private Label label3;
        private Label lblTotal;
        private Button btnMostrar;
        private Button btnExportar;
        private LinkLabel lnkInformacion;
        private Button btnSalir;
    }
}
