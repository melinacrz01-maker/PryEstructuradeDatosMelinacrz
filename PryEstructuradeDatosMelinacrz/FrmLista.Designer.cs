namespace PryEstructuradeDatosMelinacrz
{
    partial class FrmLista
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
            this.grpElemento = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTramite = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpEliminar = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblTramte = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCodg = new System.Windows.Forms.Label();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpElemento.SuspendLayout();
            this.grpEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // grpElemento
            // 
            this.grpElemento.Controls.Add(this.btnAgregar);
            this.grpElemento.Controls.Add(this.txtTramite);
            this.grpElemento.Controls.Add(this.txtName);
            this.grpElemento.Controls.Add(this.txtCode);
            this.grpElemento.Controls.Add(this.lblTramite);
            this.grpElemento.Controls.Add(this.lblNombre);
            this.grpElemento.Controls.Add(this.lblCodigo);
            this.grpElemento.Location = new System.Drawing.Point(228, 33);
            this.grpElemento.Name = "grpElemento";
            this.grpElemento.Size = new System.Drawing.Size(261, 199);
            this.grpElemento.TabIndex = 0;
            this.grpElemento.TabStop = false;
            this.grpElemento.Text = "Nuevo Elemento";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(21, 36);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(61, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Còdigo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(21, 74);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.Location = new System.Drawing.Point(21, 109);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(64, 16);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Tramite:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(88, 36);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(141, 20);
            this.txtCode.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(88, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(88, 108);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(141, 20);
            this.txtTramite.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(126, 150);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 34);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // grpEliminar
            // 
            this.grpEliminar.Controls.Add(this.btnEliminar);
            this.grpEliminar.Controls.Add(this.textBox1);
            this.grpEliminar.Controls.Add(this.textBox2);
            this.grpEliminar.Controls.Add(this.textBox3);
            this.grpEliminar.Controls.Add(this.lblTramte);
            this.grpEliminar.Controls.Add(this.lblName);
            this.grpEliminar.Controls.Add(this.lblCodg);
            this.grpEliminar.Location = new System.Drawing.Point(514, 33);
            this.grpEliminar.Name = "grpEliminar";
            this.grpEliminar.Size = new System.Drawing.Size(261, 199);
            this.grpEliminar.TabIndex = 1;
            this.grpEliminar.TabStop = false;
            this.grpEliminar.Text = "Elemento a Eliminar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(126, 150);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 34);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(88, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 20);
            this.textBox3.TabIndex = 3;
            // 
            // lblTramte
            // 
            this.lblTramte.AutoSize = true;
            this.lblTramte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramte.Location = new System.Drawing.Point(21, 109);
            this.lblTramte.Name = "lblTramte";
            this.lblTramte.Size = new System.Drawing.Size(64, 16);
            this.lblTramte.TabIndex = 2;
            this.lblTramte.Text = "Tramite:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(21, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre:";
            // 
            // lblCodg
            // 
            this.lblCodg.AutoSize = true;
            this.lblCodg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodg.Location = new System.Drawing.Point(21, 36);
            this.lblCodg.Name = "lblCodg";
            this.lblCodg.Size = new System.Drawing.Size(61, 16);
            this.lblCodg.TabIndex = 0;
            this.lblCodg.Text = "Còdigo:";
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(228, 267);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(190, 147);
            this.lstLista.TabIndex = 2;
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvTable.Location = new System.Drawing.Point(433, 267);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(342, 150);
            this.dgvTable.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Còdigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tramite";
            this.Column3.Name = "Column3";
            // 
            // FrmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.grpEliminar);
            this.Controls.Add(this.grpElemento);
            this.Name = "FrmLista";
            this.Text = "FrmLista";
            this.grpElemento.ResumeLayout(false);
            this.grpElemento.PerformLayout();
            this.grpEliminar.ResumeLayout(false);
            this.grpEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpElemento;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grpEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblTramte;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCodg;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}