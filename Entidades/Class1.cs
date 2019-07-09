using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Asignaturas
    {
        [Key]
        public int AsignaturaId { get; set; }
        public string Descripcion { get; set; }
        public int Creditos { get; set; }

        public Asignaturas()
        {
            AsignaturaId = 0;
            Descripcion = string.Empty;
            Creditos = 0;
        }

    }

    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Nombres { get; set; }
        public Decimal Balance { get; set; }

        public Estudiantes()
        {
            EstudianteId = 0;
            FechaIngreso = DateTime.Now;
            Nombres = string.Empty;
            Balance = 0;
        }
    }

    public class Inscripciones
    {
        [Key]
        public int InscripcionId { get; set; }
        public int EstudianteId { get; set; }
        public int AsignaturaId { get; set; }
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }
        public double PrecioCredito { get; set; }
        public virtual List<InscripcionesDetalle> PrecioCreditos { get; set; }

        public Inscripciones()
        {
            InscripcionId = 0;
            EstudianteId = 0;
            AsignaturaId = 0;
            Fecha = DateTime.Now;
            Monto = 0;
            PrecioCredito = 0;
            PrecioCreditos = new List<InscripcionesDetalle>();

        }
        public void Calculo()
        {
            double Monto = 0;

            foreach (var item in PrecioCreditos)
            {
                Monto += item.Subtotal;
            }
            Monto = Monto;
        }
    }

    public class InscripcionesDetalle
    {
        [Key]
        public int Id { get; set; }
        public int AsignaturaId { get; set; }
        public int EstudiantesId { get; set; }
        public int InscripcionId { get; set; }
        public double Subtotal { get; set; }

        //TODO:Falta completar la entidad

        public InscripcionesDetalle()
        {
            Id = 0;
            AsignaturaId = 0;
            EstudiantesId = 0;
            InscripcionId = 0;
            Subtotal = 0;
        }
    }
}
