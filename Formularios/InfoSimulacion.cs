using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Formularios
{
    public partial class InfoSimulacion : Form
    {
        int ciclo;
        int distancia;
        public InfoSimulacion()
        {
            InitializeComponent();
        }

        public int getCiclo()
        {
            return this.ciclo;
        }
        public int getDistancia()
        {
            return this.distancia;
        }

        private void botoninfolisto_Click(object sender, EventArgs e)
        {
            ciclo = Convert.ToInt32(Ciclobox.Text);
            distancia = Convert.ToInt32(Distanciabox.Text);
            Close();
        }
    }
}
