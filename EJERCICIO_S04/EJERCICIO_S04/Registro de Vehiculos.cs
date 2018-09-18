using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_S04
{
    public partial class Registro_de_Vehiculos : Form
    {
        List<Vehiculos> v =new  List<Vehiculos>();
        public Registro_de_Vehiculos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Vehiculos vh = new Vehiculos();
            Vehiculos ve = v.Find(x => x.placa == txtPlaca.Text);

            if (ve != null)
                MessageBox.Show("N° placa esta registrado");


            else
            {
                vh.placa = txtPlaca.Text;
                vh.descripcion = txtDecripcion.Text;
                vh.anio = int.Parse(txtAnio.Text);
                vh.fabricante = cbofabricante.Text;
                vh.fechaCompra = dtpFechaCompra.Value;

                v.Add(vh);
            }
                dgregistroVehiculo.DataSource = null;
                dgregistroVehiculo.DataSource = v;
                

        }

        private void btnlistado_Click(object sender, EventArgs e)
        {
            dgregistroVehiculo.DataSource = null;
            dgregistroVehiculo.DataSource = v;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Vehiculos ve = v.Find(x=> x.placa==txtPlaca.Text);

            if (ve != null)
                v.Remove(ve);
            else
                MessageBox.Show("N° Placa no Existe");


        }

        private void dgregistroVehiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPlaca.Text = dgregistroVehiculo.CurrentRow.Cells[0].Value.ToString();
            txtDecripcion.Text = dgregistroVehiculo.CurrentRow.Cells[1].Value.ToString();
            txtAnio.Text = dgregistroVehiculo.CurrentRow.Cells[2].Value.ToString();
            cbofabricante.Text = dgregistroVehiculo.CurrentRow.Cells[3].Value.ToString();

        }
    }
}
