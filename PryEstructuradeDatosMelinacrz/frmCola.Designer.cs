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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCola));
            this.grbdatos = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lbltramite = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lstListado = new System.Windows.Forms.ListBox();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbElemento = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtramit = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbltramt = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbdatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.grbElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.grbdatos.Controls.Add(this.lblcodigo);
            this.grbdatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbdatos.ForeColor = System.Drawing.Color.Navy;
            this.grbdatos.Location = new System.Drawing.Point(28, 31);
            this.grbdatos.Name = "grbdatos";
            this.grbdatos.Size = new System.Drawing.Size(338, 144);
            this.grbdatos.TabIndex = 0;
            this.grbdatos.TabStop = false;
            this.grbdatos.Text = "Datos";
            this.grbdatos.Enter += new System.EventHandler(this.grbdatos_Enter);
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
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(19, 34);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(56, 15);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Codigo:";
            // 
            // lstListado
            // 
            this.lstListado.FormattingEnabled = true;
            this.lstListado.Location = new System.Drawing.Point(163, 215);
            this.lstListado.Name = "lstListado";
            this.lstListado.Size = new System.Drawing.Size(280, 173);
            this.lstListado.TabIndex = 2;
            this.lstListado.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvTabla.Location = new System.Drawing.Point(473, 215);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.Size = new System.Drawing.Size(345, 173);
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
            this.grbElemento.Controls.Add(this.lbltramt);
            this.grbElemento.Controls.Add(this.lblNombre);
            this.grbElemento.Controls.Add(this.lblCode);
            this.grbElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbElemento.ForeColor = System.Drawing.Color.Navy;
            this.grbElemento.Location = new System.Drawing.Point(473, 31);
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
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtramit
            // 
            this.txtramit.Enabled = false;
            this.txtramit.Location = new System.Drawing.Point(79, 103);
            this.txtramit.Name = "txtramit";
            this.txtramit.Size = new System.Drawing.Size(124, 21);
            this.txtramit.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.Enabled = false;
            this.txtname.Location = new System.Drawing.Point(81, 65);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(122, 21);
            this.txtname.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(81, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(122, 21);
            this.txtCodigo.TabIndex = 3;
            // 
            // lbltramt
            // 
            this.lbltramt.AutoSize = true;
            this.lbltramt.Location = new System.Drawing.Point(13, 106);
            this.lbltramt.Name = "lbltramt";
            this.lbltramt.Size = new System.Drawing.Size(60, 15);
            this.lbltramt.TabIndex = 2;
            this.lbltramt.Text = "Tramite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(13, 31);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(56, 15);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Codigo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryEstructuradeDatosMelinacrz.Properties.Resources.imgCola;
            this.pictureBox1.Location = new System.Drawing.Point(28, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(848, 413);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbElemento);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.lstListado);
            this.Controls.Add(this.grbdatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCola";
            this.Text = "frmCola";
            this.Load += new System.EventHandler(this.frmCola_Load);
            this.grbdatos.ResumeLayout(false);
            this.grbdatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.grbElemento.ResumeLayout(false);
            this.grbElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbdatos;
        private System.Windows.Forms.Label lbltramite;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.ListBox lstListado;
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
        private System.Windows.Forms.Label lbltramt;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}