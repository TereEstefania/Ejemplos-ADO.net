namespace Ejemplos_ADO.net
{
    partial class fmrAltaPokemon
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
            this.lblNumeroPokemon = new System.Windows.Forms.Label();
            this.lblNombrePokemon = new System.Windows.Forms.Label();
            this.lblDescripcionPokemon = new System.Windows.Forms.Label();
            this.tbxNumeroPokemon = new System.Windows.Forms.TextBox();
            this.txtNombrePokemon = new System.Windows.Forms.TextBox();
            this.txtDescripcionPokemon = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.cboDebilidad = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDebilidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumeroPokemon
            // 
            this.lblNumeroPokemon.AutoSize = true;
            this.lblNumeroPokemon.Location = new System.Drawing.Point(45, 90);
            this.lblNumeroPokemon.Name = "lblNumeroPokemon";
            this.lblNumeroPokemon.Size = new System.Drawing.Size(44, 13);
            this.lblNumeroPokemon.TabIndex = 0;
            this.lblNumeroPokemon.Text = "Numero";
            // 
            // lblNombrePokemon
            // 
            this.lblNombrePokemon.AutoSize = true;
            this.lblNombrePokemon.Location = new System.Drawing.Point(45, 150);
            this.lblNombrePokemon.Name = "lblNombrePokemon";
            this.lblNombrePokemon.Size = new System.Drawing.Size(44, 13);
            this.lblNombrePokemon.TabIndex = 1;
            this.lblNombrePokemon.Text = "Nombre";
            // 
            // lblDescripcionPokemon
            // 
            this.lblDescripcionPokemon.AutoSize = true;
            this.lblDescripcionPokemon.Location = new System.Drawing.Point(26, 191);
            this.lblDescripcionPokemon.Name = "lblDescripcionPokemon";
            this.lblDescripcionPokemon.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcionPokemon.TabIndex = 2;
            this.lblDescripcionPokemon.Text = "Descripcion";
            // 
            // tbxNumeroPokemon
            // 
            this.tbxNumeroPokemon.Location = new System.Drawing.Point(105, 90);
            this.tbxNumeroPokemon.Name = "tbxNumeroPokemon";
            this.tbxNumeroPokemon.Size = new System.Drawing.Size(233, 20);
            this.tbxNumeroPokemon.TabIndex = 3;
            // 
            // txtNombrePokemon
            // 
            this.txtNombrePokemon.Location = new System.Drawing.Point(105, 143);
            this.txtNombrePokemon.Name = "txtNombrePokemon";
            this.txtNombrePokemon.Size = new System.Drawing.Size(233, 20);
            this.txtNombrePokemon.TabIndex = 4;
            // 
            // txtDescripcionPokemon
            // 
            this.txtDescripcionPokemon.Location = new System.Drawing.Point(105, 188);
            this.txtDescripcionPokemon.Name = "txtDescripcionPokemon";
            this.txtDescripcionPokemon.Size = new System.Drawing.Size(233, 20);
            this.txtDescripcionPokemon.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(48, 352);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(263, 352);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(105, 235);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(233, 21);
            this.cboTipo.TabIndex = 8;
            // 
            // cboDebilidad
            // 
            this.cboDebilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDebilidad.FormattingEnabled = true;
            this.cboDebilidad.Location = new System.Drawing.Point(105, 273);
            this.cboDebilidad.Name = "cboDebilidad";
            this.cboDebilidad.Size = new System.Drawing.Size(233, 21);
            this.cboDebilidad.TabIndex = 9;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(61, 243);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo";
            // 
            // lblDebilidad
            // 
            this.lblDebilidad.AutoSize = true;
            this.lblDebilidad.Location = new System.Drawing.Point(38, 281);
            this.lblDebilidad.Name = "lblDebilidad";
            this.lblDebilidad.Size = new System.Drawing.Size(51, 13);
            this.lblDebilidad.TabIndex = 11;
            this.lblDebilidad.Text = "Debilidad";
            // 
            // fmrAltaPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 452);
            this.Controls.Add(this.lblDebilidad);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cboDebilidad);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtDescripcionPokemon);
            this.Controls.Add(this.txtNombrePokemon);
            this.Controls.Add(this.tbxNumeroPokemon);
            this.Controls.Add(this.lblDescripcionPokemon);
            this.Controls.Add(this.lblNombrePokemon);
            this.Controls.Add(this.lblNumeroPokemon);
            this.Name = "fmrAltaPokemon";
            this.Text = "Nuevo Pokemon";
            this.Load += new System.EventHandler(this.fmrAltaPokemon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroPokemon;
        private System.Windows.Forms.Label lblNombrePokemon;
        private System.Windows.Forms.Label lblDescripcionPokemon;
        private System.Windows.Forms.TextBox tbxNumeroPokemon;
        private System.Windows.Forms.TextBox txtNombrePokemon;
        private System.Windows.Forms.TextBox txtDescripcionPokemon;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.ComboBox cboDebilidad;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDebilidad;
    }
}