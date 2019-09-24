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
    public partial class ChangePassSpMen : Form
    {
        public ChangePassSpMen()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form spm = new CreatorMenu();
            Hide();
            spm.ShowDialog();
            Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Data.PassSp = textBox2.Text;
            Form spm = new CreatorMenu();
            Hide();
            spm.ShowDialog();
            Show();
        }
    }
}
