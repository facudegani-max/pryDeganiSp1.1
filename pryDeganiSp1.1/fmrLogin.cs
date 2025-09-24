namespace pryDeganiSp1._1
{
    public partial class fmrLogin : Form
    {
        public fmrLogin()
        {
            InitializeComponent();
        }

        int i = 0;  
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if((txtUsuario.Text == "Administrador" && txtContraseña.Text == "adm135$") || (txtUsuario.Text == "Operador" && txtContraseña.Text == "ope246$"))
                    {
                this.Hide(); // oculta este formualrio
                fmrInicio f = new fmrInicio(); // crea el frmInicio
                f.Text = txtUsuario.Text; // asigna el texto de título
                f.ShowDialog(); // visualiza y ejecuta el frmInicio
                this.Show(); // visualiza nuevamente este formulario
            }
            else
            {
                MessageBox.Show("Datos incorrectos. Acceso Denegado.");
                i++; // incrementa el contador de intentos fallidos
                if (i == 3) // si es 3 se cierra el formulario
                {
                    this.Close(); // cierra formulario
                }
            }
        }
    
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // cierra formulario
        }
    }
}
