using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class PersonRecordEditDialog : Form
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Ot {  get; set; }
        public string Old {  get; set; }
        public string ID { get; set; }

        public PersonRecordEditDialog(PersonRecordUserControl personRecord)
        {
            InitializeComponent();
            if (personRecord != null)
            {
                textBoxID.Text = personRecord.textBoxID.Text;
                textBoxSurname.Text = personRecord.textBoxSurname.Text;
                textBoxName.Text = personRecord.textBoxName.Text;
                textBoxOt.Text = personRecord.textBoxOt.Text;
                textBoxOld.Text = personRecord.textBoxOld.Text;
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {    

            if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxSurname.Text) ||
                  string.IsNullOrWhiteSpace(textBoxOt.Text) || string.IsNullOrWhiteSpace(textBoxOld.Text) ||
                  string.IsNullOrWhiteSpace(textBoxID.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!textBoxOld.Text.All(char.IsDigit) || !textBoxID.Text.All(char.IsDigit))
            {
                MessageBox.Show("Пожалуйста, заполните поля 'ID' и 'Лет' - цифрами.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Name = textBoxName.Text;
                Surname = textBoxSurname.Text;
                Ot = textBoxOt.Text;
                Old = textBoxOld.Text;
                ID = textBoxID.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }
    }
}
