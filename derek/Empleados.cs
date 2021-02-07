using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace derek
{
    public class Empleados
    {
        public string nombre;
        public string apellido;
        public string dni;
        public string direccion;
        public string telefono;
        public int annios;
        public double salario;
        public string supervisor;
        

        public Empleados(string nombre, string apellido, string dni, string direccion, string telefono, int annios, double salario, string supervisor)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.direccion = direccion;
            this.telefono = telefono;
            this.annios = annios;
            this.salario = salario;
            this.supervisor = supervisor;

        }

        

        public void imprimirInfor()
        {
            Console.WriteLine("Nombre: " + nombre + "\nApellido: " + apellido + "\nDNI: " + dni + "\nDireccion: " +
             direccion + "\nTelefono: " + telefono + "\nYears: " + annios + "\nSalario: " + salario + "\n\nEmpleado supervisor: " + supervisor   );
            Console.ReadKey();
        }

        public void cambiarSupervisor()
        {
            int opcion;
            int yesNo;
            Console.WriteLine("*** Su supervisor actual es: " + supervisor + "  ");
            Console.WriteLine("¿Desea cambiarlo? 1 si.");
            yesNo = Convert.ToInt32(Console.ReadLine());

            if(yesNo == 1)
            {
                Console.WriteLine("*** CAMBIANDO SUPERVISOR *** ");
                Console.WriteLine(
                    "1. Fulano\n" +
                    "2. Sutano\n" +
                    "3. Merengano");
              
                Console.WriteLine("\nIngrese una opcion");
                opcion = Convert.ToInt32(Console.ReadLine());
               

                if(opcion == 1)
                {
                    Console.WriteLine("Su nuevo supervisor es Fulano");
                    Console.ReadKey();
                }
                else if(opcion == 2)
                {
                    Console.WriteLine("Su nuevo superviso es Sutano");
                    Console.ReadKey();
                }
                else if(opcion == 3)
                {
                    Console.WriteLine("Su nuevo supervisor es Merengano");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Elija correctamente");
                Console.ReadKey();
            }


        }

        public void incrementarSalario()
        {
            double nuevoSalario = 0;
            int opcion;
            Console.WriteLine("Desea incrementar el salario");
            opcion = Convert.ToInt32(Console.ReadLine());
            if(opcion == 1)
            {
                Console.WriteLine("Su salario actual es de: " + salario);
                Console.WriteLine("¿En cuanto desea incrementar su salario?");
                nuevoSalario = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("*** Incrementando salario ***");
                nuevoSalario = salario + nuevoSalario;
                Console.WriteLine("Su nuevo salario es de: " + nuevoSalario);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Su salario aun sigue siendo " + salario);
                Console.ReadKey();
            }
           

        }
    }

    

}
