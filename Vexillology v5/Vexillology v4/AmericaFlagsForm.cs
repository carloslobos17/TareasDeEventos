using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AmericaFlagsClassLibrary;

namespace Vexillology_v4
{
    public partial class AmericaFlagsForm : Form
    {

        public AmericaFlagsForm()
        {

            InitializeComponent();
            AmericaFlags americaFlags = new AmericaFlags();


            AmericaComboBox.DataSource = americaFlags.GetAllFlags();
            AmericaComboBox.DisplayMember = "Name";
            AmericaComboBox.ValueMember = "Id";
        }



        private void AmericaConfirmButton_Click(object sender, EventArgs e)
        {

            int selectedIndex = AmericaComboBox.SelectedIndex;

            if (selectedIndex == 0)
            {
                americaResultsLabel.Text = "Score: 3/3";
            }
            else if (selectedIndex == 1)
            {
                americaResultsLabel.Text = "Score: 1/3";
            }
            else if (selectedIndex == 2)
            {
                americaResultsLabel.Text = "Score: 1/3";
            }
            else if (selectedIndex == 3)
            {
                americaResultsLabel.Text = "Score: 0/3";
            }
            else if (selectedIndex == 4)
            {
                americaResultsLabel.Text = "Score: 1/3";
            }
            else if (selectedIndex == 5)
            {
                americaResultsLabel.Text = "Score: 0/3";
            }
            else
            {
                MessageBox.Show("Seleccione una opcion");
            }
        }
    }
}
