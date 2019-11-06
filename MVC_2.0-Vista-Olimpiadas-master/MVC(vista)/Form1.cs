using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADOR.paises;

namespace MVC_vista_
{
    public partial class Form1 : Form
    {
        PaisesDTO paisesDTO = null;
        PaisesDAO paisesDAO = null;
        DataTable Dtt = null;

        public Form1()
        {
            InitializeComponent();
            ListarPaises();
            lblcodigo.Visible = false;
            txtcodigo.Visible = false;
            btnguardarcambios.Enabled = false;
            btneliminar.Enabled = false;
            btncancelar.Enabled = false;
            txtpais.MaxLength = 50;

        }


        public void ListarPaises()
        {
            paisesDTO = new PaisesDTO();
            paisesDAO = new PaisesDAO(paisesDTO);

            Dtt = new DataTable();
            Dtt = paisesDAO.ListarPaises();

            if (Dtt.Rows.Count > 0) {

                dtpaises.DataSource = Dtt;

            } else {

                MessageBox.Show("No hay registros de paises");
            }

        }

        public void Guardar()
        {
            paisesDTO = new PaisesDTO();
            paisesDTO.setNombrepais(txtpais.Text);
            paisesDAO = new PaisesDAO(paisesDTO);

            paisesDAO.GuardarPais();
            MessageBox.Show("Registro guardado");

        }



        public void GuardarCambios()
        {
            paisesDTO = new PaisesDTO();
            paisesDTO.setIdpais (int.Parse(txtcodigo.Text));
            paisesDTO.setNombrepais(txtpais.Text);
            paisesDAO = new PaisesDAO(paisesDTO);

            paisesDAO.GuardarCambiosPais();
            MessageBox.Show("Registro Modificado");

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            if (txtpais.Text.Trim()== "") {

                MessageBox.Show("oye Hacker, intenta un dato valido");
                txtpais.Focus();
            }
            else
            {
                Guardar();
                ListarPaises();
                txtpais.Clear();
                txtpais.Focus();
            }



          
        }

        private void dtpaises_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblcodigo.Visible = true;
            txtcodigo.Visible = true;
            txtcodigo.Enabled = false;

            txtcodigo.Text = dtpaises.Rows[dtpaises.CurrentRow.Index].Cells[0].Value.ToString();
            txtpais.Text = dtpaises.Rows[dtpaises.CurrentRow.Index].Cells[1].Value.ToString();

            btnguardar.Enabled = false;
            btnguardarcambios.Enabled = true;
            btneliminar.Enabled = true;
            btncancelar.Enabled = true;
            
           
        }

        private void btnguardarcambios_Click(object sender, EventArgs e)
        {



            if (txtpais.Text.Trim() == "")
            {

                MessageBox.Show("oye Hacker, intenta un dato valido");
                txtpais.Focus();
            }
            else
            {

                GuardarCambios();
                ListarPaises();

                txtcodigo.Enabled = true;
                lblcodigo.Visible = false;
                txtcodigo.Visible = false;
                btnguardar.Enabled = true;
                btnguardarcambios.Enabled = false;
                btneliminar.Enabled = true;
                btncancelar.Enabled = true;
                txtpais.Clear();
                txtpais.Focus();
                btnguardarcambios.Enabled = true;
            }
           
        }


        public void EliminarRegistroPais()
        {


            paisesDTO = new PaisesDTO();
            paisesDTO.setIdpais(int.Parse(txtcodigo.Text));
            paisesDAO = new PaisesDAO(paisesDTO);

            paisesDAO.EliminarPais();
            MessageBox.Show("Registro Eliminado");


        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            EliminarRegistroPais();
            ListarPaises();


            txtcodigo.Enabled = true;
            lblcodigo.Visible = false;
            txtcodigo.Visible = false;
            btnguardar.Enabled = true;
            btnguardarcambios.Enabled = false;
            btneliminar.Enabled = true;
            btncancelar.Enabled = true;
            txtpais.Clear();
            txtpais.Focus();
            btnguardarcambios.Enabled = true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            ListarPaises();


            txtcodigo.Enabled = true;
            lblcodigo.Visible = false;
            txtcodigo.Visible = false;
            btnguardar.Enabled = true;
            btnguardarcambios.Enabled = false;
            btneliminar.Enabled = false;
            btncancelar.Enabled = false;
            txtpais.Clear();
            txtpais.Focus();
            btnguardarcambios.Enabled = false;
        }
    }
}
