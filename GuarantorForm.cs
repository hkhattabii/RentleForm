using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentleForm
{
    public partial class GuarantorForm : Form
    {
        public GuarantorForm()
        {
            InitializeComponent();
        }

        private void GuarantorForm_Load(object sender, EventArgs e)
        {
            FillGenderComboBox();
        }

        private void FillGenderComboBox()
        {
            cb_gender.Items.Add("Homme");
            cb_gender.Items.Add("Femme");
            cb_gender.SelectedIndex = 0;
        }

        private bool IsFieldFilled()
        {
            if (
                tb_name.Text.Length == 0 || tb_surname.Text.Length == 0 ||
                tb_email.Text.Length == 0 || tb_gsm.Text.Length == 0 ||
                tb_street.Text.Length == 0 || tb_zipcode.Text.Length == 0 ||
                tb_city.Text.Length == 0 || tb_country.Text.Length == 0
            )
            {
                MessageBox.Show("Veuillez remplir tous les champs.","",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }

        private void onSubmit(object sender, EventArgs e)
        {
            bool isFieldFilled = IsFieldFilled();

            if (isFieldFilled)
            {
                string gender = (string) cb_gender.SelectedItem;
                string name = tb_name.Name;
                string surname = tb_surname.Text;
                string email = tb_email.Text;
                string gsm = tb_gsm.Text;
                string street = tb_street.Text;
                string zipcode = tb_zipcode.Text;
                string city = tb_city.Text;
                string country = tb_country.Text;

                Guarantor guarantor = new Guarantor(gender, name, surname, email, gsm);
                guarantor.Location = new Location(street, zipcode, city, country);

                Dictionary<string, object> dic = Utils.ToDictionnary(guarantor);

                Console.Write(dic);
            }
        }
    }
}
