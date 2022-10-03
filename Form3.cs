using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Farmacia
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ddbb = new FarmaciaContext())
            {
                var grupos = ddbb.Facturas
                    .GroupBy(mc => mc.Fecha)
                    .Select(gr => new
                    {
                        Fecha = gr.Key,
                        Concurrencia = gr.Count()
                        
                    }).ToList();
                grdgrilla.DataSource = grupos;  
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var ddbb = new FarmaciaContext())
            {
                var grupos = ddbb.DetalleVenta.Join(
                         ddbb.Medicamentos,
                         ven => ven.CodMedic,//PK
                         med => med.CodMed,//FK
                         (ven, med) => new {
                             cod = ven.CodMedic,
                             cantidad = ven.Cantidad,
                             nombre = med.NombreMedic,

                             
                         }
                        
                 ).
                 ToList();
                
               //var res=grupos.GroupBy(mc => mc.nombre)
               //     .Select(r => new
               //     {
                        
               //         Medicamento = r.Key,
               //        //des=r.Key,
               //         Cantidad = r.Sum(mmcc => mmcc.cantidad)

               //     })
               //     . ToList();  
               // grdgrilla.DataSource = res;

                var totales = (from p in grupos
                               where p.cantidad >0
                               group p by new { codigo=p.cod, name=p.nombre } into g
                //group p by p.cod into g
                               select new 
                               {
                                   //g.Key.name,
                                  
                                   codigo=g.Key.codigo,
                                   Descripcion=g.Key.name,
                                    Cantidad = g.Sum(p => p.cantidad)
                               }).ToList();


                grdgrilla.DataSource = totales;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // int edad = int.Parse(textBox6.Text);
            using (var ddbb = new FarmaciaContext())
            {
                var ventas = ddbb.Facturas
                    //.Where(fecha1 => fecha1.Fecha>=DateTime.Today && fecha1.Fecha <= DateTime.Today)
                    .Where(fecha1 => fecha1.Fecha >= dtpFecha1.Value && fecha1.Fecha <= dtpFecha2.Value)
                    .ToList();
                grdgrilla.DataSource=ventas;
            }
            grdgrilla.Columns[4].Visible = false;
            grdgrilla.Columns[5].Visible = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DateTime data = DateTime.ParseExact("01/01/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture);

            dtpFecha1.Value = data;
            dtpFecha2.Value = DateTime.Today;
        }
    }
}
