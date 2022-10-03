//using entity
using Microsoft.Win32;

namespace Farmacia
{
    public partial class Form1 : Form
    {
        string rol;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            //tabControl1.Controls.Add(tabPage2);

        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password=txtpassword.Text;   
           
            using(var ddbb = new FarmaciaContext())

            {
                var usu = ddbb.Farmaceuticos
                .SingleOrDefault(us => us.Usuario == usuario && us.Contrasena==password);
                //string listaT = "";
                if (usu != null)
                {
                   // listaT += $"Nombre completo: {est.nombre} {est.apellido}; Nac.: {est.fecha_nac} ({est.ci})\n";
                    

                    switch (usu.Cargo)
                    {
                        case "cajero":
                            MessageBox.Show("Rol Cajero","Login",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            tabControl1.Controls.Add(tabPage2);
                            tabControl1.Controls.Remove(tabPage1);
                            slabelUsuario.Text = usu.Usuario.ToString();
                            slabelCi.Text=usu.Ci.ToString();
                            break;
                        case "dueño":
                            MessageBox.Show("Rol Propietario", "Login", MessageBoxButtons.OK,MessageBoxIcon.Information);
                            tabControl1.Controls.Add(tabPage3);
                            tabControl1.Controls.Remove(tabPage1);
                            slabelUsuario.Text = usu.Usuario.ToString();
                            slabelCi.Text = usu.Ci.ToString();
                            break;

                        default:
                            
                            break;

                    }
                   

                }
                else
                {
                    MessageBox.Show("Usuario no registrado", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //label21.Text = listaT;
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            tabControl1.Controls.Remove(tabPage2);
           tabControl1.Controls.Remove(tabPage3);

            //slabelUsuario.Text = "aSaaA";
            //cargamos los medicamentos
            var ddbb = new FarmaciaContext();
            var med = ddbb.Medicamentos.ToList();
           
            foreach (var t in med)
               cmbProducto.Items.Add(t.CodMed);
            cmbProducto.SelectedIndex = 0;
            //cargamos todos los clientes registrados
            var nits=ddbb.Clientes.ToList();
            foreach (var t in nits)
                cmbNit.Items.Add(t.Nit);
            cmbNit.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            actualizarGrilla();
           
        }
        public void actualizarGrilla()
        {
            using (var ddbb = new FarmaciaContext())

            {
                var usu = ddbb.Farmaceuticos.ToList();
                grdFarmaceuticos.DataSource = usu;
                grdFarmaceuticos.Columns[6].Visible = false;
                grdFarmaceuticos.Columns[0].ReadOnly = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //obtener el valor PK
            int ci = int.Parse(grdFarmaceuticos.CurrentRow.Cells[0].Value.ToString());
            //armar un objeto con ese valor
            Farmaceutico usu = new Farmaceutico { Ci = ci };
            //eliminar del conjunto de estudiantes
            using (var ddbb = new FarmaciaContext())
            {

                if (MessageBox.Show("Estas seguro de eliminar Usuario: ? " + grdFarmaceuticos.CurrentRow.Cells[1].Value.ToString(), "Eliminar registro", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MessageBox.Show("Registro eliminado","Eliminar",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    ddbb.Remove(usu);

                    //guardamos
                    ddbb.SaveChanges();
                    actualizarGrilla();
                }
                

                
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //obtener el valor PK
            int ci = int.Parse(grdFarmaceuticos.CurrentRow.Cells[0].Value.ToString());
            //armar un objeto con ese valor
            Farmaceutico usu = new Farmaceutico
            {
                Ci = ci,
                Usuario= grdFarmaceuticos.CurrentRow.Cells[1].Value.ToString() ,
                NombreFarm = grdFarmaceuticos.CurrentRow.Cells[2].Value.ToString(),
                ApellidoFarm = grdFarmaceuticos.CurrentRow.Cells[3].Value.ToString(),
                Contrasena = grdFarmaceuticos.CurrentRow.Cells[4].Value.ToString(),
                Cargo = grdFarmaceuticos.CurrentRow.Cells[5].Value.ToString()
        };
            //MessageBox.Show(usu.Contrasena.ToString());
            //eliminar del conjunto de estudiantes
            using (var ddbb = new FarmaciaContext())
            {

                if (MessageBox.Show("Estas seguro de Actualizar este registro ? " + usu.Usuario, "Actualizacion registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MessageBox.Show("Registro Actualizado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //ddbb.Remove(usu);
                    usu.Ci= int.Parse(grdFarmaceuticos.CurrentRow.Cells[0].Value.ToString());
                    usu.Usuario = grdFarmaceuticos.CurrentRow.Cells[1].Value.ToString();
                    usu.NombreFarm = grdFarmaceuticos.CurrentRow.Cells[2].Value.ToString();
                    usu.ApellidoFarm = grdFarmaceuticos.CurrentRow.Cells[3].Value.ToString();
                    usu.Contrasena = grdFarmaceuticos.CurrentRow.Cells[4].Value.ToString();
                    usu.Cargo = grdFarmaceuticos.CurrentRow.Cells[5].Value.ToString();
                    ddbb.Update(usu);
                    //guardamos
                    ddbb.SaveChanges();
                    actualizarGrilla();
                }



            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();

            //frm2.MdiParent = this;

            frm2.ShowDialog();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Recuperamos los valores del formulario
            /* int ci = int.Parse(txtCi.Text);
             string usuario = txtUsuario.Text;
             string nombre = txtNombre.Text;
             string apellido = txtApellido.Text;
             string contraseña = txtContraseña.Text;
             string cargo = cmbCargo.Text;

             */
            int fac = 0;
            //Armamos un objeto con esos valores
            Factura usu = new Factura
            {
                Fecha = DateTime.Today,
                Ci = int.Parse(slabelCi.Text),
                Nit = int.Parse(cmbNit.Text),
                //CiNavigation = apellido,
                //NitNavigation = contraseña,
                
            };
            //Agregamos el objeto al conjunto de telefonos
            using (var ddbb = new FarmaciaContext())
            {
                var user = ddbb.Facturas;
                user.Add(usu);
                //guardamos
                try
                {
                    //MessageBox.Show(usu.NumFactura.ToString());
                    ddbb.SaveChanges();
                    //recuperamos el numero de la factura
                    fac = int.Parse(usu.NumFactura.ToString());
                    foreach (DataGridViewRow dgvRenglon in grdDetalle.Rows)
                    {
                        DetalleVentum det = new DetalleVentum
                        {
                            Cantidad = int.Parse(dgvRenglon.Cells[1].Value.ToString()),
                            NumFactura = fac,
                            CodMedic = dgvRenglon.Cells[0].Value.ToString()
                            //CiNavigation = apellido,
                            //NitNavigation = contraseña,

                        };
                        using (var x = new FarmaciaContext())
                        {
                            var detal = x.DetalleVenta;
                            detal.Add(det);
                            x.SaveChanges();

                        }

                    }
                   
                   
                    
                    
                       

                   // MessageBox.Show(MessageBox.Show(usu.NumFactura.ToString()));
                    MessageBox.Show("Registro insertado", "Insercion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }


            }
        }

        private void cmbNit_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbNit.SelectedIndex != -1)
            {
                int nit = int.Parse(cmbNit.Text);
                //Busqueda por llave primaria
                using (var ddbb = new FarmaciaContext())
                {
                    var nits = ddbb.Clientes
                        .SingleOrDefault(es => es.Nit == nit);
                   // string listaT = "";
                    if (nits != null)
                    {
                        //listaT += $"Nombre completo: {est.nombre} {est.apellido}; Nac.: {est.fecha_nac} ({est.ci})\n";
                         txtNombre.Text = nits.NombreCliente;
                        txtApellido.Text = nits.ApellidoCliente;    
                    }
                   // label21.Text = listaT;
                }
            }
        }

        private void btnGrilla_Click(object sender, EventArgs e)
        {
            grdDetalle.Rows.Add(cmbProducto.Text,txtCantidad.Text);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm2 = new Form3();

            //frm2.MdiParent = this;

            frm2.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form3 frm2 = new Form3();

            //frm2.MdiParent = this;

            frm2.ShowDialog();
        }
    }
}