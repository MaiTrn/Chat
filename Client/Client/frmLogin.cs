using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            AcceptButton = Enter;
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (txtlogin.Text != string.Empty)
                DialogResult = DialogResult.OK;
            else
            {
                MessageBox.Show("Please enter a name!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
