namespace MVC_vista_
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
            this.dtpaises = new System.Windows.Forms.DataGridView();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lbltitulodtg = new System.Windows.Forms.Label();
            this.lblpais = new System.Windows.Forms.Label();
            this.txtpais = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnguardarcambios = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.idpais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrepais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtpaises)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpaises
            // 
            this.dtpaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtpaises.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpais,
            this.nombrepais});
            this.dtpaises.Location = new System.Drawing.Point(12, 241);
            this.dtpaises.Name = "dtpaises";
            this.dtpaises.Size = new System.Drawing.Size(243, 150);
            this.dtpaises.TabIndex = 0;
            this.dtpaises.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtpaises_CellClick);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(72, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(126, 20);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Gestion Paises";
            // 
            // lbltitulodtg
            // 
            this.lbltitulodtg.AutoSize = true;
            this.lbltitulodtg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulodtg.Location = new System.Drawing.Point(12, 214);
            this.lbltitulodtg.Name = "lbltitulodtg";
            this.lbltitulodtg.Size = new System.Drawing.Size(54, 15);
            this.lbltitulodtg.TabIndex = 2;
            this.lbltitulodtg.Text = "Paises:";
            // 
            // lblpais
            // 
            this.lblpais.AutoSize = true;
            this.lblpais.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpais.Location = new System.Drawing.Point(12, 95);
            this.lblpais.Name = "lblpais";
            this.lblpais.Size = new System.Drawing.Size(104, 15);
            this.lblpais.TabIndex = 3;
            this.lblpais.Text = "Ingrese un pais:";
            // 
            // txtpais
            // 
            this.txtpais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpais.Location = new System.Drawing.Point(122, 91);
            this.txtpais.Name = "txtpais";
            this.txtpais.Size = new System.Drawing.Size(100, 22);
            this.txtpais.TabIndex = 4;
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(12, 139);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(79, 34);
            this.btnguardar.TabIndex = 5;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnguardarcambios
            // 
            this.btnguardarcambios.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarcambios.Location = new System.Drawing.Point(76, 179);
            this.btnguardarcambios.Name = "btnguardarcambios";
            this.btnguardarcambios.Size = new System.Drawing.Size(134, 32);
            this.btnguardarcambios.TabIndex = 6;
            this.btnguardarcambios.Text = "Guardar  Cambios";
            this.btnguardarcambios.UseVisualStyleBackColor = true;
            this.btnguardarcambios.Click += new System.EventHandler(this.btnguardarcambios_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(180, 139);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 31);
            this.btneliminar.TabIndex = 7;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(97, 139);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(77, 34);
            this.btncancelar.TabIndex = 8;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(62, 57);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(54, 15);
            this.lblcodigo.TabIndex = 9;
            this.lblcodigo.Text = "Codigo:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(123, 51);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(75, 21);
            this.txtcodigo.TabIndex = 10;
            // 
            // idpais
            // 
            this.idpais.DataPropertyName = "idpais";
            this.idpais.HeaderText = "Código";
            this.idpais.Name = "idpais";
            this.idpais.Width = 80;
            // 
            // nombrepais
            // 
            this.nombrepais.DataPropertyName = "nombrepais";
            this.nombrepais.HeaderText = "Nombre Pais";
            this.nombrepais.Name = "nombrepais";
            this.nombrepais.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 418);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardarcambios);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtpais);
            this.Controls.Add(this.lblpais);
            this.Controls.Add(this.lbltitulodtg);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.dtpaises);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtpaises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtpaises;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lbltitulodtg;
        private System.Windows.Forms.Label lblpais;
        private System.Windows.Forms.TextBox txtpais;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnguardarcambios;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpais;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrepais;
    }
}

