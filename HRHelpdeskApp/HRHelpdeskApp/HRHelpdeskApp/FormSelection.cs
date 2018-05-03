using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRHelpdeskApp
{
    public partial class FormSelection : Form
    {
        public FormSelection()
        {
            InitializeComponent();
        }

        private void generalInformationButton_Click(object sender, EventArgs e)
        {
            GeneralInformation screen = new GeneralInformation();
            this.Hide();
            screen.ShowDialog();
        }

        private void medicalInformationForm_Click(object sender, EventArgs e)
        {
            MedicalInformation screen = new MedicalInformation();
            this.Hide();
            screen.ShowDialog();
        }

        private void hippaButton_Click(object sender, EventArgs e)
        {
            HIPPA screen = new HIPPA();
            this.Hide();
            screen.ShowDialog();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
