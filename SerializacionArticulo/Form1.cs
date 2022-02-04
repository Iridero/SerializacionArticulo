using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializacionArticulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Archivo de datos|*.dat";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Auxiliar aux = new Auxiliar();
                Articulo articulo = new Articulo { 
                    Codigo = (int)nmrCodigo.Value,
                    Descripcion=txtDescripcion.Text,
                    Precio=nmrPrecio.Value
                };
                aux.Guardar(dialog.FileName, articulo);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivo de datos|*.dat";
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                Auxiliar aux = new Auxiliar();
                Articulo art = aux.Cargar(dialog.FileName);
                nmrCodigo.Value = art.Codigo;
                txtDescripcion.Text = art.Descripcion;
                nmrPrecio.Value = art.Precio;
            }
        }
    }
}
