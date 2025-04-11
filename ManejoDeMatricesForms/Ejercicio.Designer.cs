namespace ManejoDeMatricesForms
{
    partial class formEjercicio
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.dataGridMatriz = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.numFilas = new System.Windows.Forms.NumericUpDown();
            this.numColumnas = new System.Windows.Forms.NumericUpDown();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panelDibujo = new System.Windows.Forms.Panel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSimetria = new System.Windows.Forms.Button();
            this.btnDiagonal = new System.Windows.Forms.Button();
            this.btnInvertir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.panelDibujoInvertida = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAyuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumnas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(402, 182);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(129, 37);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear Matriz\n";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // dataGridMatriz
            // 
            this.dataGridMatriz.AllowUserToAddRows = false;
            this.dataGridMatriz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMatriz.Location = new System.Drawing.Point(20, 19);
            this.dataGridMatriz.Name = "dataGridMatriz";
            this.dataGridMatriz.RowHeadersWidth = 51;
            this.dataGridMatriz.RowTemplate.Height = 24;
            this.dataGridMatriz.Size = new System.Drawing.Size(365, 278);
            this.dataGridMatriz.TabIndex = 1;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(12, 14);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(129, 39);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Matriz Normal";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // numFilas
            // 
            this.numFilas.Location = new System.Drawing.Point(402, 75);
            this.numFilas.Name = "numFilas";
            this.numFilas.Size = new System.Drawing.Size(120, 22);
            this.numFilas.TabIndex = 3;
            // 
            // numColumnas
            // 
            this.numColumnas.Location = new System.Drawing.Point(402, 137);
            this.numColumnas.Name = "numColumnas";
            this.numColumnas.Size = new System.Drawing.Size(120, 22);
            this.numColumnas.TabIndex = 4;
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(21, 17);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSalida.Size = new System.Drawing.Size(510, 179);
            this.txtSalida.TabIndex = 5;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(417, 14);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(129, 39);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Regresar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(282, 14);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(129, 39);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panelDibujo
            // 
            this.panelDibujo.Location = new System.Drawing.Point(141, 504);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(202, 150);
            this.panelDibujo.TabIndex = 8;
            this.panelDibujo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDibujo_Paint);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(399, 56);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(50, 17);
            this.lblTexto.TabIndex = 9;
            this.lblTexto.Text = "FILAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "COLUMNAS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnSimetria);
            this.panel1.Controls.Add(this.btnDiagonal);
            this.panel1.Location = new System.Drawing.Point(1157, 484);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 167);
            this.panel1.TabIndex = 9;
            // 
            // btnSimetria
            // 
            this.btnSimetria.Location = new System.Drawing.Point(4, 100);
            this.btnSimetria.Name = "btnSimetria";
            this.btnSimetria.Size = new System.Drawing.Size(125, 39);
            this.btnSimetria.TabIndex = 8;
            this.btnSimetria.Text = "Es Simétrica";
            this.btnSimetria.UseVisualStyleBackColor = true;
            this.btnSimetria.Click += new System.EventHandler(this.btnSimetria_Click);
            // 
            // btnDiagonal
            // 
            this.btnDiagonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagonal.Location = new System.Drawing.Point(4, 29);
            this.btnDiagonal.Name = "btnDiagonal";
            this.btnDiagonal.Size = new System.Drawing.Size(126, 46);
            this.btnDiagonal.TabIndex = 9;
            this.btnDiagonal.Text = "Mostrar Diagonales";
            this.btnDiagonal.UseVisualStyleBackColor = true;
            this.btnDiagonal.Click += new System.EventHandler(this.btnDiagonal_Click);
            // 
            // btnInvertir
            // 
            this.btnInvertir.Location = new System.Drawing.Point(147, 14);
            this.btnInvertir.Name = "btnInvertir";
            this.btnInvertir.Size = new System.Drawing.Size(129, 39);
            this.btnInvertir.TabIndex = 10;
            this.btnInvertir.Text = "Invertir Matriz";
            this.btnInvertir.UseVisualStyleBackColor = true;
            this.btnInvertir.Click += new System.EventHandler(this.btnInvertir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "MATRIZ NORMAL";
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.ItemHeight = 16;
            this.lstResultados.Location = new System.Drawing.Point(21, 20);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(365, 132);
            this.lstResultados.TabIndex = 12;
            // 
            // panelDibujoInvertida
            // 
            this.panelDibujoInvertida.Location = new System.Drawing.Point(406, 504);
            this.panelDibujoInvertida.Name = "panelDibujoInvertida";
            this.panelDibujoInvertida.Size = new System.Drawing.Size(202, 150);
            this.panelDibujoInvertida.TabIndex = 9;
            this.panelDibujoInvertida.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDibujoInvertida_Paint_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(403, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "MATRIZ INVERTIDA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(473, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(271, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1003, 95);
            this.label5.TabIndex = 15;
            this.label5.Text = "MANEJO DE MATRICES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.numFilas);
            this.panel2.Controls.Add(this.lblTexto);
            this.panel2.Controls.Add(this.numColumnas);
            this.panel2.Controls.Add(this.dataGridMatriz);
            this.panel2.Controls.Add(this.btnCrear);
            this.panel2.Location = new System.Drawing.Point(141, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 311);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btnInvertir);
            this.panel3.Controls.Add(this.btnCerrar);
            this.panel3.Controls.Add(this.btnImprimir);
            this.panel3.Controls.Add(this.btnLimpiar);
            this.panel3.Location = new System.Drawing.Point(740, 158);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 63);
            this.panel3.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.txtSalida);
            this.panel4.Location = new System.Drawing.Point(740, 247);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(550, 208);
            this.panel4.TabIndex = 18;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Controls.Add(this.lstResultados);
            this.panel6.Location = new System.Drawing.Point(740, 484);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(411, 167);
            this.panel6.TabIndex = 18;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(1348, 711);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(129, 31);
            this.btnAyuda.TabIndex = 11;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // formEjercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1489, 754);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelDibujoInvertida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelDibujo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formEjercicio";
            this.Text = "EJERCICIO";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumnas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DataGridView dataGridMatriz;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.NumericUpDown numFilas;
        private System.Windows.Forms.NumericUpDown numColumnas;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel panelDibujo;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInvertir;
        private System.Windows.Forms.Button btnDiagonal;
        private System.Windows.Forms.Button btnSimetria;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Panel panelDibujoInvertida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnAyuda;
    }
}

