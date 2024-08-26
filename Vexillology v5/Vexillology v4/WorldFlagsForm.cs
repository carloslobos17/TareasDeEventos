using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vexillology_v4
{
    public partial class WorldFlagsForm : Form
    {
        public WorldFlagsForm()
        {
            InitializeComponent();
            WorldFlagsClassLibrary.WorldClass worldFlags = new WorldFlagsClassLibrary.WorldClass();


            worldComboBox.DataSource = worldFlags.GetAllFlags();
            worldComboBox.DisplayMember = "Name";
            worldComboBox.ValueMember = "Id";
        }

        private void worldConfirmButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = worldComboBox.SelectedIndex;

            if (selectedIndex == 0)
            {
                worldResultsLabel.Text = "Score: 1/3";
            }
            else if (selectedIndex == 1)
            {
                worldResultsLabel.Text = "Score: 0/3";
            }
            else if (selectedIndex == 2)
            {
                worldResultsLabel.Text = "Score: 0/3";
            }
            else if (selectedIndex == 3)
            {
                worldResultsLabel.Text = "Score: 1/3";
            }
            else if (selectedIndex == 4)
            {
                worldResultsLabel.Text = "Score: 1/3";
            }
            else if (selectedIndex == 5)
            {
                worldResultsLabel.Text = "Score: 3/3 Congratulations!";
            }
            else
            {
                MessageBox.Show("Seleccione una opcion");
            }
        }
    }
}
