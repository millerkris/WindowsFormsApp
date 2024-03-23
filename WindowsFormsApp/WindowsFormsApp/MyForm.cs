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
    public partial class MyForm : Form
    {
        public MyUserControl MyUserControl { get; private set; }


        public MyForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ShowDialogButton_Click(object sender, EventArgs e)
        {
            MyForm myForm = new MyForm();
            DialogResult result = myForm.ShowDialog();
            MyUserControl myUserControlInstance = new MyUserControl();

            MessageBox.Show("Результат диалога: " + result);

            if (result == DialogResult.OK)
            {
                string enteredPassword = result.MyUserControl.Password; // Получаем введенный пароль из формы MyForm
                myUserControlInstance.Password = enteredPassword; // Устанавливаем введенный пароль на вашем экземпляре MyUserControl
            }
        }
    }
}
