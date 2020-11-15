using System;
using System.Windows.Forms;

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
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
