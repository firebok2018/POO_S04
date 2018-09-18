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
    public partial class Form1 : Form
    {
        List<libro> lib = new List<libro>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            libro reg = new libro();

            reg.codigo = int.Parse(txtcodigo.Text);
            reg.autor = txtAutor.Text;
            reg.año = int.Parse(txtanio.Text);
            reg.materia = cboMateria.Text;
            reg.titulo = txttitulow.Text;

            lib.Add(reg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgLibros.DataSource = null;
            dgLibros.DataSource = lib;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            libro l = lib.Find(x => x.codigo == int.Parse(txtcodigo.Text));

            if (lib == null)
            {
                MessageBox.Show("Codigo no exixtente");
            }
            else
            {
                lib.Remove(l);
            }
                

           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtanio.Clear();
            txtAutor.Clear();
            txtcodigo.Clear();
            txttitulow.Clear();
            
        }

        private void dgLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dgLibros.CurrentRow.Cells[0].Value.ToString();
            txttitulow.Text = dgLibros.CurrentRow.Cells[1].Value.ToString();
            cboMateria.Text = dgLibros.CurrentRow.Cells[2].Value.ToString();
            txtanio.Text = dgLibros.CurrentRow.Cells[3].Value.ToString();
            txtAutor.Text = dgLibros.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
