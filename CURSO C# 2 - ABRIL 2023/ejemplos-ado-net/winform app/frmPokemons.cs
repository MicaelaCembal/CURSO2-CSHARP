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

namespace winform_app
{
    public partial class frmPokemons : Form
    {
        private List<Pokemon> listaPokemon;

        public frmPokemons()
        {
            InitializeComponent();
            dgvPokemons.SelectionChanged += dgvPokemons_SelectionChanged;
        }

        private void frmPokemons_Load(object sender, EventArgs e)
        {
            cargar(); 
        }
        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }
        private void cargar()
        {
            try
            {
                PokemonNegocio negocio = new PokemonNegocio();
                listaPokemon = negocio.listar();
                dgvPokemons.DataSource = listaPokemon;
                dgvPokemons.Columns["UrlImagen"].Visible = false;

                if (listaPokemon != null && listaPokemon.Count > 0)
                {
                    pictureBoxPokemons.Load(listaPokemon[0].UrlImagen);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); 
            }
            
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxPokemons.Load(imagen);
            }
            catch (Exception ex)
            {
                pictureBoxPokemons.Load("https://img.freepik.com/vector-premium/icono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_399089-1290.jpg");

            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaPokemon alta = new frmAltaPokemon();
            alta.ShowDialog(); // no permite abrir otra ventana
            cargar(); 
        }
    }
}

