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
    public delegate void UserControlChangedEventHandler(object sender, EventArgs e);

    public partial class PersonRecordUserControl : UserControl
    {
        public PersonRecordUserControl()
        {
            InitializeComponent();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            PersonRecordEditDialog dlg = new PersonRecordEditDialog(this);
            dlg.ShowDialog();

            if(DialogResult.OK == dlg.DialogResult) 
            {
                textBoxID.Text = dlg.ID;
                textBoxName.Text = dlg.Name;
                textBoxOld.Text = dlg.Old;
                textBoxOt.Text = dlg.Ot;
                textBoxSurname.Text = dlg.Surname;
                OnControlChanged(EventArgs.Empty);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.Dispose();
            OnControlDeleted(EventArgs.Empty);
        }

        public event UserControlChangedEventHandler ControlChanged;
        public event UserControlChangedEventHandler ControlDeleted;

        protected virtual void OnControlChanged(EventArgs e)
        {
            ControlChanged?.Invoke(this, e);
        }

        protected virtual void OnControlDeleted(EventArgs e)
        {
            ControlDeleted?.Invoke(this, e);
        }

        public void UpdateData(string id, string name, string age, string ot, string surname)
        {
            textBoxID.Text = id;
            textBoxName.Text = name;
            textBoxOld.Text = age;
            textBoxOt.Text = ot;
            textBoxSurname.Text = surname;
        }

    }
}
