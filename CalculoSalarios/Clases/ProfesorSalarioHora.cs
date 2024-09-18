using CalculoSalarios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSalarios.Clases
{
    internal class ProfesorSalarioHora : Empleado
    {
        public decimal Horas { get; set; }

        public ProfesorSalarioHora(string nombre, string apellido, decimal horas) : base(nombre, apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
            Horas = horas;
        }


        public override decimal calculoSalario()
        {
            int horasObjetivo = 40;
            decimal porcentaje = 1.5m;
            decimal dineroPagar = 0;
            decimal tarifa = 800;

            if (Horas <= horasObjetivo)
            {
                dineroPagar = tarifa * Horas;
            }
            else if (Horas > horasObjetivo)
            {
                dineroPagar = horasObjetivo * tarifa + (Horas - horasObjetivo) * tarifa * porcentaje;
            }

            return dineroPagar;
        }
    }
}
