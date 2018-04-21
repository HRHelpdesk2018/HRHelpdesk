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
    public partial class MedicalInformation : Form
    {
        public MedicalInformation()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            FormSelection screen = new FormSelection();
            this.Hide();
            screen.ShowDialog();
        }
    }
}
