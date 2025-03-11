using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MisClases;

namespace Formularios
{
    public partial class Principal : Form
    {
        FPList miLista = new FPList();
        

        public Principal()
        {
            InitializeComponent();
        }

        private void añadirPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoPlan form = new NuevoPlan();
            form.ShowDialog();
            FlightPlan p = form.DameFP();
            miLista.Pon(p);
            MessageBox.Show("Plan añadido");
        }

        private void InfoSimubox_Click(object sender, EventArgs e)
        {
            InfoSimulacion form = new InfoSimulacion();
            form.ShowDialog();
            MessageBox.Show("distancia de seguridad "+ Convert.ToString(form.getDistancia()));
            MessageBox.Show("tiempo de ciclo "+ Convert.ToString(form.getCiclo()));
        }

        private void SIM_Click(object sender, EventArgs e)
        {
            Simulador form = new Simulador();
            form.SetPicCoord(miLista);
            form.ShowDialog();
        }
    }
}

