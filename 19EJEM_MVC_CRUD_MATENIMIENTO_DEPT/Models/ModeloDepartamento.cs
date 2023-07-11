using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _19EJEM_MVC_CRUD_MATENIMIENTO_DEPT.Models
{
    public class ModeloDepartamento
    {
        HospitalDataContext context = new HospitalDataContext();

        public List<DEPT> MostrarDepartamentos()
        {
            //lambda
            return context.DEPT.ToList();
        }

        public void AltaDepartamento(int id, string nombre, string localizacion)
        {

            context.DEPT.InsertOnSubmit(new DEPT { DEPT_NO = id, DNOMBRE = nombre, LOC = localizacion });
           
            context.SubmitChanges();
        }


        public void ModificarDepartamento(string id, string nombre, string localizacion)
        {


          DEPT departamento = context.DEPT.FirstOrDefault(dept => dept.DEPT_NO == int.Parse(id));

            

            departamento.DEPT_NO = int.Parse(id);
            departamento.DNOMBRE = nombre;
            departamento.LOC = localizacion;

            context.SubmitChanges();
        }




        public DEPT EditarDepartamento(int id)
        {

            return context.DEPT.SingleOrDefault(dept => dept.DEPT_NO == id);
        }


        public void EliminarDepartamento(int id)
        {


            context.DEPT.DeleteOnSubmit(context.DEPT.SingleOrDefault(dept =>
                dept.DEPT_NO == id));


            context.SubmitChanges();

        }
    }
}