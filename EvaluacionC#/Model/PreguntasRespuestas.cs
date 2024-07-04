using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionC_.Model
{
    public class PreguntasRespuestas
    {
        public string IdPregunta { get; set; }
        public string TextoPregunta { get; set; }
        public string IdTipoPregunta { get; set; }
        public string Tipo { get; set; }
        public string IdRespuesta { get; set; }
        public string TextoRespuesta { get; set; }
        public string RespuestaValida { get; set; }
    }
}
