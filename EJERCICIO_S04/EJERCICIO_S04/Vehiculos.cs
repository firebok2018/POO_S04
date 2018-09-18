using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_S04
{
    class Vehiculos
    {
        public string placa { get; set; }
        public string descripcion { get; set; }
        public int anio { get; set; }
        public string fabricante { get; set; }
        public DateTime fechaCompra {get;set;}
    }

    /*
     * personal p = seleccion.Find(x => x.DNI == txtDNI.Text);
            if (p==null)
            {
                
                personal pe = new personal();
               
                pe.DNI = txtDNI.Text;
                pe.nombre = txtNombre.Text;
                pe.apellido = txtApellidos.Text;
                pe.direccion = txtDireccion.Text;
                pe.fechaNac = dtpfecha.Text;

                seleccion.Add(pe);


                dgpersonal.DataSource = null;
                dgpersonal.DataSource = seleccion;
            }else
            {
                MessageBox.Show("YA existe Ingrese Otro NUmero De Dni");
            }

            txtPlaca.Text = dgregistroVehiculo.CurrentRow.Cells[0].Value.ToString();
     * 
     
     */
}
