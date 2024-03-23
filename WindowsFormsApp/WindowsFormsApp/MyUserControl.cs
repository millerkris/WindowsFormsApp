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
    public partial class MyUserControl : UserControl
    {
        public string LabelText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string Password
        {
            get { return textBoxPassword.Text; }
            set { textBoxPassword.Text = value; }
        }

        public MyUserControl()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void buttonToggleVisibility_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.PasswordChar == '\0' && textBoxPassword.UseSystemPasswordChar == false)
            {
                // Показываем пароль
                textBoxPassword.PasswordChar = '*';
                textBoxPassword.UseSystemPasswordChar = true;
            }
            else
            {
                // Скрываем пароль
                textBoxPassword.PasswordChar = '\0';
                textBoxPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
