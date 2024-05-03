
namespace Catalogo
{
    partial class Formnuevoarticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formnuevoarticulo));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblcodArt = new System.Windows.Forms.Label();
            this.lblNombreart = new System.Windows.Forms.Label();
            this.lbldescripcionart = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.lblprecio = new System.Windows.Forms.Label();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblmarca = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.txbUrlimagen = new System.Windows.Forms.TextBox();
            this.pcbarticulo = new System.Windows.Forms.PictureBox();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbarticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Moccasin;
            this.btnAceptar.Location = new System.Drawing.Point(27, 224);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Moccasin;
            this.btnCancelar.Location = new System.Drawing.Point(163, 224);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblcodArt
            // 
            this.lblcodArt.AutoSize = true;
            this.lblcodArt.Location = new System.Drawing.Point(24, 29);
            this.lblcodArt.Name = "lblcodArt";
            this.lblcodArt.Size = new System.Drawing.Size(40, 13);
            this.lblcodArt.TabIndex = 0;
            this.lblcodArt.Text = "Codigo";
            // 
            // lblNombreart
            // 
            this.lblNombreart.AutoSize = true;
            this.lblNombreart.Location = new System.Drawing.Point(24, 55);
            this.lblNombreart.Name = "lblNombreart";
            this.lblNombreart.Size = new System.Drawing.Size(44, 13);
            this.lblNombreart.TabIndex = 10;
            this.lblNombreart.Text = "Nombre";
            // 
            // lbldescripcionart
            // 
            this.lbldescripcionart.AutoSize = true;
            this.lbldescripcionart.Location = new System.Drawing.Point(24, 84);
            this.lbldescripcionart.Name = "lbldescripcionart";
            this.lbldescripcionart.Size = new System.Drawing.Size(63, 13);
            this.lbldescripcionart.TabIndex = 11;
            this.lbldescripcionart.Text = "Descripcion";
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(117, 29);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(121, 20);
            this.txbCodigo.TabIndex = 0;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(117, 55);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(121, 20);
            this.txbNombre.TabIndex = 1;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(117, 81);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txbDescripcion.TabIndex = 2;
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(22, 114);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(37, 13);
            this.lblprecio.TabIndex = 12;
            this.lblprecio.Text = "Precio";
            // 
            // txbPrecio
            // 
            this.txbPrecio.Location = new System.Drawing.Point(117, 107);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(121, 20);
            this.txbPrecio.TabIndex = 3;
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(117, 157);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(121, 21);
            this.cmbMarca.TabIndex = 5;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(117, 184);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 6;
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(24, 165);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(37, 13);
            this.lblmarca.TabIndex = 14;
            this.lblmarca.Text = "Marca";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(24, 187);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(52, 13);
            this.lblcategoria.TabIndex = 15;
            this.lblcategoria.Text = "Categoria";
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(24, 138);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(58, 13);
            this.lblUrlImagen.TabIndex = 13;
            this.lblUrlImagen.Text = "Url Imagen";
            // 
            // txbUrlimagen
            // 
            this.txbUrlimagen.Location = new System.Drawing.Point(117, 131);
            this.txbUrlimagen.Name = "txbUrlimagen";
            this.txbUrlimagen.Size = new System.Drawing.Size(121, 20);
            this.txbUrlimagen.TabIndex = 4;
            this.txbUrlimagen.Leave += new System.EventHandler(this.txbUrlimagen_Leave);
            // 
            // pcbarticulo
            // 
            this.pcbarticulo.Location = new System.Drawing.Point(311, 29);
            this.pcbarticulo.Name = "pcbarticulo";
            this.pcbarticulo.Size = new System.Drawing.Size(198, 218);
            this.pcbarticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbarticulo.TabIndex = 17;
            this.pcbarticulo.TabStop = false;
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.BackColor = System.Drawing.Color.Moccasin;
            this.btnCargarImagen.Location = new System.Drawing.Point(243, 132);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(20, 20);
            this.btnCargarImagen.TabIndex = 19;
            this.btnCargarImagen.Text = "+";
            this.btnCargarImagen.UseVisualStyleBackColor = false;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "*";
            // 
            // Formnuevoarticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(555, 266);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.pcbarticulo);
            this.Controls.Add(this.txbUrlimagen);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.lbldescripcionart);
            this.Controls.Add(this.lblNombreart);
            this.Controls.Add(this.lblcodArt);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formnuevoarticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Articulo";
            this.Load += new System.EventHandler(this.Formnuevoarticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbarticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblcodArt;
        private System.Windows.Forms.Label lblNombreart;
        private System.Windows.Forms.Label lbldescripcionart;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.TextBox txbUrlimagen;
        private System.Windows.Forms.PictureBox pcbarticulo;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}