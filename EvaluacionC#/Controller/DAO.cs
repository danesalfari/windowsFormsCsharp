using EvaluacionC_.Model;
using EvaluacionC_.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluacionC_.Controller
{
    public class DAO : Conexion
    {
        //Atributo de clase
        private Conexion c;

        //Constructor

        public DAO()
        {
            //Obtener la cadena de conexión
            c = new Conexion();
        }

        //Metodo generico
        private void ejecutar(string sql)
        {
            try
            {
                this.c.con.Open(); //Obtener la cadena de conexión
                this.c.sen = new SqlCommand(sql, c.con); //Traducir la cadena SQL a una sentencia SQL
                this.c.sen.ExecuteNonQuery();
                MessageBox.Show("La transacción ha sido aplicada en la base de datos");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.c.con.Close(); //Cierra la cadena de conexión
            }
        }

        //CRUD Aprendiz
        public void CrearAprendiz(Aprendiz apr)
        {
            string insert = "INSERT into APRENDIZ(NombreAprendiz,DocumentoAprendiz)"
                    + "VALUES('" + apr.NombreAprendiz + "','" + apr.DocumentoAprendiz + "')";
            ejecutar(insert);
        }

        public void ModificarAprendiz(Aprendiz apr)
        {
            string update = "UPDATE APRENDIZ set NombreAprendiz = ' " + apr.NombreAprendiz + " ', DocumentoAprendiz = ' "
                    + apr.DocumentoAprendiz + " ' ";
            ejecutar(update);
        }

        public void EliminarAprendiz(Aprendiz apr)
        {
            string delete = " delete FROM APRENDIZ where IdAprendiz = ' " + apr.IdAprendiz + " ' ";
            ejecutar(delete);
        }
        public Aprendiz BuscarAprendiz(string dapr)
        {
            Aprendiz apr = null;
            string select = "select * from APRENDIZ where DocumentoAprendiz= '" + dapr + "'";
            try
            {
                this.c.con.Open(); //Obtener la cadena de conexión
                this.c.sen = new SqlCommand(select, c.con); //Traducir la cadena SQL a una sentencia SQL
                this.rs = this.c.sen.ExecuteReader();
                if (this.rs.Read())
                {
                    apr = new Aprendiz();
                    apr.IdAprendiz = int.Parse(this.rs["IdAprendiz"].ToString());
                    apr.DocumentoAprendiz = this.rs["DocumentoAprendiz"].ToString();
                    apr.NombreAprendiz = this.rs["NombreAprendiz"].ToString();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.c.con.Close();
            }
            return apr;

        }

        //CRUD Categorías  

        public void CrearCategorias(Categorias cat) 
        {
            string insert = "INSERT into CATEGORIAS(Categoria)"
                    + "VALUES('" + cat.Categoria + "')";
            ejecutar(insert);
        }

        public void ModificarCategorias(Categorias cat)
        {
            string update = "UPDATE CATEGORIAS set Categoria = ' " + cat.Categoria + " '";
            ejecutar(update);
        }

        public void EliminarCategorias(Categorias cat)
        {
            string delete = " delete FROM CATEGORIAS where IdCategoria = ' " + cat.IdCategoria + " ' ";
            ejecutar(delete);
        }
        public Categorias BuscarCategorias(string bcat)
        {
            Categorias cat = null;
            string select = "select * from CATEGORIAS where Categoria= '" + bcat + "'";
            try
            {
                this.c.con.Open(); //Obtener la cadena de conexión
                this.c.sen = new SqlCommand(select, c.con); //Traducir la cadena SQL a una sentencia SQL
                this.rs = this.c.sen.ExecuteReader();
                if (this.rs.Read())
                {
                    cat = new Categorias();
                    cat.IdCategoria = int.Parse(this.rs["IdCategoria"].ToString());
                    cat.Categoria = this.rs["Categoria"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.c.con.Close();
            }
            return cat;

        }

        //CRUD Evaluación
        public void CrearEvaluacion(Evaluacion eva)
        {
            string insert = "INSERT into Evaluacion(IdEvaluacion,IdPregunta)"
                    + "VALUES('" + eva.IdEvaluacion + "','" + eva.IdPregunta + "')";
            ejecutar(insert);
        }

        public void ModificarEvaluacion(Evaluacion eva)
        {
            string update = "UPDATE Evaluacion set IdPregunta = ' " + eva.IdPregunta + " '";
            ejecutar(update);
        }

        public void EliminarEvaluacion(Evaluacion eva)
        {
            string delete = " delete FROM Evaluacion where IdEvaluacion = ' " + eva.IdEvaluacion + " ' ";
            ejecutar(delete);
        }

        public List<Preguntas> listarPreguntas()
        {
            List<Preguntas> Preguntas = new List<Preguntas>();
            Preguntas pre = null;
            string select = "select IdPregunta,IdTipoPreguntas,IdCategoria,TextoPregunta from PREGUNTAS";

            try
            {
                this.c.con.Open(); //obtener la cadena de conexion
                this.c.sen = new SqlCommand(select, c.con); //traducir la cadena sql a una sentencia sql
                this.rs = this.c.sen.ExecuteReader();
                while (this.rs.Read())
                {
                    pre = new Preguntas();
                    pre.IdPregunta = int.Parse(this.rs["IdPregunta"].ToString());
                    pre.IdTipoPreguntas = this.rs["IdTipoPreguntas"].ToString();
                    pre.IdCategoria = this.rs["IdCategoria"].ToString();
                    pre.TextoPregunta = this.rs["TextoPregunta"].ToString();
                    Preguntas.Add(pre);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.c.con.Close();
            }
            return Preguntas;
        }
        public List<Preguntas> listarPreguntas2(string ParamCategorias)
        {
            List<Preguntas> Preguntas = new List<Preguntas>();
            Preguntas pre = null;
            string select = "select IdPregunta,IdTipoPreguntas,IdCategoria,TextoPregunta from PREGUNTAS WHERE IdCategoria = (SELECT IdCategoria From CATEGORIAS Where Categoria = '"+ParamCategorias+"')";

            try
            {
                this.c.con.Open(); //obtener la cadena de conexion
                this.c.sen = new SqlCommand(select, c.con); //traducir la cadena sql a una sentencia sql
                this.rs = this.c.sen.ExecuteReader();
                while (this.rs.Read())
                {
                    pre = new Preguntas();
                    pre.IdPregunta = int.Parse(this.rs["IdPregunta"].ToString());
                    pre.IdTipoPreguntas = this.rs["IdTipoPreguntas"].ToString();
                    pre.IdCategoria = this.rs["IdCategoria"].ToString();
                    pre.TextoPregunta = this.rs["TextoPregunta"].ToString();
                    Preguntas.Add(pre);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.c.con.Close();
            }
            return Preguntas;
        }

        public List<Categorias> listarCategoriasE()
        {
            List<Categorias> Categorias = new List<Categorias>();
            Categorias cat = null;
            string select = "select IdCategoria,Categoria from CATEGORIAS";

            try
            {
                this.c.con.Open(); //obtener la cadena de conexion
                this.c.sen = new SqlCommand(select, c.con); //traducir la cadena sql a una sentencia sql
                this.rs = this.c.sen.ExecuteReader();
                while (this.rs.Read())
                {
                    cat = new Categorias();
                    cat.IdCategoria = int.Parse(this.rs["IdCategoria"].ToString());
                    cat.Categoria = this.rs["Categoria"].ToString();
                    Categorias.Add(cat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.c.con.Close();
            }
            return Categorias;
        }

        public Evaluacion BuscarEvaluacion(string beva)
        {
            Evaluacion eva = null;
            string select = "select * from Evaluacion where IdPregunta= '" + beva + "'";
            try
            {
                this.c.con.Open(); //Obtener la cadena de conexión
                this.c.sen = new SqlCommand(select, c.con); //Traducir la cadena SQL a una sentencia SQL
                this.rs = this.c.sen.ExecuteReader();
                if (this.rs.Read())
                {
                    eva = new Evaluacion();
                    eva.IdEvaluacion = int.Parse(this.rs["IdEvaluacion"].ToString());
                    eva.IdPregunta = this.rs["IdPregunta"].ToString(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.c.con.Close();
            }
            return eva;
        }

        //CRUD Preguntas 

        public void CrearPreguntas(Preguntas pre) 
        {
            string insert = "INSERT into PREGUNTAS(IdTipoPreguntas, IdCategoria, TextoPregunta)"
                    + "VALUES('" + pre.IdTipoPreguntas + "','" + pre.IdCategoria + "','" + pre.TextoPregunta + "')";
            ejecutar(insert);
        }

        public void ModificarPreguntas(Preguntas pre)
        {
            string update = "UPDATE PREGUNTAS set IdTipoPreguntas = '" + pre.IdTipoPreguntas + "' IdCategoria = ' " + pre.IdCategoria + "' TextoPregunta = '" + pre.TextoPregunta + " ' ";
            ejecutar(update);
        }

        public void EliminarPreguntas(Preguntas pre)
        {
            string delete = " delete FROM PREGUNTAS where IdPregunta = ' " + pre.IdPregunta + " ' ";
            ejecutar(delete);
        }
        public Preguntas BuscarPreguntas(string bpre)
        {
            Preguntas pre = null;
            string select = "select * from PREGUNTAS where Tipo= '" + bpre + "'";
            try
            {
                this.c.con.Open(); //Obtener la cadena de conexión
                this.c.sen = new SqlCommand(select, c.con); //Traducir la cadena SQL a una sentencia SQL
                this.rs = this.c.sen.ExecuteReader();
                if (this.rs.Read())
                {
                    pre = new Preguntas();
                    pre.IdPregunta = int.Parse(this.rs["IdPregunta"].ToString());
                    pre.IdTipoPreguntas = this.rs["IdTipoPreguntas"].ToString();
                    pre.IdCategoria = this.rs["IdCategoria"].ToString();
                    pre.TextoPregunta = this.rs["TextoPregunta"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.c.con.Close();
            }
            return pre;

        }

        public List<TipoPreguntas> listarTipoPreguntas()
        {
            List<TipoPreguntas> TipoPreguntas = new List<TipoPreguntas>();
            TipoPreguntas top = null;
            string select = "select IdTipoPreguntas,Tipo from TIPOPREGUNTAS";

            try
            {
                this.c.con.Open(); //obtener la cadena de conexion
                this.c.sen = new SqlCommand(select, c.con); //traducir la cadena sql a una sentencia sql
                this.rs = this.c.sen.ExecuteReader();
                while (this.rs.Read())
                {
                    top = new TipoPreguntas();
                    top.IdTipoPreguntas = int.Parse(this.rs["IdTipoPreguntas"].ToString());
                    top.Tipo = this.rs["Tipo"].ToString();
                    TipoPreguntas.Add(top);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.c.con.Close();
            }
            return TipoPreguntas;
        }

        public List<Categorias> listarCategorias()
        {
            List<Categorias> Categorias = new List<Categorias>();
            Categorias cat = null;
            string select = "select IdCategoria,Categoria from CATEGORIAS";

            try
            {
                this.c.con.Open(); //obtener la cadena de conexion
                this.c.sen = new SqlCommand(select, c.con); //traducir la cadena sql a una sentencia sql
                this.rs = this.c.sen.ExecuteReader();
                while (this.rs.Read())
                {
                    cat = new Categorias();
                    cat.IdCategoria = int.Parse(this.rs["IdCategoria"].ToString());
                    cat.Categoria = this.rs["Categoria"].ToString();
                    Categorias.Add(cat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.c.con.Close();
            }
            return Categorias;
        }

        //CRUD Tipo Preguntas 

        public void CrearTipoPreguntas(TipoPreguntas top)
        {
            string insert = "INSERT into TIPOPREGUNTAS(Tipo)"
                    + "VALUES('" + top.Tipo + "')";
            ejecutar(insert);
        }

        public void ModificarTipoPreguntas(TipoPreguntas top)
        {
            string update = "UPDATE TIPOPREGUNTAS set Tipo = ' " + top.Tipo + " '";
            ejecutar(update);
        }

        public void EliminarTipoPreguntas(TipoPreguntas top)
        {
            string delete = " delete FROM TIPOPREGUNTAS where IdTipoPreguntas = ' " + top.IdTipoPreguntas + " ' ";
            ejecutar(delete);
        }
        public TipoPreguntas BuscarTipoPreguntas(string btop)
        {
            TipoPreguntas top = null;
            string select = "select * from TIPOPREGUNTAS where Tipo= '" + btop + "'";
            try
            {
                this.c.con.Open(); //Obtener la cadena de conexión
                this.c.sen = new SqlCommand(select, c.con); //Traducir la cadena SQL a una sentencia SQL
                this.rs = this.c.sen.ExecuteReader();
                if (this.rs.Read())
                {
                    top = new TipoPreguntas();
                    top.IdTipoPreguntas = int.Parse(this.rs["IdTipoPreguntas"].ToString());
                    top.Tipo = this.rs["Tipo"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.c.con.Close();
            }
            return top;

        }

        //CRUD Respuestas

        public void CrearRespuestas(Respuestas res)
        {
            string insert = "INSERT into RESPUESTAS(IdPregunta,RespuestaValida,TextoRespuesta)"
                    + "VALUES('" + res.IdPregunta + "','" + res.RespuestaValida + "','" + res.TextoRespuesta + "')";
            ejecutar(insert);
        }

        public void ModificarRespuestas(Respuestas res)
        {
            string update = "UPDATE RESPUESTAS set IdPregunta = '" + res.IdPregunta + "' IdCategoria = ' " + res.RespuestaValida + "' TextoPregunta = '" + res.TextoRespuesta + " ' ";
            ejecutar(update);
        }

        public void EliminarRespuestas(Respuestas res)
        {
            string delete = " delete FROM RESPUESTAS where IdRespuesta = ' " + res.IdRespuesta + " ' ";
            ejecutar(delete);
        }

        public List<Preguntas> listarPreguntasR()
        {
            List<Preguntas> Preguntas = new List<Preguntas>();
            Preguntas pre = null;
            string select = "select IdPregunta,IdTipoPreguntas,IdCategoria,TextoPregunta from PREGUNTAS";

            try
            {
                this.c.con.Open(); //obtener la cadena de conexion
                this.c.sen = new SqlCommand(select, c.con); //traducir la cadena sql a una sentencia sql
                this.rs = this.c.sen.ExecuteReader();
                while (this.rs.Read())
                {
                    pre = new Preguntas();
                    pre.IdPregunta = int.Parse(this.rs["IdPregunta"].ToString());
                    pre.IdTipoPreguntas = this.rs["IdTipoPreguntas"].ToString();
                    pre.IdCategoria = this.rs["IdCategoria"].ToString();
                    pre.TextoPregunta = this.rs["TextoPregunta"].ToString();
                    Preguntas.Add(pre);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.c.con.Close();
            }
            return Preguntas;
        }

        public Respuestas BuscarRespuestas(string bres)
        {
            Respuestas res = null;
            string select = "select * from RESPUESTAS where RespuestaValida= '" + bres + "'";
            try
            {
                this.c.con.Open(); //Obtener la cadena de conexión
                this.c.sen = new SqlCommand(select, c.con); //Traducir la cadena SQL a una sentencia SQL
                this.rs = this.c.sen.ExecuteReader();
                if (this.rs.Read())
                {
                    res = new Respuestas();
                    res.IdRespuesta = int.Parse(this.rs["IdRespuesta"].ToString());
                    res.IdPregunta = this.rs["IdPregunta"].ToString();
                    res.RespuestaValida = this.rs["RespuestaValida"].ToString(); ;
                    res.TextoRespuesta = this.rs["TextoRespuesta"].ToString(); ;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.c.con.Close();
            }
            return res;
        }

        //CRUD Prueba

        public void CrearPrueba(Prueba pru)
        {
            string insert = "INSERT into PRUEBA(IdPrueba, IdAprendiz, FechaInicio, IdEvaluacion)"
                    + "VALUES('"+ pru.IdPrueba+ "','" + pru.IdAprendiz + "', GETDATE() ,'" + pru.IdEvaluacion + "' )";
            ejecutar(insert);

            frmExamen examen = new frmExamen(pru.IdEvaluacion, pru.IdPrueba);
            examen.Show();
        }

        public void ModificarPrueba(Prueba pru)
        {
            string update = "UPDATE PREGUNTAS set IdAprendiz = '" + pru.IdAprendiz + "' FechaInicio = ' " + pru.FechaInicio + "' FechaFinal = '" + pru.FechaFinal + "' Calificacion = ' " + pru.Calificacion + "' IdEvaluacion = ' " + pru.IdEvaluacion + "'";
            ejecutar(update);
        }

        public void EliminarPrueba(Prueba pru)
        {
            string delete = " delete FROM PREGUNTAS where IdPrueba = ' " + pru.IdPrueba + " ' ";
            ejecutar(delete);
        }
        public Prueba BuscarPrueba(string bpru)
        {
            Prueba pru = null;
            string select = "select * from PRUEBA where IdPrueba = '" + bpru + "'";
            try
            {
                this.c.con.Open(); //Obtener la cadena de conexión
                this.c.sen = new SqlCommand(select, c.con); //Traducir la cadena SQL a una sentencia SQL
                this.rs = this.c.sen.ExecuteReader();
                if (this.rs.Read())
                {
                    pru = new Prueba();
                    pru.IdAprendiz = this.rs["IdAprendiz"].ToString();
                    pru.FechaInicio = this.rs["FechaInicio"].ToString();
                    pru.FechaFinal = this.rs["FechaFinal"].ToString();
                    pru.Calificacion = this.rs["Calificacion"].ToString();
                    pru.IdEvaluacion = this.rs["IdEvaluacion"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.c.con.Close();
            }
            return pru;

        }

        public List<Aprendiz> listarAprendiz()
        {
            List<Aprendiz> Aprendiz = new List<Aprendiz>();
            Aprendiz apr = null;
            string select = "select IdAprendiz,NombreAprendiz,DocumentoAprendiz from APRENDIZ";

            try
            {
                this.c.con.Open(); //obtener la cadena de conexion
                this.c.sen = new SqlCommand(select, c.con); //traducir la cadena sql a una sentencia sql
                this.rs = this.c.sen.ExecuteReader();
                while (this.rs.Read())
                {
                    apr = new Aprendiz();
                    apr.IdAprendiz = int.Parse(this.rs["IdAprendiz"].ToString());
                    apr.NombreAprendiz = this.rs["NombreAprendiz"].ToString();
                    apr.DocumentoAprendiz = this.rs["DocumentoAprendiz"].ToString();
                    Aprendiz.Add(apr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.c.con.Close();
            }
            return Aprendiz;
        }
        public List<Evaluacion> listarEvaluacion()
        {
            List<Evaluacion> Evaluacion = new List<Evaluacion>();
            Evaluacion eva = null;
            string select = "select Distinct IdEvaluacion from Evaluacion";

            try
            {
                this.c.con.Open(); //obtener la cadena de conexion
                this.c.sen = new SqlCommand(select, c.con); //traducir la cadena sql a una sentencia sql
                this.rs = this.c.sen.ExecuteReader();
                while (this.rs.Read())
                {
                    eva = new Evaluacion();
                    eva.IdEvaluacion = int.Parse(this.rs["IdEvaluacion"].ToString());
                    Evaluacion.Add(eva);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.c.con.Close();
            }
            return Evaluacion;
        }

        public List<PreguntasRespuestas> listarPreguntasRespuestas(string IdEvaluacion)
        {
            List<PreguntasRespuestas> PreguntasRespuestas = new List<PreguntasRespuestas>();
            PreguntasRespuestas preres = null;
            string select = "Select PREGUNTAS.IdPregunta, PREGUNTAS.TextoPregunta, PREGUNTAS.IdTipoPreguntas,TIPOPREGUNTAS.Tipo, RESPUESTAS.IdRespuesta, RESPUESTAS.TextoRespuesta, RESPUESTAS.RespuestaValida From PREGUNTAS, TIPOPREGUNTAS, RESPUESTAS, Evaluacion Where Evaluacion.IdEvaluacion = "+ IdEvaluacion + " And Evaluacion.IdPregunta = PREGUNTAS.IdPregunta And PREGUNTAS.IdTipoPreguntas = TIPOPREGUNTAS.IdTipoPreguntas And PREGUNTAS.IdPregunta = RESPUESTAS.IdPregunta";

            try
            {
                this.c.con.Open(); //obtener la cadena de conexion
                this.c.sen = new SqlCommand(select, c.con); //traducir la cadena sql a una sentencia sql
                this.rs = this.c.sen.ExecuteReader();
                while (this.rs.Read())
                {
                    preres = new PreguntasRespuestas();
                    preres.IdTipoPregunta = this.rs["IdTipoPreguntas"].ToString();
                    preres.IdRespuesta = this.rs["IdRespuesta"].ToString();
                    preres.Tipo = this.rs["Tipo"].ToString();
                    preres.IdPregunta = this.rs["IdPregunta"].ToString();
                    preres.TextoRespuesta = this.rs["TextoRespuesta"].ToString();
                    preres.TextoPregunta = this.rs["TextoPregunta"].ToString();
                    preres.RespuestaValida = this.rs["RespuestaValida"].ToString();
                    PreguntasRespuestas.Add(preres);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(select);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.c.con.Close();
            }
            return PreguntasRespuestas;
        }
        public void escribirResultados(string Resultado, string IdPrueba)
        {           
            string update = " Update PRUEBA Set FechaFinal = GETDATE(), Calificacion = " +Resultado+ "  Where IdPrueba = " + IdPrueba;
            ejecutar(update);
        }
    }
}
