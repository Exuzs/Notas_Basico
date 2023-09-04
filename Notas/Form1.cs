namespace Notas
{
    public partial class Form1 : Form
    {
        Notas Nota = new Notas();
        double promedio = 0.0;

        public Form1()
        {
            InitializeComponent();
            limpiarCampos();
        }

        public void limpiarCampos()
        {
            txtAlumno.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
            txtAlumno.Focus();
            lblNotaBaja.Text = "0.0";
            lblPromedio.Text = "0.0";
            lblValidacion.Text = "Procesando";
        }

        public void asignarValores()
        {
            asignarNotas();
            asignarPromedio();
            mostrarNotita();
            asignarValidacion();
        }

        public void asignarValidacion()
        {
            if (promedio >= 3.0)
            {
                lblValidacion.Text = "Pasó";
            }
            else
            {
                lblValidacion.Text = "Repite";
            }
        }

        public void asignarNotas()
        {
            txtNota1.Text = Nota.Notes.Length > 0 ? Nota.Notes[0].ToString("F1") : "0.0";
            txtNota2.Text = Nota.Notes.Length > 1 ? Nota.Notes[1].ToString("F1") : "0.0";
            txtNota3.Text = Nota.Notes.Length > 2 ? Nota.Notes[2].ToString("F1") : "0.0";
            txtNota4.Text = Nota.Notes.Length > 3 ? Nota.Notes[3].ToString("F1") : "0.0";
        }

        public void asignarPromedio()
        {
            if (ValidarNota(txtNota1.Text) &&
                ValidarNota(txtNota2.Text) &&
                ValidarNota(txtNota3.Text) &&
                ValidarNota(txtNota4.Text))
            {
                promedio = Nota.Promediar();
                lblPromedio.Text = promedio.ToString("F2");
            }
            else
            {
                lblPromedio.Text = "0.0";
            }
        }

        public void mostrarNotita()
        {
            double notaBaja = Nota.hallarNotaBaja();
            lblNotaBaja.Text = notaBaja.ToString("F1");
        }

        private bool ValidarNota(string nota)
        {
            if (double.TryParse(nota, out double valorNota))
            {
                return valorNota >= 0 && valorNota <= 100;
            }
            return false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAlumno.Text))
            {
                if (ValidarNota(txtNota1.Text) &&
                    ValidarNota(txtNota2.Text) &&
                    ValidarNota(txtNota3.Text) &&
                    ValidarNota(txtNota4.Text))
                {
                    Nota.Notes[0] = double.Parse(txtNota1.Text);
                    Nota.Notes[1] = double.Parse(txtNota2.Text);
                    Nota.Notes[2] = double.Parse(txtNota3.Text);
                    Nota.Notes[3] = double.Parse(txtNota4.Text);

                    asignarValores();
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa el nombre del alumno y notas válidas (números entre 0 y 100 con posibilidad de decimales).", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa el nombre del alumno.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}