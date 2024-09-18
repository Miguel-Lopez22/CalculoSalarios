using CalculoSalarios.Clases;
using System;

namespace CalculoSalarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProfesorSalarioHora prof1 = new ProfesorSalarioHora("Miguel", "Lopez", 45);
            ProfesorAsalariado prof2 = new ProfesorAsalariado("Carlos", "Perez", 45, 3000);

            Console.WriteLine(prof1.calculoSalario());
            Console.WriteLine(prof2.calculoSalario());
            Console.ReadKey();
        }
    }
}
