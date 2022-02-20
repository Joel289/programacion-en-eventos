using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudDatos
{
    public partial class Form1 : Form
    {
        ListaEstudiante lista = new ListaEstudiante();
        BindingSource source = new BindingSource();//logra refrescar el datagrid
        ContextMenuStrip menu = new ContextMenuStrip();//menu que sale en el data grid
        int idActual = 1;//obtener id actual

        private Negocio_Estudiante Ne = new Negocio_Estudiante();

        public Form1()
        {
            InitializeComponent();
        }
        private void Actualizar()
        {
            source.DataSource = Ne.ListaEstudiante();
            dgvEstudiantes.DataSource = source;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Actualizar();

            menu.Items.Add("eliminar").Name = "Eliminar";//Agrega un item al menu
            menu.Click += new System.EventHandler(this.menuClick);//crea un delegado 
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(chkHabilitar.Checked && txtContrasenia.Text!= "" && txtEdad.Text != ""&& txtNombre.Text != "")
            {
                Estudiante es = new Estudiante(int.Parse(txtEdad.Text), txtNombre.Text, txtContrasenia.Text);
                MessageBox.Show(Ne.CrearEstudiante(es), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Actualizar();
                borrarTexto();
                chkHabilitar.CheckState = CheckState.Unchecked;
                txtNombre.Enabled = false;
                txtEdad.Enabled = false;
                txtContrasenia.Enabled = false;
            }
            else
            {
                MessageBox.Show("Verifique sus datos.");
            }
        }
        private void borrarTexto()
        {
            txtContrasenia.Text = "";
            txtEdad.Text = "";
            txtNombre.Text = "";
        }

        private void dgvEstudiantes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell celda = dgvEstudiantes.CurrentCell;
            if(celda.ColumnIndex == 1)
            {
                lista.editarEstudiante(idActual, 1, celda.Value.ToString());
            }
            else if (celda.ColumnIndex == 2)
            {
                lista.editarEstudiante(idActual, 2, celda.Value.ToString());
            }
            else if (celda.ColumnIndex == 3)
            {
                lista.editarEstudiante(idActual, 3, celda.Value.ToString());
            }
            source.ResetBindings(false);
        }

        private void dgvEstudiantes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.ColumnIndex>0 && e.RowIndex > 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    dgvEstudiantes.CurrentCell = dgvEstudiantes.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    //Se obtiene las coordenadas de la celda seleccionada 
                    Rectangle coordenada = dgvEstudiantes.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                    int anchoCelda = coordenada.Location.X;
                    int altoCelda = coordenada.Location.Y;

                    //para mostrar el menu se lo hace de la siguiente forma
                    int X = anchoCelda + dgvEstudiantes.Location.X;
                    int Y = altoCelda + dgvEstudiantes.Location.Y + 5;
                    menu.Show(dgvEstudiantes, new Point(X, Y));

                }
            }
            idActual = int.Parse(dgvEstudiantes.CurrentRow.Cells[0].Value.ToString());
            
        }
        private void menuClick(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea eliminar al estudiante con Id : ?" + idActual,"Advertencia!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                MessageBox.Show(Ne.EliminarEstudiante(Convert.ToString(idActual)), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Actualizar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            menuClick(sender, e);
        }

        private void chkHabilitar_CheckedChanged(object sender, EventArgs e)
        {
            if(chkHabilitar.Checked == true)
            {
                txtContrasenia.Enabled = true;
                txtEdad.Enabled = true;
                txtNombre.Enabled = true;
            }
            if (chkHabilitar.Checked == false)
            {
                txtContrasenia.Enabled = false;
                txtEdad.Enabled = false;
                txtNombre.Enabled = false;
            }
        }
        
        //

    }
}
