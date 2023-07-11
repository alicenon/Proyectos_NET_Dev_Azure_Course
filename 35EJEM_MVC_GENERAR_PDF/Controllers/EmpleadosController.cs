using _35EJEM_MVC_GENERAR_PDF.Models;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using iTextSharp.text.html.simpleparser;
using System.Xml.Linq;


namespace _35EJEM_MVC_GENERAR_PDF.Controllers
{
    public class EmpleadosController : Controller
    {
        ModeloEmpleados modelo = new ModeloEmpleados();
        // GET: Empleados
        public ActionResult Index()
        {
            List<EMP> listaempleados = modelo.GetEmpleados();
            return View(listaempleados);
        }


        public ActionResult InformeEmpleado(int empno)
        {
            EMP empleado = modelo.BuscarEmpleado(empno);
            Document docpdf = new Document(PageSize.LETTER);
            //CAPTURAMOS LA RUTA AL DOCUMENTO
            String ruta = HttpContext.Server.MapPath("/PDF/");
            //CREAMOS UNA RUTA CON EL NOMBRE DEL INFORME
            //Y LA EXTENSION PDF PARA EL INFORME
            ruta = ruta + "informe" + empno.ToString() + ".pdf";
            //PREGUNTAMOS SI EL DOCUMENTO EXISTE PREVIAMENTE
            if (System.IO.File.Exists(ruta))
            {
                //SI EL DOCUMENTO EXISTE, DEVOLVEMOS
                //EL FILE
                return File(ruta, "application/pdf");
            }
            else
            {
                //CREAMOS EL DOCUMENTO ASOCIADO A UN
                //FICHERO WRITER
                PdfWriter writer = PdfWriter.GetInstance(docpdf,
                    new FileStream(ruta, FileMode.Create));

                //INCLUIMOS TITULO Y AUTOR DEL DOCUMENTO
                docpdf.AddTitle("Informe empleado "
                    + empleado.APELLIDO);
                docpdf.AddCreator("Ejemplo MVC");

                //ABRIMOS EL DOCUMENTO
                docpdf.Open();
                //DEFINIMOS LA FUENTE DEL DOCUMENTO
                iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 11, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                //ENCABEZADO DEL DOCUMENTO
                docpdf.Add(new Paragraph("Informe del empleado: " + empleado.APELLIDO + ", " + DateTime.Now.ToLongDateString()));
                //DAMOS UN SALTO DE LINEA
                docpdf.Add(Chunk.NEWLINE);

                //CREAMOS UNA TABLA CON LOS DATOS PARA EL EMPLEADO
                //CON CUATRO DATOS A REPRESENTAR
                PdfPTable tabla = new PdfPTable(4);
                tabla.WidthPercentage = 100;

                //CREAMOS LAS COLUMNAS CON SU TITULO Y SU VALOR
                PdfPCell colapellido = new PdfPCell(new Phrase("APELLIDO", _standardFont));
                colapellido.BorderWidth = 0;
                colapellido.BorderWidthBottom = 0.75f;

                PdfPCell coloficio = new PdfPCell(new Phrase("OFICIO", _standardFont));
                coloficio.BorderWidth = 0;
                coloficio.BorderWidthBottom = 0.75f;

                PdfPCell colfecha = new PdfPCell(new Phrase("FECHA DE ALTA", _standardFont));
                colfecha.BorderWidth = 0;
                colfecha.BorderWidthBottom = 0.75f;

                PdfPCell colsalario = new PdfPCell(new Phrase("SALARIO", _standardFont));
                colsalario.BorderWidth = 0;
                colsalario.BorderWidthBottom = 0.75f;

                //AÑADIMOS LAS CELDAS A LA TABLA
                tabla.AddCell(colapellido);
                tabla.AddCell(coloficio);
                tabla.AddCell(colfecha);
                tabla.AddCell(colsalario);

                //AGREGAMOS DATOS A LAS CELDAS
                colapellido = new PdfPCell(new Phrase(empleado.APELLIDO, _standardFont));
                colapellido.BorderWidth = 0;

                coloficio = new PdfPCell(new Phrase(empleado.OFICIO, _standardFont));
                coloficio.BorderWidth = 0;

                colfecha = new PdfPCell(new Phrase(empleado.FECHA_ALT.ToString(), _standardFont));
                colfecha.BorderWidth = 0;

                colsalario = new PdfPCell(new Phrase(empleado.SALARIO.ToString() + "€", _standardFont));
                colsalario.BorderWidth = 0;

                //AÑADIMOS LAS CELDAS A LA TABLA
                tabla.AddCell(colapellido);
                tabla.AddCell(coloficio);
                tabla.AddCell(colfecha);
                tabla.AddCell(colsalario);
                //AGREGAMOS LA TABLA AL DOCUMENTO
                docpdf.Add(tabla);
                //CERRAMOS EL DOCUMENTO
                docpdf.Close();
                //CERRAMOS EL WRITER
                writer.Close();

                //DEVOLVEMOS EL DOCUMENTO CREADO
                return File(ruta, "application/pdf");
            }
        }
        //PRACTICA NOMINAS
        public ActionResult InformeEmpleados(int empno , string oficio)
        {
            EMP empleado = modelo.BuscarEmpleado(empno);
            Document docpdf = new Document(PageSize.LETTER);
            //CAPTURAMOS LA RUTA AL DOCUMENTO
            String ruta = HttpContext.Server.MapPath("/PDF/");
            //CREAMOS UNA RUTA CON EL NOMBRE DEL INFORME
            //Y LA EXTENSION PDF PARA EL INFORME
            ruta = ruta + "informe" + empno.ToString() + ".pdf";
            //PREGUNTAMOS SI EL DOCUMENTO EXISTE PREVIAMENTE
            if (System.IO.File.Exists(ruta))
            {
                //SI EL DOCUMENTO EXISTE, DEVOLVEMOS
                //EL FILE
                return File(ruta, "application/pdf");
            }
            else
            {
                //CREAMOS EL DOCUMENTO ASOCIADO A UN
                //FICHERO WRITER
                PdfWriter writer = PdfWriter.GetInstance(docpdf,
                    new FileStream(ruta, FileMode.Create));

                //INCLUIMOS TITULO Y AUTOR DEL DOCUMENTO
                docpdf.AddTitle("Informe empleado "
                    + empleado.APELLIDO);
                docpdf.AddCreator("Ejemplo MVC");

                //ABRIMOS EL DOCUMENTO
                docpdf.Open();
                //DEFINIMOS LA FUENTE DEL DOCUMENTO
               Font _standardFont = new Font(Font.FontFamily.HELVETICA, 11, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                //imagen
                String rutaImagen = HttpContext.Server.MapPath("/th.jpg");

                iTextSharp.text.Image img1 = iTextSharp.text.Image.GetInstance(rutaImagen);
                img1.ScaleAbsoluteWidth(480);
                img1.ScaleAbsoluteHeight(270);
                docpdf.Add(img1);
                docpdf.Add(Chunk.NEWLINE);
                //end imagen
                //ENCABEZADO DEL DOCUMENTO
                docpdf.Add(new Paragraph("Informe del empleado: " + empleado.APELLIDO + ", " + DateTime.Now.ToLongDateString()));
                docpdf.Add(new Paragraph("APELLIDO : " +empleado.APELLIDO));
                docpdf.Add(new Paragraph("OFICIO : " +oficio));
                docpdf.Add(new Paragraph("SALARIO" +empleado.SALARIO.ToString()));
                docpdf.Add(Chunk.NEWLINE);
                //
                float salario_irpf = (int)empleado.SALARIO * 0.016f;
                docpdf.Add(new Paragraph("IRPF:    " + salario_irpf.ToString()));
                //DAMOS UN SALTO DE LINEA
                docpdf.Add(Chunk.NEWLINE);
                PdfContentByte contentByte = writer.DirectContent;
                contentByte.SetLineWidth(1f); // Ancho de la línea
                contentByte.SetRGBColorStroke(255, 0, 0); // Color de la línea (rojo)
                contentByte.MoveTo(docpdf.LeftMargin, docpdf.PageSize.Height - docpdf.TopMargin - 10); // Posición inicial de la línea
                contentByte.LineTo(docpdf.PageSize.Width - docpdf.RightMargin, docpdf.PageSize.Height - docpdf.TopMargin - 10); // Posición final de la línea
                contentByte.Stroke();


                //CERRAMOS EL DOCUMENTO
                docpdf.Close();
                //CERRAMOS EL WRITER
                writer.Close();

                //DEVOLVEMOS EL DOCUMENTO CREADO
                return File(ruta, "application/pdf");
            }

        }
    }
}