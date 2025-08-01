using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace Ejemplos_ADO.net
{
    public partial class fmrAltaPokemon : Form
    {
        public fmrAltaPokemon()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Pokemon newPokemon = new Pokemon();
            PokemonService negocio = new PokemonService();
            try
            {
                newPokemon.Numero = int.Parse(tbxNumeroPokemon.Text);
                newPokemon.Nombre = txtNombrePokemon.Text;
                newPokemon.Descripcion = txtDescripcionPokemon.Text;
                newPokemon.Tipo = (Elemento)cboTipo.SelectedItem;
                newPokemon.Debilidad = (Elemento)cboDebilidad.SelectedItem;

                negocio.Agregar(newPokemon);
                MessageBox.Show("Pokemon Agregado Exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fmrAltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoPokemon elementoNegocio = new ElementoPokemon();

            try
            {
                cboTipo.DataSource = elementoNegocio.Listar();
                cboDebilidad.DataSource = elementoNegocio.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
