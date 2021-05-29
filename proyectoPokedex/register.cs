using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoPokedex
{
    public partial class register : Form
    {
        Controlodores.controladorReg NcontroladorReg = new Controlodores.controladorReg();
        public register()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            login log = new login();
            ActiveForm.Hide();
            log.Show();
        }
    }
}
