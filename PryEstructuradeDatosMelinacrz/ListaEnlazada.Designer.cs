namespace PryEstructuradeDatosMelinacrz
{
    partial class ListaEnlazada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaEnlazada));
            this.grpEliminarDoble = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnEliminarDatos = new System.Windows.Forms.Button();
            this.lblCodg = new System.Windows.Forms.Label();
            this.grpElementoDoble = new System.Windows.Forms.GroupBox();
            this.btnAgregarDatos = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dgvTabladedatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LstDeDatos = new System.Windows.Forms.ListBox();
            this.grpDate = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpEliminarDoble.SuspendLayout();
            this.grpElementoDoble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabladedatos)).BeginInit();
            this.grpDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEliminarDoble
            // 
            this.grpEliminarDoble.BackColor = System.Drawing.Color.FloralWhite;
            this.grpEliminarDoble.Controls.Add(this.comboBox1);
            this.grpEliminarDoble.Controls.Add(this.btnEliminarDatos);
            this.grpEliminarDoble.Controls.Add(this.lblCodg);
            this.grpEliminarDoble.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEliminarDoble.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.grpEliminarDoble.Location = new System.Drawing.Point(558, 25);
            this.grpEliminarDoble.Name = "grpEliminarDoble";
            this.grpEliminarDoble.Size = new System.Drawing.Size(261, 199);
            this.grpEliminarDoble.TabIndex = 3;
            this.grpEliminarDoble.TabStop = false;
            this.grpEliminarDoble.Text = "Elemento a Eliminar";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // btnEliminarDatos
            // 
            this.btnEliminarDatos.BackColor = System.Drawing.Color.Navy;
            this.btnEliminarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDatos.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEliminarDatos.Location = new System.Drawing.Point(136, 150);
            this.btnEliminarDatos.Name = "btnEliminarDatos";
            this.btnEliminarDatos.Size = new System.Drawing.Size(103, 34);
            this.btnEliminarDatos.TabIndex = 6;
            this.btnEliminarDatos.Text = "Eliminar";
            this.btnEliminarDatos.UseVisualStyleBackColor = false;
            this.btnEliminarDatos.Click += new System.EventHandler(this.btnEliminarDatos_Click);
            // 
            // lblCodg
            // 
            this.lblCodg.AutoSize = true;
            this.lblCodg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodg.Location = new System.Drawing.Point(22, 58);
            this.lblCodg.Name = "lblCodg";
            this.lblCodg.Size = new System.Drawing.Size(61, 16);
            this.lblCodg.TabIndex = 0;
            this.lblCodg.Text = "Còdigo:";
            // 
            // grpElementoDoble
            // 
            this.grpElementoDoble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.grpElementoDoble.Controls.Add(this.btnAgregarDatos);
            this.grpElementoDoble.Controls.Add(this.txtTramite);
            this.grpElementoDoble.Controls.Add(this.txtName);
            this.grpElementoDoble.Controls.Add(this.txtCode);
            this.grpElementoDoble.Controls.Add(this.lblTramite);
            this.grpElementoDoble.Controls.Add(this.lblNombre);
            this.grpElementoDoble.Controls.Add(this.lblCodigo);
            this.grpElementoDoble.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpElementoDoble.ForeColor = System.Drawing.Color.LightBlue;
            this.grpElementoDoble.Location = new System.Drawing.Point(272, 25);
            this.grpElementoDoble.Name = "grpElementoDoble";
            this.grpElementoDoble.Size = new System.Drawing.Size(261, 199);
            this.grpElementoDoble.TabIndex = 2;
            this.grpElementoDoble.TabStop = false;
            this.grpElementoDoble.Text = "Nuevo Elemento";
            // 
            // btnAgregarDatos
            // 
            this.btnAgregarDatos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAgregarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAgregarDatos.Location = new System.Drawing.Point(126, 150);
            this.btnAgregarDatos.Name = "btnAgregarDatos";
            this.btnAgregarDatos.Size = new System.Drawing.Size(103, 34);
            this.btnAgregarDatos.TabIndex = 6;
            this.btnAgregarDatos.Text = "Agregar";
            this.btnAgregarDatos.UseVisualStyleBackColor = false;
            this.btnAgregarDatos.Click += new System.EventHandler(this.btnAgregarDatos_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(88, 108);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(141, 20);
            this.txtTramite.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(88, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(88, 36);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(141, 20);
            this.txtCode.TabIndex = 3;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.ForeColor = System.Drawing.Color.PowderBlue;
            this.lblTramite.Location = new System.Drawing.Point(21, 109);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(64, 16);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Tramite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.LightBlue;
            this.lblNombre.Location = new System.Drawing.Point(21, 74);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.LightBlue;
            this.lblCodigo.Location = new System.Drawing.Point(21, 36);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(61, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Còdigo:";
            // 
            // dgvTabladedatos
            // 
            this.dgvTabladedatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabladedatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvTabladedatos.Location = new System.Drawing.Point(335, 30);
            this.dgvTabladedatos.Name = "dgvTabladedatos";
            this.dgvTabladedatos.Size = new System.Drawing.Size(342, 150);
            this.dgvTabladedatos.TabIndex = 6;
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
            // LstDeDatos
            // 
            this.LstDeDatos.FormattingEnabled = true;
            this.LstDeDatos.Location = new System.Drawing.Point(18, 33);
            this.LstDeDatos.Name = "LstDeDatos";
            this.LstDeDatos.Size = new System.Drawing.Size(263, 147);
            this.LstDeDatos.TabIndex = 5;
            // 
            // grpDate
            // 
            this.grpDate.BackColor = System.Drawing.Color.FloralWhite;
            this.grpDate.Controls.Add(this.dgvTabladedatos);
            this.grpDate.Controls.Add(this.LstDeDatos);
            this.grpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.grpDate.Location = new System.Drawing.Point(89, 246);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(730, 205);
            this.grpDate.TabIndex = 7;
            this.grpDate.TabStop = false;
            this.grpDate.Text = "Listado en una lista y una Grilla";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryEstructuradeDatosMelinacrz.Properties.Resources._0_F7Qnr7Zs_dobles_s_;
            this.pictureBox1.Location = new System.Drawing.Point(29, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ListaEnlazada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 481);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpDate);
            this.Controls.Add(this.grpEliminarDoble);
            this.Controls.Add(this.grpElementoDoble);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaEnlazada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Doblemente Enlazada";
            this.grpEliminarDoble.ResumeLayout(false);
            this.grpEliminarDoble.PerformLayout();
            this.grpElementoDoble.ResumeLayout(false);
            this.grpElementoDoble.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabladedatos)).EndInit();
            this.grpDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEliminarDoble;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnEliminarDatos;
        private System.Windows.Forms.Label lblCodg;
        private System.Windows.Forms.GroupBox grpElementoDoble;
        private System.Windows.Forms.Button btnAgregarDatos;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridView dgvTabladedatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox LstDeDatos;
        private System.Windows.Forms.GroupBox grpDate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}