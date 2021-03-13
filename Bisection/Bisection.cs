using System; //Librerías del sistema
using org.mariuszgromada.math.mxparser; // Librería utilizada para evaluar expresiones matemáticas 
namespace Bisection {
    /// <summary>
    /// Bisection permite crear instancias para poder
    /// ejecutar el método de bisección, con valores iniciales
    /// XU y XL. Termina si las iteraciones indicadas son alcanzadas,
    /// o si el Es se posiciona por menor a lo indicado.
    /// 
    /// Utiliza un paquete de NuGet para obtener las funciones 
    /// de un campo de texto, al estilo MatLab
    /// 
    /// <see cref="SimpleExpressionEvaluator"/>
    /// </summary>
    public class Bisection {
        /// <summary>
        /// Por default, haremos que el número máximo de iteraciones
        /// sean 100, para que el programa no se sature.
        /// </summary>
        private const int MAXIMO_NUMERO_ITERACIONES = 100;
        /// <summary>
        /// Almacena la entrada de la función en forma de cadena.
        /// Es la que se utilizará para evaluar con el método de
        /// bisección. No puede ser nula, ni contener espacios en blanco
        /// ni ser vacía. 
        /// </summary>
        private string _customFunction;
        public string CustomFunction {
            get => _customFunction;
            set {
                if (string.IsNullOrWhiteSpace(value) || value is null)
                    throw new Exception("La función no puede ser vacia, ni nula, ni contener espacios en blanco");
                else _customFunction = value;
            }
        }
        /// <summary>
        /// Error noseque
        /// </summary>
        public double ES {
            get;set;
        }
        /// <summary>
        /// XU es el valor de x upper, o x alta, o segundo valor 
        /// para usarla dentro del método de bisección
        /// </summary>
        public double XU {
            get;set;
        }
        /// <summary>
        /// XL es el valor de x lower, o x baja, o primer valor 
        /// para usarla dentro del método de bisección
        /// </summary>
        public double XL {
            get;set;
        }
        /// <summary>
        /// Propiedad para almacenar el máximo de iteraciones.
        /// Por default, se asigna como la constante de MAXIMO_NUMERO_ITERACIONES
        /// <see cref="MAXIMO_NUMERO_ITERACIONES"/>
        /// </summary>
        public int MaxIterations {
            get; set;
        } = MAXIMO_NUMERO_ITERACIONES; 
        /// <summary>
        /// DataGridView para almacenar los datos de cada iteración
        /// del método de bisección.
        /// </summary>
        public System.Windows.Forms.DataGridView DataGridValues {
            get;set;
        }
        /// <summary>
        /// Constructor para instanciar un objeto de tipo Bisection
        /// </summary>
        /// <param name="function">Función deseada a evaluar</param>
        /// <param name="xL">Valor de XL</param>
        /// <param name="xU">Valor de XU</param>
        /// <param name="es">Valor de noseque</param>
        public Bisection(string function, double xL, double xU, double es) : this(){
            CustomFunction = function;
            ES = es;
            XL = xL;
            XU = xU;
        }
        /// <summary>
        /// Propiedad para almacenar el valor de XR. Es privada
        /// debido a que sólo se utilizará dentro de esta clase.
        /// </summary>
        private double XR {
            get;set;
        }
        /// <summary>
        /// Constructor vacío
        /// </summary>
        public Bisection() {}
        /// <summary>
        /// Método de bisección. Requiere que previamente
        /// se haya construido un objeto de tipo Bisection
        /// y se le hayan pasado todos los valores correspondientes.
        /// </summary>
        /// <returns>XU = XR final, una aproximación entre XL y XU</returns>
        public double Bisect() {
            //¿Cuantas iteraciones llevamos? Al empezar, 0.
            int numeroActualIteraciones = 0; 
            //Test es una variable para probar la multiplicacion de f(xl) * f(xr)
            double test, ea = 0.0d; 
            do { //Empezamos al menos una vez a iterar.
                XR = (XL + XU) / 2; //Obtenemos XR, sumando XL + XU y diviendo entre dos.
                numeroActualIteraciones++; //Aumentamos el número de iteraciones en uno
                if (XR != 0) //Si XR es distinto de cero, se asigna un error absoluto
                    ea = Math.Abs((XU - XL) / (XU + XL)) * 100; //Asignación
                //Objeto de tipo Function, que almacena la función a evaluar
                Function func = new Function(CustomFunction);
                //Dos expresiones para poder evaluar la función previamente declarada
                Expression exprParaXL, exprParaXR   ;
                try {
                     exprParaXL = new Expression($"f({XL})", func); //Evalua f(xl)
                     exprParaXR = new Expression($"f({XR})", func);//Evalua en f(xr)
                } catch (Exception ex) {
                    throw new Exception(ex.Message + ex.Source);
                }
                //Multiplicamos las dos funciones, evaluadas respectivamente.
                test = exprParaXL.calculate() * exprParaXR.calculate(); //Calcula cuanto vale el test
                //Agrega los valores a la tabla, para poder mostrarlos
                DataGridValues?.Rows.Add(
                    numeroActualIteraciones.ToString(),
                    XL.ToString(),
                    XU.ToString(),
                    XR.ToString(),
                    ea.ToString());
                //Condición para poder reasignar XU o XL, en base al test realizado
                if (test < 0)
                    XU = XR;
                else if (test > 0)
                    XL = XR;
                else ea = 0;
                //Mientras las iteraciones sean menor a las máximas, o el error absoluto sea mayor que el criterio permitido
            } while (ea >= ES && numeroActualIteraciones <= MaxIterations); 
            double res = XR; //Obtenemos finalmente la respuesta, y la retornamos.
            return res; //Retorna XR
        }
    }
}
