using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prestamos
{
   
    public partial class calculadoraPrestamo : Form
    {


        double monto;
        int noCuotas;
        double tasaIntere;

        public calculadoraPrestamo()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void calcular_Click(object sender, EventArgs e)
        {
            
            this.calcularPrestamos();
            //nodatapanel.Visible = false;
        }


        private bool verificarCalculo()
        {
            bool verified = false;
            if (montoPrestamo.Text=="" ||  tasaInteres.Text == "" || numeroCuotas.Value.ToString() == "0")
            {
                verified = false;
            }
            else
            {
                verified = true;
                
            }
            return verified;
            
        }
        private void calcularPrestamos()
        {
            

            if (this.verificarCalculo() == false)
            {
                MessageBox.Show("Faltan campos por completar", "Rellenar");
            }
            else
            {
                monto = double.Parse(montoPrestamo.Text);
                tasaIntere = double.Parse(tasaInteres.Text);
                noCuotas = (int)numeroCuotas.Value;
                
                double capitalCuota_ = monto / noCuotas;
                DataTable dt = new DataTable();
                dt.Columns.Add("Cuotas");
                dt.Columns.Add("Capital de cuotas");
                dt.Columns.Add("Interes de cuotas");
                dt.Columns.Add("Monto de cuotas");
                dt.Columns.Add("Capital pagado");
                dt.Columns.Add("Capital restante");
                double interesCuota_ = (monto * (tasaIntere /12/100));
                double montoCuota_ = capitalCuota_ + interesCuota_;
                double capitalPagado_ = 0;
                double capitalRestante_= 0;

                for(int cuota=1; cuota<=noCuotas; cuota++)
                {
                    DataRow dr =  dt.NewRow();
                    capitalPagado_ += capitalCuota_;
                    capitalRestante_ = monto - capitalPagado_;
                    dr["Cuotas"] =cuota;
                    dr["Capital de cuotas"] =capitalCuota_.ToString("c");
                    dr["Interes de cuotas"] =interesCuota_.ToString("###,###,##0.00");
                    dr["Monto de cuotas"] =montoCuota_.ToString("c");
                    dr["Capital pagado"] =capitalPagado_.ToString("c");
                    dr["Capital restante"] =capitalRestante_.ToString("c");
                    dt.Rows.Add(dr);
                }
                datagrid.DataSource = dt;
                datagrid.Refresh();



            }
         

        }
        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         //   startPage.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        private void limpiarDatos()
        {
            lstCapitalCuotas.Items.Clear();
            lstCapitalPagado.Items.Clear();
            lstCapitalRestante.Items.Clear();
            lstInteresCuota.Items.Clear();
            lstNumeroCuotas.Items.Clear();
            lstMontoCuotas.Items.Clear();
            montoPrestamo.Text = "0";
            tasaInteres.Text = "0";
            numeroCuotas.Value = 1;
        }
        private void limpiar_Click(object sender, EventArgs e)
        {

            this.limpiarDatos();
            //nodatapanel.Visible = true;
        }

        private void lstNumeroCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //startPage.Visible = false;
        }
    }
}
