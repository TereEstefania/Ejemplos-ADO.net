
namespace Winform_app
{
    partial class FrmPokemons
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
            this.DgvPokemos = new System.Windows.Forms.DataGridView();
            this.PbxImagenes = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPokemos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvPokemos
            // 
            this.DgvPokemos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPokemos.Location = new System.Drawing.Point(20, 67);
            this.DgvPokemos.Name = "DgvPokemos";
            this.DgvPokemos.Size = new System.Drawing.Size(785, 293);
            this.DgvPokemos.TabIndex = 0;
            this.DgvPokemos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPokemos_CellContentClick);
            this.DgvPokemos.SelectionChanged += new System.EventHandler(this.DgvPokemos_SelectionChanged);
            // 
            // PbxImagenes
            // 
            this.PbxImagenes.Location = new System.Drawing.Point(847, 67);
            this.PbxImagenes.Name = "PbxImagenes";
            this.PbxImagenes.Size = new System.Drawing.Size(362, 289);
            this.PbxImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxImagenes.TabIndex = 1;
            this.PbxImagenes.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(20, 367);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmPokemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 441);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.PbxImagenes);
            this.Controls.Add(this.DgvPokemos);
            this.Name = "FrmPokemons";
            this.Text = "Pokemons";
            this.Load += new System.EventHandler(this.FrmPokemons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPokemos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPokemos;
        private System.Windows.Forms.PictureBox PbxImagenes;
        private System.Windows.Forms.Button btnAgregar;
    }
}

