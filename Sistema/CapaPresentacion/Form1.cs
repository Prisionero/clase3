using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        Entidad ent = new Entidad();
        Negocio ng = new Negocio();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }
                public void login()
                {
                    int a ;
                    ent.usuario = textBox1.Text;
                    ent.pasword = textBox2.Text;
                    a = ng.N_login(ent);
                    if (a == 1)
                    {
                        Form2 frm = new Form2();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("usuario/password incorrecto");
                    }
                 
                }
           
        }
    }

