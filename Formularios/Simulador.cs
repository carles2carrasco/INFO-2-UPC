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
    public partial class Simulador : Form
    {
        public FPList miLista;
        public PictureBox[] misPics = new PictureBox[100];
        int numPics=0;

        public Simulador()
        {
            InitializeComponent();
        }

        private void Simulador_Load(object sender, EventArgs e)
        {
            for(int i=0;i<miLista.NumFPs();i++)
            {
                PictureBox pic = new PictureBox();
                pic.Size = new Size(20, 20);
                pic.BackColor = Color.Green;
                pic.Location = new Point(Convert.ToInt32(miLista.numLista[i].GetIX), Convert.ToInt32(miLista.numLista[i].GetIY));
                panelSIM.Controls.Add(pic);
                misPics[numPics] = pic;
                numPics = numPics + 1;
            }
        }

        public void SetPicCoord(FPList p)
        {
            miLista = p;
        }

    }
}
