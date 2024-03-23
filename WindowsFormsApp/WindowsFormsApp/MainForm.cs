using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private int totalNumRecords = 0;
        private int totalSumAge = 0;


        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (PersonRecordEditDialog dlg = new PersonRecordEditDialog(null))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    CreateNewPersonRecord(dlg);
                }
            }
        }

        private void UpdateStatistics()
        {
            textBoxNum.Text = $"{totalNumRecords}";
            textBoxSum.Text = $"{totalSumAge}";
        }

        private void CreateNewPersonRecord(PersonRecordEditDialog dlg)
        {
            PersonRecordUserControl newUserControl = new PersonRecordUserControl();


            newUserControl.ControlChanged += (sendler, e) =>
                {
                    RecalculateStatistics();
                };

            newUserControl.ControlDeleted += (sendler, e) =>
                    {
                        totalNumRecords--;
                        RecalculateStatistics();
                    };

            newUserControl.UpdateData(dlg.ID, dlg.Name, dlg.Old, dlg.Ot, dlg.Surname);

            flowLayoutPanelUsers.Controls.Add(newUserControl);
            totalNumRecords++;
            RecalculateStatistics();
        }

        private void RecalculateStatistics()
        {
            totalSumAge = 0;
            foreach (PersonRecordUserControl userControl in flowLayoutPanelUsers.Controls)
            {
                if (int.TryParse(userControl.textBoxOld.Text, out int age)) { totalSumAge += age; }
            }
            UpdateStatistics();
        }
    }
}
