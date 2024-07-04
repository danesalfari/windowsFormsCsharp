using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionC_.Controller
{
    public class Conexion
    {
        //Atributos
        public SqlConnection con; //Atributo para la cadena de conexión
        public SqlCommand sen; //Almacena las setencias SQL
        public SqlDataReader rs; // Recibe información de la base de datos

        //Métodos

        public Conexion()
        {
            //Data Source = Nombre del servidor
            //Initial Catalog = Nombre de la base de datos
            //Integrated Security = True

            this.con = new SqlConnection(@"Data Source=JUANPC;Initial Catalog=EVALUACION ;" +
                "Integrated Security=True");
        }
    }
}
