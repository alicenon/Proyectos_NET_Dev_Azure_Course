using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _35EJEM_MVC_GENERAR_PDF.Models
{
    public class ModeloEmpleados
    {

        ContextoEmpleados contexto;

        public ModeloEmpleados()
        {
            contexto = new ContextoEmpleados();
        }

        public List<EMP> GetEmpleados()
        {
            var consulta = from datos in contexto.EMP
                           select datos;
            return consulta.ToList();
        }

        public EMP BuscarEmpleado(int idempleado)
        {
            var consulta = from datos in contexto.EMP
                           where datos.EMP_NO == idempleado
                           select datos;
            return consulta.FirstOrDefault();
        }

    }
}