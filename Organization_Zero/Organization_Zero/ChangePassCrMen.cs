using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organization_Zero
{
    public partial class ChangePassCrMen : Form
    {
        public ChangePassCrMen()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form crm = new CreatorMenu();
            Hide();
            crm.ShowDialog();
            Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Data.PassCr = textBox2.Text;
            Form crm = new CreatorMenu();
            Hide();
            crm.ShowDialog();
            Show();
        }
    }
}
