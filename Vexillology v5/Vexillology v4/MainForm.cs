using AmericaFlagsClassLibrary;
namespace Vexillology_v4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            optionsComboBox.Items.Add("America Flags");
            optionsComboBox.Items.Add("World Flags");

            playButton.Click += button1_Click;

            elSalvadorPictureBox.MouseHover += elSalvadorPictureBox_MouseHover;
            elSalvadorPictureBox.MouseLeave += elSalvadorPictureBox_MouseLeave;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedForm = optionsComboBox.SelectedItem?.ToString();

            if (selectedForm == "America Flags")
            {
                AmericaFlagsForm americaFlagsForm = new AmericaFlagsForm();
                americaFlagsForm.Show();
            }
            else if (selectedForm == "World Flags")
            {
                WorldFlagsForm worldFlagsForm = new WorldFlagsForm();
                worldFlagsForm.Show();
            }
            else
            {
                MessageBox.Show("Seleccione una opcion");
            }

        }

        private void linkLabel1_DoubleClick(object sender, EventArgs e)
        {
            string url = "https://www.flaginstitute.org/wp/about/about-vexillology/";

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }


        private void elSalvadorPictureBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(elSalvadorPictureBox, "This is our flag");
        }

        private void elSalvadorPictureBox_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
