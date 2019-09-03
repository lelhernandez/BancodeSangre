using BancoDeSangre;
using BancoDeSangre.BL;
using BancoDeSangre.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeSangre
{
    public partial class Menu : Form
    {
        DonantesBL _donantesBL;
        TipodeSangreBL _tipodeSangreBL;
        GeneroBL _generoBL;
        ComprobanteBL _comprobanteBL;

        public Menu()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath+@"\img\Fondo3.jpg");
            this.BackgroundImage = img;

            _donantesBL = new DonantesBL();
            _tipodeSangreBL = new TipodeSangreBL();
            _generoBL = new GeneroBL();
            _comprobanteBL = new ComprobanteBL();
        }

        private void donantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formDonantes = new FormDonantes();
            formDonantes.MdiParent = this;
            formDonantes.CargarDatos(_donantesBL, _generoBL, _tipodeSangreBL);
            formDonantes.Show();
        }

        private void tiposDeSangreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formTipoSangre = new TipoDeSangre();
            formTipoSangre.MdiParent = this;
            formTipoSangre.CargarDatos(_tipodeSangreBL);
            formTipoSangre.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comprobanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formComprobante = new ComprobanteDonacion();
            formComprobante.MdiParent = this;

            formComprobante.CargarDatos(_comprobanteBL, _donantesBL, _tipodeSangreBL);

            formComprobante.Show();
        }

        private void donantesSanosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formDonantesSanos = new DonantesSanos();
            formDonantesSanos.MdiParent = this;

            formDonantesSanos.Show();
        }
    }
}
