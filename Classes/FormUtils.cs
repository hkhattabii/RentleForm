using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentleForm.Classes
{
    public static class FormUtils
    {
        public static void FillGenderComboBox(ref ComboBox comboBox)
        {
            comboBox.Items.Add("Homme");
            comboBox.Items.Add("Femme");
            comboBox.SelectedIndex = 0;
        }

        public static bool isFieldFilled(params Control[] textBoxes)
        {
            foreach (Control textBox in textBoxes)
            {
                if (textBox.Text.Length == 0) { 
                    MessageBox.Show("Veuillez remplir tous les champs.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }
    }
}
