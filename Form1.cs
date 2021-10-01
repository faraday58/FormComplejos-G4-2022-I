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

        bool c1ImError = false;
        bool c2ImError = false;

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (txtbImaginariaComplejo1.Text == ""    )
                {
                    string error = "Debes ingresar un valor numérico";
                    c1ImError = true;
                    throw new ApplicationException(error);
                }
                if (txtbImaginariaComplejo2.Text == "")
                {
                    string error = "Debes ingresar un valor númerico";
                    c2ImError = true;
                    throw new ApplicationException(error);
                }

                Complejo c1 = new Complejo(float.Parse(txtbRelaComplejo1.Text), float.Parse(txtbImaginariaComplejo1.Text));
                Complejo c2 = new Complejo(float.Parse(txtbRealComplejo2.Text), float.Parse(txtbImaginariaComplejo2.Text));
                Complejo c3 = c1 + c2;
                lbSumaComplejo.Text = c3.ToString();
            }
            
            catch( ApplicationException error )
            {
                if( c1ImError   )
                {
                    errorProvider1.SetError(txtbImaginariaComplejo1, error.Message);
                }else if (c2ImError)
                {
                    errorProvider1.SetError(txtbImaginariaComplejo2, error.Message);
                }

                
            }
            catch(FormatException error)
            {
                MessageBox.Show("Ingresa un número. \n   "+ error.Message);
            }
            catch(Exception error)
            {
                MessageBox.Show("Error " + error.Message);
            }
        }

        private void btnConjugar_Click(object sender, EventArgs e)
        {
            Complejo c1 = new Complejo(float.Parse(txtbRelaComplejo1.Text), float.Parse(txtbImaginariaComplejo1.Text));
            c1 = ~c1;

            lbSumaComplejo.Text = c1.ToString();

        }

        
    }
}
