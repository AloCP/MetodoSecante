using System;
using System.Windows.Forms;

namespace MetodoSecante
{
    public partial class FormPrincipal : Form
    {
        Secante objsecante = new Secante();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Revise por última vez. ¿La función es correcta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnCalcular.Enabled = false; // Desactiva el botón mientras se calcula
                try
                {
                    // Validar campos vacíos
                    if (string.IsNullOrWhiteSpace(txtX0.Text) ||
                        string.IsNullOrWhiteSpace(txtX1.Text) ||
                        string.IsNullOrWhiteSpace(txtError.Text))
                    {
                        MessageBox.Show("Por favor complete todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Validar formato numérico
                    if (!float.TryParse(txtX0.Text, out float x0) ||
                        !float.TryParse(txtX1.Text, out float x1) ||
                        !float.TryParse(txtError.Text, out float error))
                    {
                        MessageBox.Show("Ingrese valores numéricos válidos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Validar que el error sea positivo
                    if (error <= 0)
                    {
                        MessageBox.Show("El error debe ser un número positivo mayor que cero.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Ejecutar cálculo
                    objsecante.LeerX0(x0);
                    objsecante.LeerX1(x1);
                    objsecante.LeerError(error);
                    objsecante.CalcularSecante();

                    MostrarResultados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error de cálculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btnCalcular.Enabled = true; // Reactiva el botón al final
                }
            }
        }



        private void MostrarResultados()
        {
            lblIteraciones.Text = objsecante.retIteraciones().ToString();
            lblRaiz.Text = objsecante.retRaiz().ToString("F6");
            lblErrorFinal.Text = objsecante.retErrorFinal().ToString("F6");
            dataIteracion.DataSource = objsecante.retTablaIteraciones();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtX0.Clear();
            txtX1.Clear();
            txtError.Clear();
            lblIteraciones.Text = "";
            lblRaiz.Text = "";
            lblErrorFinal.Text = "";
            dataIteracion.DataSource = null;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Para ingresar la función, siga la forma ±ax^n1 ± bx^n2 ± cx ± d\n\nEjemplo:\n3x^2 -2x -5", "Raíces de funciones polinomiales", MessageBoxButtons.OK);
        }
    }
}