namespace PryEstructuradeDatosMelinacrz
{
    partial class frmConsultasBD
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
            this.dgvTablaConsultas = new System.Windows.Forms.DataGridView();
            this.listConsultas = new System.Windows.Forms.ListBox();
            this.btnlistarconsultas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTablaConsultas
            // 
            this.dgvTablaConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaConsultas.Location = new System.Drawing.Point(60, 322);
            this.dgvTablaConsultas.Name = "dgvTablaConsultas";
            this.dgvTablaConsultas.Size = new System.Drawing.Size(588, 219);
            this.dgvTablaConsultas.TabIndex = 0;
            // 
            // listConsultas
            // 
            this.listConsultas.FormattingEnabled = true;
            this.listConsultas.Location = new System.Drawing.Point(60, 57);
            this.listConsultas.Name = "listConsultas";
            this.listConsultas.Size = new System.Drawing.Size(588, 186);
            this.listConsultas.TabIndex = 1;
            // 
            // btnlistarconsultas
            // 
            this.btnlistarconsultas.BackColor = System.Drawing.Color.MintCream;
            this.btnlistarconsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistarconsultas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnlistarconsultas.Location = new System.Drawing.Point(535, 261);
            this.btnlistarconsultas.Name = "btnlistarconsultas";
            this.btnlistarconsultas.Size = new System.Drawing.Size(113, 39);
            this.btnlistarconsultas.TabIndex = 2;
            this.btnlistarconsultas.Text = "Listar";
            this.btnlistarconsultas.UseVisualStyleBackColor = false;
            // 
            // frmConsultasBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 597);
            this.Controls.Add(this.btnlistarconsultas);
            this.Controls.Add(this.listConsultas);
            this.Controls.Add(this.dgvTablaConsultas);
            this.Name = "frmConsultasBD";
            this.Text = "frmConsultasBD";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaConsultas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTablaConsultas;
        private System.Windows.Forms.ListBox listConsultas;
        private System.Windows.Forms.Button btnlistarconsultas;
    }
}