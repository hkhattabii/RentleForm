using System;
using System.Windows.Forms;
using RentleForm.Classes;

namespace RentleForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch (button.Name)
            {
                case "bt_guarantorForm":
                    GuarantorForm guarantorForm = new GuarantorForm();
                    guarantorForm.ShowDialog();
                    break;
                case "bt_occupantForm":
                    OccupantForm occupantForm = new OccupantForm();
                    occupantForm.ShowDialog();
                    break;
                case "bt_generateGuarantorDeposit":
                    MessageBox.Show("Selectionnez un locataire", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Grid occupantGrid = new Grid();
                    occupantGrid.ShowDialog<Occupant>("http://localhost:5000/api/occupants");
                    break;
                default:
                    break;
            }
        }

    }
}
