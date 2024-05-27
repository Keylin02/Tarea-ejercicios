using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_aumento_salariales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operarios = 0, tecnicos = 0, profesionales = 0, tipoEmpleado = 0;
            double salarioNetoOperarios = 0, salarioNetoTecnicos = 0, salarioNetoProfesionales = 0, precioHora = 0, horasLaboradas = 0, salarioOrdinario = 0, aumento = 0, salarioBruto = 0, deduccionCCSS = 0, salarioNeto = 0;
            string cedula, nombre, otroEmpleado;

            while (true)
            {
                Console.WriteLine("Ingrese datos del empleado");
                Console.WriteLine("Número de cédula:");
                cedula = Console.ReadLine();
                Console.WriteLine("Nombre:");
                nombre = Console.ReadLine();
                Console.WriteLine("Tipo de empleado: 1) Operario, 2) Técnico, 3) Profesional");
                tipoEmpleado = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio por hora:");
                precioHora = double.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad de horas laboradas:");
                horasLaboradas = double.Parse(Console.ReadLine());

                salarioOrdinario = precioHora * horasLaboradas;

                switch (tipoEmpleado)
                {
                    case 1:
                        aumento = salarioOrdinario * 0.15;
                        operarios++;
                        salarioNetoOperarios = salarioOrdinario + aumento;
                        break;
                    case 2:
                        aumento = salarioOrdinario * 0.10;
                        tecnicos++;
                        salarioNetoTecnicos = salarioOrdinario + aumento;
                        break;
                    case 3:
                        aumento = salarioOrdinario * 0.05;
                        profesionales++;
                        salarioNetoProfesionales = salarioOrdinario + aumento;
                        break;

                }

                salarioBruto = salarioOrdinario + aumento;
                deduccionCCSS = salarioBruto * 0.0917;
                salarioNeto = salarioBruto - deduccionCCSS;

                Console.WriteLine("Datos del empleado");
                Console.WriteLine("Cédula: " + cedula);
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Tipo de empleado: " + tipoEmpleado);
                Console.WriteLine("Salario por hora: " + precioHora);
                Console.WriteLine("Cantidad de horas: " + horasLaboradas);
                Console.WriteLine("Salario ordinario: " + salarioOrdinario);
                Console.WriteLine("Aumento: " + aumento);
                Console.WriteLine("Salario bruto: " + salarioBruto);
                Console.WriteLine("DeducciónCCSS: " + deduccionCCSS);
                Console.WriteLine("Salario neto: " + salarioNeto);

                Console.WriteLine("Desea ingresar otro empleado? si desea marque S por el contrario marque N");
                otroEmpleado = Console.ReadLine();
                if (otroEmpleado != "S")
                    break;

            }
            Console.WriteLine("1: Cantidad empleados tipo operarios: " + operarios);
            Console.WriteLine("2: Acomulado salario neto para operarios: " + salarioNetoOperarios);
            Console.WriteLine("3: Promedio salario neto para operarios: " + salarioNetoOperarios / operarios);
            Console.WriteLine("4: Cantidad empleado tipo técnico: " + tecnicos);
            Console.WriteLine("5: Acumulado salario neto para técnicos: " + salarioNetoTecnicos);
            Console.WriteLine("6: Promedio salario neto para técnicos: " + salarioNetoTecnicos / tecnicos);
            Console.WriteLine("7: Cantidad empleados tipo profesional: " + profesionales);
            Console.WriteLine("8: Acumulado salario neto para profesional: " + salarioNetoProfesionales);
            Console.WriteLine("9: Promedio salario neto para profesional: " + salarioNetoProfesionales / profesionales);
            

            Console.ReadKey();
        } 
        
    }
}
