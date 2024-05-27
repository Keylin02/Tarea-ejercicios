using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_futbol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entradasSol = 0, entradasSombra = 0, entradasPreferencial = 0, numFactura = 0, localidad = 0, cantidadEntradas = 0;
            double acumuladoSol = 0, acumuladosSombra = 0, acumuladosPreferencial = 0, precioEntrada = 0, subtotal = 0, cargos = 0, totalPagar = 0;
            string cedula, nombre, nombreLocalizacion, otraVenta;

            while (true)
            {
                Console.WriteLine("Ingrese datos de la venta");
                Console.WriteLine("Número de factura");
                numFactura = int.Parse(Console.ReadLine());
                Console.WriteLine("Cédula:");
                cedula = Console.ReadLine();
                Console.WriteLine("Nombre comprador:");
                nombre = Console.ReadLine();
                Console.WriteLine("Localización");
                Console.WriteLine("1: Sol Norte/Sur");
                Console.WriteLine("2: Sombre Este/Oeste");
                Console.WriteLine("3: Preferencial");
                localidad = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad de entradas:");
                cantidadEntradas = int.Parse(Console.ReadLine());

                if (cantidadEntradas > 4)
                {
                    Console.WriteLine("Limite de entradas, solo 4 por persona");
                    continue;
                }
                              

                switch (localidad)
                {
                    case 1:
                        precioEntrada = 10500;
                        nombreLocalizacion = "Sol Norte/Sur";
                        entradasSol = cantidadEntradas;
                        acumuladoSol = precioEntrada * cantidadEntradas;
                        break;
                    case 2:
                        precioEntrada = 20500;
                        nombreLocalizacion = "sombra Este/Oeste";
                        entradasSombra = cantidadEntradas;
                        acumuladosSombra = precioEntrada * cantidadEntradas;
                        break;
                    case 3:
                        precioEntrada = 25500;
                        nombreLocalizacion = "Preferencial";
                        entradasPreferencial = cantidadEntradas;
                        acumuladosPreferencial = precioEntrada * cantidadEntradas;
                        break;
                }

                subtotal = precioEntrada * cantidadEntradas;
                cargos = 1000 * cantidadEntradas;
                totalPagar = subtotal + cargos;

                Console.WriteLine("Datos de la factura");
                Console.WriteLine("Número de factura: " + numFactura);
                Console.WriteLine("Cédula: " + cedula);
                Console.WriteLine("Nombre comprador:" + nombre);
                Console.WriteLine("Localidad: " + localidad);
                Console.WriteLine("Cantidad entradas: " + cantidadEntradas);
                Console.WriteLine("Subtotal: " + subtotal);
                Console.WriteLine("Cargos por servicios: " + cargos);
                Console.WriteLine("Total a pagar: " + totalPagar);

                Console.WriteLine("Desea ingresar otra venta? si desea marque S si no N");
                otraVenta = Console.ReadLine();

                if (otraVenta != "S")                
                    break;  

            }
            Console.WriteLine("Cantidad entradas localidad sol Norte/Sur: " + entradasSol);
            Console.WriteLine("Acumulado dinero localidad sol Norte/Sur: " + acumuladoSol);
            Console.WriteLine("Cantidad entradas localidad sombra Este/Oeste: " + entradasSombra);
            Console.WriteLine("Acumulado dinero localidad sombra Este/Oeste: " + acumuladosSombra);
            Console.WriteLine("Cantidad entradas localidad preferencial: " + entradasPreferencial);
            Console.WriteLine("Acumulado dinero localidad preferencial: " + acumuladosPreferencial);

            Console.ReadKey();

        }     
                
    }
}
