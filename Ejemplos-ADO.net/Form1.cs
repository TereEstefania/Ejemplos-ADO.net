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
using Ejemplos_ADO.net;
using negocio;

namespace Winform_app
{
    public partial class FrmPokemons : Form
    {
        //hay que recordar que esto es una clase y como tal puede contener atributos 

        private List<Pokemon> Listapokemons;
        public FrmPokemons()
        {
            InitializeComponent();
        }

        private void FrmPokemons_Load(object sender, EventArgs e)
        {
            //desde aca vamos a invocar la bbdd
            PokemonService serve = new PokemonService();
            Listapokemons = serve.Listar();//me va a traer los datos de la base que voy a guardar en la lista para luego poder manipularlo
            DgvPokemos.DataSource = Listapokemons;//DataSource trae los datos que van a ser mostrados en el data grid view y listar optiene estos datos
            //de estamanera yo no puedo manipular la lista, no puedo generar la imagen
            DgvPokemos.Columns["UrlImagen"].Visible = false;
            cargarImagen(Listapokemons[0].UrlImagen);
        }

        private void DgvPokemos_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccion = (Pokemon)DgvPokemos.CurrentRow.DataBoundItem;
            cargarImagen(seleccion.UrlImagen);

        }

        private void cargarImagen(string imagen)
        {
            try
            {
                PbxImagenes.Load(imagen);
            }
            catch (Exception)
            {
                PbxImagenes.Load("https://winguweb.org/wp-content/uploads/2022/09/placeholder.png");
            }
        }

        private void DgvPokemos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            fmrAltaPokemon alta = new fmrAltaPokemon();
            alta.ShowDialog();
        }
    }
}
