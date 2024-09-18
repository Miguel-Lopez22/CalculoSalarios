using CalculoSalarios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSalarios.Clases
{
    internal class EmpleadoAdministrativo : Empleado
    {
        private decimal Salario { get; set; }
        private decimal Horas { get; set; }

        public EmpleadoAdministrativo(string nombre, string apellido, decimal horas, decimal salario) : base(nombre, apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
            Horas = horas;
            Salario = salario;
        }

        public override decimal calculoSalario()
        {
            decimal bonificacion = 1.5m;
            int horasObjetivo = 40;


            if (Horas == horasObjetivo)
            {
                return Salario;
            }
            else if (Horas > horasObjetivo)
            {
                return Salario * bonificacion;
            }
            else
            {
                return Salario / 2;
            }
        }
    }
}
