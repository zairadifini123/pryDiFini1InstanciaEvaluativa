namespace pryDiFini1InstanciaEvaluativa
{
    public partial class frmRubros : Form
    {
        public frmRubros()
        {
            InitializeComponent();
        }

        //Crear un objeto de la clase clsRubros para poder usar sus métodos dentro del formulario
        clsRubros Rubros = new clsRubros();
        private void lnkInformacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInformacionDelAlumno frmInformacionDelAlumno = new frmInformacionDelAlumno();
            frmInformacionDelAlumno.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRubros_Load(object sender, EventArgs e)
        {
            //Llama el método de la clase para guardar el nombre de los rubros en el combo box
            Rubros.GuardarDatos(cmbRubros);

            //Calcular el producto de ValorStock
            Decimal ValorStock;
            ValorStock = Convert.ToDecimal(Costo) * Convert.ToDecimal(Stock);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //Llama al metodo para mostrar los datos
            Rubros.CargarDatosGrilla(dgvArticulos, cmbRubros.Text); 
        }
    }
}
