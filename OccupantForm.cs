using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RentleForm.Classes;

namespace RentleForm
{
    public partial class OccupantForm : Form
    {
        private List<Guarantor> guarantors;
        private Guarantor guarantorSelected;
        public OccupantForm()
        {
            InitializeComponent();
        }

        private void OccupantForm_Load(object sender, EventArgs e)
        {
            FormUtils.FillGenderComboBox(ref cb_gender);
        }

        private async void onSubmit(object sender, EventArgs e)
        {

            bool isFieldsFilled = FormUtils.isFieldFilled(
                tb_name, tb_surname, tb_email, tb_gsm, 
                tb_nationalRegistry, tb_street, tb_zipcode, 
                tb_city, tb_country, cb_guarantor);

            if (isFieldsFilled)
            {
                MessageBox.Show("Chargement ...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string gender = (string)cb_gender.SelectedItem;
                string name = tb_name.Text;
                string surname = tb_surname.Text;
                string email = tb_email.Text;
                string gsm = tb_gsm.Text;
                string nationalRegistry = tb_nationalRegistry.Text;
                DateTime birthDate = dtp_birthDate.Value;
                string street = tb_street.Text;
                string zipcode = tb_zipcode.Text;
                string city = tb_city.Text;
                string country = tb_country.Text;

                Occupant occupant = new Occupant(null,gender, name, surname, email, gsm, nationalRegistry, birthDate, guarantorSelected.ID );
                occupant.Address = new Location(street, zipcode, city, country);

                Dictionary<string, object> occupantDic = Utils.ToDictionnary(occupant);
                string occupantJSON = Utils.ToJson(occupantDic);
                APIRes response = await Utils.Post(@"http://localhost:5000/api/occupants", occupantJSON);

                if (response.Success)
                {
                    MessageBox.Show(response.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show(response.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void onAsyncComboOpen(object sender, EventArgs e)
        {

            if (cb_guarantor.Items.Count == 0)
            {
                cb_guarantor.Items.Add("Chargement ....");
                guarantors = await Utils.Get<Guarantor>(@"http://localhost:5000/api/guarantors/withoutOccupant");
                string guarantorName;
                string GuarantorSurname;
                foreach (Guarantor guarantor in guarantors)
                {
                    guarantorName = guarantor.Name;
                    GuarantorSurname = guarantor.Surname;

                    cb_guarantor.Items.Add($"{guarantorName} {GuarantorSurname}");
                }
                cb_guarantor.Items.RemoveAt(0);
                if (guarantors.Count > 0) {
                    cb_guarantor.SelectedIndex = 0;
                    guarantorSelected = guarantors[0];
                }
                
            }

        }

        private void onComboBoxChange(object sender, EventArgs e)
        {
            int selectedIndex = cb_guarantor.SelectedIndex;
            guarantorSelected = guarantors[selectedIndex];
        }
    }
}
