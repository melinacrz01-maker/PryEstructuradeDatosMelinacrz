namespace PryEstructuradeDatosMelinacrz
{
    partial class frmCola
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
            this.grbdatos = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lbltramite = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listaDatos = new System.Windows.Forms.ListBox();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbElemento = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtramit = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbdatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.grbElemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbdatos
            // 
            this.grbdatos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grbdatos.Controls.Add(this.btnAgregar);
            this.grbdatos.Controls.Add(this.txtTramite);
            this.grbdatos.Controls.Add(this.txtNombre);
            this.grbdatos.Controls.Add(this.txtCode);
            this.grbdatos.Controls.Add(this.lbltramite);
            this.grbdatos.Controls.Add(this.lblName);
            this.grbdatos.Controls.Add(this.label1);
            this.grbdatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbdatos.ForeColor = System.Drawing.Color.Navy;
            this.grbdatos.Location = new System.Drawing.Point(12, 25);
            this.grbdatos.Name = "grbdatos";
            this.grbdatos.Size = new System.Drawing.Size(338, 144);
            this.grbdatos.TabIndex = 0;
            this.grbdatos.TabStop = false;
            this.grbdatos.Text = "Datos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Navy;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAgregar.Location = new System.Drawing.Point(219, 89);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 36);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = " 🆕 Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(82, 100);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(122, 21);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(82, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(122, 21);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(82, 31);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(122, 21);
            this.txtCode.TabIndex = 3;
            // 
            // lbltramite
            // 
            this.lbltramite.AutoSize = true;
            this.lbltramite.Location = new System.Drawing.Point(15, 100);
            this.lbltramite.Name = "lbltramite";
            this.lbltramite.Size = new System.Drawing.Size(60, 15);
            this.lbltramite.TabIndex = 2;
            this.lbltramite.Text = "Tramite:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // listaDatos
            // 
            this.listaDatos.FormattingEnabled = true;
            this.listaDatos.Location = new System.Drawing.Point(12, 215);
            this.listaDatos.Name = "listaDatos";
            this.listaDatos.Size = new System.Drawing.Size(338, 173);
            this.listaDatos.TabIndex = 2;
            this.listaDatos.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvTabla.Location = new System.Drawing.Point(395, 213);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.Size = new System.Drawing.Size(342, 175);
            this.dgvTabla.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
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
            // grbElemento
            // 
            this.grbElemento.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grbElemento.Controls.Add(this.btnEliminar);
            this.grbElemento.Controls.Add(this.txtramit);
            this.grbElemento.Controls.Add(this.txtname);
            this.grbElemento.Controls.Add(this.txtCodigo);
            this.grbElemento.Controls.Add(this.label2);
            this.grbElemento.Controls.Add(this.label3);
            this.grbElemento.Controls.Add(this.label4);
            this.grbElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbElemento.ForeColor = System.Drawing.Color.Navy;
            this.grbElemento.Location = new System.Drawing.Point(386, 25);
            this.grbElemento.Name = "grbElemento";
            this.grbElemento.Size = new System.Drawing.Size(342, 144);
            this.grbElemento.TabIndex = 4;
            this.grbElemento.TabStop = false;
            this.grbElemento.Text = "Elemento a Eliminar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Navy;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEliminar.Location = new System.Drawing.Point(223, 92);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 36);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = " 🗑️ Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // txtramit
            // 
            this.txtramit.Location = new System.Drawing.Point(79, 103);
            this.txtramit.Name = "txtramit";
            this.txtramit.Size = new System.Drawing.Size(124, 21);
            this.txtramit.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(81, 65);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(122, 21);
            this.txtname.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(81, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(122, 21);
            this.txtCodigo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tramite:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Codigo:";
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(749, 413);
            this.Controls.Add(this.grbElemento);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.listaDatos);
            this.Controls.Add(this.grbdatos);
            this.Name = "frmCola";
            this.Text = "frmCola";
            this.grbdatos.ResumeLayout(false);
            this.grbdatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.grbElemento.ResumeLayout(false);
            this.grbElemento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbdatos;
        private System.Windows.Forms.Label lbltramite;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listaDatos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.GroupBox grbElemento;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtramit;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}