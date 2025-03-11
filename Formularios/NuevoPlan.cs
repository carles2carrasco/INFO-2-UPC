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
    public partial class NuevoPlan : Form
    {
        FlightPlan p;
        public NuevoPlan()
        {
            InitializeComponent();
        }

        private void botonListo_Click(object sender, EventArgs e)
        {
            p = new FlightPlan();
            p.ID = IDbox.Text;
            p.compañia = Compañiabox.Text;
            p.velocidad = Convert.ToDouble(Velocidadbox.Text);
            p.IX = Convert.ToDouble(IXbox.Text);
            p.IY = Convert.ToDouble(IYbox.Text);
            p.FX = Convert.ToDouble(FXbox.Text);
            p.FY = Convert.ToDouble(FYbox.Text);
            Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //p = new FlightPlan();
            //p.ID = "FP001";
            //p.compañia = "IBERIA";
            //p.velocidad = 100;
            //p.IX = 50;
            //p.IY = 50;
            //p.FX = 450;
            //p.FY = 450;

            //Close();
        }
        public FlightPlan DameFP()
        {
            return this.p;
        }
    }
}
