using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula11_Exemplo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void txtEvento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                if (txtEvento.Text != string.Empty)
                    txtMskData.Focus();
            }
        }
    }
}
