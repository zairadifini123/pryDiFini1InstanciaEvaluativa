using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryDiFini1InstanciaEvaluativa
{
    //Se crea la clase clsRubros para manejar las actividades en donde se usen los datos del archivo RUBROS.csv
    internal class clsRubros
    {
        //Se crea una variable para almacenar el nombre del archivo, es público para poder usarlo en otros códigos (frmRubros)
        public string NombreArchivo = "RUBROS.csv";

        //Para guardar los datos del archivo al combo box
        public void GuardarDatos(ComboBox Combo)
        {
            string DatosLeidos;
            string[] VecDatos = new string[2];

            StreamReader AD = new StreamReader(NombreArchivo); //Abre archivo RUBROS.csv
            DatosLeidos = AD.ReadLine(); //Lee la primer linea del archivo 

            Combo.Items.Clear();
            //Comprueba que cargue en el combo box mientras el archivo no esté vacio
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';'); //Separa los datos para trabajarlos mejor 
                Combo.Items.Add(VecDatos[1]); //Carga el nombre del rubro en el ComboBox
                DatosLeidos = AD.ReadLine(); //Vuelve a leer para no quedarse en la primer linea
            }

            AD.Close(); //Cierra archivo
            AD.Dispose(); 
        }

        
    }
}
