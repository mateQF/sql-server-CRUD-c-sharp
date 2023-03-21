using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPersona;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        private CP_Persons objectCP = new();
        private bool Update = false;
        private string Dni = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowPersons();
        }

        private void ShowPersons()
        {
            CP_Persons objectCP_ = new();
            dataGridView1.DataSource = objectCP_.ShowPersons();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Update == false)
            {
                try
                {
                    objectCP.InsertPerson(txtDni.Text, txtName.Text, txtSurname.Text, txtAddress.Text, txtPhone.Text, txtAge.Text, txtEmail.Text);
                    MessageBox.Show("La persona se agregó correctamente");
                    ShowPersons();
                }
                catch (Exception err)
                {
                    MessageBox.Show("No se pudo agregar a la persona debido a " + err.Message);
                }
            }

            if (Update)
            {
                try
                {
                    objectCP.UpdatePerson(Dni, txtName.Text, txtSurname.Text, txtAddress.Text, txtPhone.Text, txtAge.Text, txtEmail.Text);
                    MessageBox.Show("La persona se editó correctamente");
                    ShowPersons();
                    Update = false;
                    btnAdd.Text = "Agregar persona";
                }
                catch (Exception err)
                {
                    MessageBox.Show("No se pudo editar la persona debido a " + err.Message);
                }
            }
            ClearForm();
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            txtDni.Enabled = true;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Update = true;
                Dni = dataGridView1.CurrentRow.Cells["Dni"].Value.ToString()!;
                txtName.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtSurname.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                txtAddress.Text = dataGridView1.CurrentRow.Cells["Domicilio"].Value.ToString();
                txtPhone.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                txtAge.Text = dataGridView1.CurrentRow.Cells["Edad"].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                txtDni.Enabled = false;
                btnAdd.Text = "Editar persona";
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar");
            }
        }

        private void ClearForm()
        {
            txtDni.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtAddress.Text = "";
            txtAge.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Dni = dataGridView1.CurrentRow.Cells["Dni"].Value.ToString()!;
                objectCP.DeletePerson(Dni);
                MessageBox.Show("La persona se eliminó correctamente");
                ShowPersons();
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar");
            }
        }
    }
}