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
    public partial class login : Form
    {
        Controlodores.controladorLogin NcontroladorLogin = new Controlodores.controladorLogin();
        public login()
        {
            InitializeComponent();
        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if(usuario.Text!="" && password.Text != "")
            {
                if(NcontroladorLogin.GetList(usuario.Text, password.Text))
                {
                    Console.WriteLine("holaa");
                }
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            register reg = new register();
            ActiveForm.Hide();
            reg.Show();
        }
    }
}
