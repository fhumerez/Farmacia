using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Recuperamos los valores del formulario
            int ci = int.Parse(txtCi.Text);
            string usuario = txtUsuario.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string contraseña = txtContraseña.Text;
            string cargo = cmbCargo.Text;


            //Armamos un objeto con esos valores
            Farmaceutico usu = new Farmaceutico { 
                Ci = ci,
                Usuario = usuario,
                NombreFarm = nombre,    
                ApellidoFarm = apellido,    
                Contrasena=contraseña,
                Cargo=cargo
            };
            //Agregamos el objeto al conjunto de telefonos
            using (var ddbb = new FarmaciaContext())
            {
                var user = ddbb.Farmaceuticos;
                user.Add(usu);
                //guardamos
                try
                {
                    ddbb.SaveChanges();
                    MessageBox.Show("Registro insertado", "Insercion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiaTexto();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
                

            }
        }
        public void limpiaTexto()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Clear();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbCargo.SelectedIndex = 0;
        }
    }
}
