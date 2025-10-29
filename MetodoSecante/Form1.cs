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
            try
            {
                objsecante.LeerFuncion(txtFuncion.Text);
                objsecante.LeerX0(float.Parse(txtX0.Text));
                objsecante.LeerX1(float.Parse(txtX1.Text));
                objsecante.LeerError(float.Parse(txtError.Text));

                objsecante.CalcularSecante();

                MostrarResultados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error de cálculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarResultados()
        {
            lblIteraciones.Text = objsecante.retIteraciones().ToString();
            lblRaiz.Text = objsecante.retRaiz().ToString("F6");
            lblErrorFinal.Text = objsecante.retErrorFinal().ToString("F6");

            dataIteración.DataSource = objsecante.retTablaIteraciones();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFuncion.Clear();
            txtX0.Clear();
            txtX1.Clear();
            txtError.Clear();
            lblIteraciones.Text = "";
            lblRaiz.Text = "";
            lblErrorFinal.Text = "";
            dataIteración.DataSource = null;
        }

       
    }
}