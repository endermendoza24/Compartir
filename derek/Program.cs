using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace derek
{
    public class Program
    {
        static void Main(string[] args)
        {
            Empleados objeto = new Empleados("Endersson", "Alonso", "041-240500-1004P", "Juzgado 1/2 cuadra al este",
                "82072291", 20, 165.3, "Derek");
            objeto.imprimirInfor();
            objeto.cambiarSupervisor();
            objeto.incrementarSalario();
        }
    }
}
