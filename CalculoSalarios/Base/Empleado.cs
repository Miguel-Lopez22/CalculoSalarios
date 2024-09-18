using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSalarios.Base
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Empleado(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public abstract decimal calculoSalario();

    }
}
