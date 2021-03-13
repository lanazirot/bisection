using System;
using System.Windows.Forms;
/// <summary>
/// Created by Alan Peña Ortiz 
/// github.com/lanazirot
/// </summary>
namespace Bisection {
    /// <summary>
    /// Form principal, aquí se ejecuta el programa
    /// </summary>
    public partial class PrincipalForm : Form {
        public PrincipalForm() {
            InitializeComponent(); //Inicia el Form
        }
        /// <summary>
        /// Se almacena el resultado del método de bisección, para poderlo mostrar en
        /// el MessageBox y en el recuadro de cálculos
        /// </summary>
        private double bisectResult;
        /// <summary>
        /// Evento que ejecuta el método de bisección al presionar el botón
        /// </summary>
        /// <param name="sender">Objecto mensajero</param>
        /// <param name="e">Objeto de evento</param>
        private void btnConfirmeFunction_Click(object sender, EventArgs e) {
            //Creamos un objeto de tipo Bisection
            try {
                Bisection bisection = new Bisection() {
                    ES = double.Parse(txtES.Text), //Valor de Es
                    CustomFunction = txtFunction.Text, //Le pasamos la función que vamos a evaluar
                    MaxIterations = int.Parse(txtMaxIter.Text), //Pasamos el número máximo de iteraciones
                    XL = double.Parse(txtXL.Text), //Valor de XL (lower)
                    XU = double.Parse(txtXU.Text), //Valor de XU (upper)
                    DataGridValues = dtgValues //Para mostrar en la tabla, la pasamos como parámetro también
                };
                dtgValues.Rows.Clear(); //Limpia los registros de la tabla
                bisectResult = bisection.Bisect(); //Ejecuta el método de Bisección
                                                   //y colocalo en una variable
                txtXRRespuesta.Text = bisectResult.ToString();

                MessageBox.Show($"La aproximación a la raíz que cumple con el criterio de " +
                    $"{bisection.ES * 100} % es Xr = {txtXRRespuesta.Text}"
                    ,"Resultado" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Ha ocurrido un fatal error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
