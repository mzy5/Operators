using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculeaza_Click(object sender, EventArgs e)
        {
            Double valFromNumar1, valFromNumar2;
            bool conversionIsSuccessful1, conversionIsSuccessful2;

            conversionIsSuccessful1 = Double.TryParse(txtNumar1.Text, out valFromNumar1);
            conversionIsSuccessful2 = Double.TryParse(txtNumar2.Text, out valFromNumar2);

            if (conversionIsSuccessful1 == true && conversionIsSuccessful2 == true)
            {
                var valSuma = valFromNumar1 + valFromNumar2;
                txtSuma.Text = Convert.ToString(valSuma);

                var valDiferenta = valFromNumar1 - valFromNumar2;
                txtDiferenta.Text = Convert.ToString(valDiferenta);

                var valProdus = valFromNumar1 * valFromNumar2;
                txtProdus.Text = Convert.ToString(valProdus);

                var valCat = valFromNumar1 / valFromNumar2;
                txtCat.Text = Convert.ToString(valCat);
            }
        }
    }
}
