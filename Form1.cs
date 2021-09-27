using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComplejosLibreria;
using System.Windows.Forms;

namespace FormComplejos_G4_2022_I
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            Complejo c1 = new Complejo(float.Parse(txtbRelaComplejo1.Text),float.Parse(txtbImaginariaComplejo1.Text));
            Complejo c2 = new Complejo(float.Parse(txtbRealComplejo2.Text), float.Parse(txtbImaginariaComplejo2.Text));
            Complejo c3 = c1 + c2;
            lbSumaComplejo.Text = c3.ToString();
        }
    }
}
