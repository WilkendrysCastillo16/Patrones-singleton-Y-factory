using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_Programacion_2
{
    class OPERATIVO: IEMPLEADOS
    {
        private List<Almacen_ADMINISTRATIVO> AO;
        private int opcion;
        public void Creacion_Empleados()
        {
            AO = new List<Almacen_ADMINISTRATIVO>();
            Random R = new Random();

            do
            {
                do
                {
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Menu empleado Operativo");
                    Console.WriteLine("------------------");
                    Console.WriteLine("1.- Crear Empleado");
                    Console.WriteLine("2.- Ver empleado");
                    Console.WriteLine("3.- Cobrar empleado");
                    Console.WriteLine("5.- Salir");
                    Console.WriteLine("------------------");
                    Console.WriteLine("Digite la opción: ");

                    opcion = Convert.ToInt32(Console.ReadLine());


                    if (opcion < 1 || opcion > 5)
                    {
                        Console.WriteLine("Ingrese una opción válida del 1 al 5");
                    }

                } while (opcion < 1 || opcion > 5);


                switch (opcion)
                {
                    case 1:
                        {


                            Almacen_ADMINISTRATIVO AOPR = new Almacen_ADMINISTRATIVO();

                            AOPR.Codigo = "OPE" + R.Next(1000, 9999);

                            Console.Write("Cedula");
                            AOPR.Cedula = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Nombre: ");
                            AOPR.Nombre = Console.ReadLine();

                            Console.Write("Apellido: ");
                            AOPR.Apellido = Console.ReadLine();

                            Console.Write("Email: ");
                            AOPR.Email = Console.ReadLine();

                            Console.Write("Telefono: ");
                            AOPR.Telefono = Convert.ToDouble(Console.ReadLine());


                            AOPR.Departamento = "Operativo";

                            Console.Write("Cargo: ");
                            AOPR.Cargo = Console.ReadLine();

                            Console.Write("precio_por_hora: ");
                            AOPR.Precio_por_hora = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Horas_trabajadas: ");
                            AOPR.Horas_trabajadas = Convert.ToInt32(Console.ReadLine());

                            AOPR.Salario_Neto = AOPR.Horas_trabajadas * AOPR.Precio_por_hora;

                            AO.Add(AOPR);



                            break;
                        }



                    case 2:
                        {

                            foreach (Almacen_ADMINISTRATIVO OPER in AO)
                            {
                                Console.WriteLine("------------------------");

                                Console.WriteLine("Codigo: " + OPER.Codigo);
                                Console.WriteLine("Nombre: " + OPER.Nombre);
                                Console.WriteLine("Nombre: " + OPER.Apellido);
                                Console.WriteLine("Nombre: " + OPER.Email);
                                Console.WriteLine("Nombre: " + OPER.Telefono);
                                Console.WriteLine("Modelo: " + OPER.Departamento);
                                Console.WriteLine("Cargo: " + OPER.Cargo);
                                Console.WriteLine("Horas_laboradas: " + OPER.Precio_por_hora);
                                Console.WriteLine("Precio_por_hora: " + OPER.Horas_trabajadas);
                                Console.WriteLine("Salario Neto: " + (OPER.Horas_trabajadas * OPER.Precio_por_hora));

                            }


                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("Codigo a buscar: ");
                            string CodigoBuscar = Console.ReadLine();

                            foreach (Almacen_ADMINISTRATIVO OPER in AO)
                            {
                                if (OPER.Codigo == CodigoBuscar)
                                {
                                    Console.WriteLine("------------------------");
                                    Console.WriteLine("----Cobrando----------");
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine("Recibo de pago");
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine("Codigo: " + OPER.Codigo);
                                    Console.WriteLine("Nombre: " + OPER.Nombre);
                                    Console.WriteLine("Categoria: " + OPER.Departamento + " con 50% a cobrar");
                                    Console.WriteLine("Precio por horas: " + OPER.Precio_por_hora);
                                    Console.WriteLine("Horas trabajadas: " + OPER.Horas_trabajadas);
                                    Console.WriteLine("Salario Neto: " + OPER.Salario_Neto);
                                    Console.WriteLine("Bono del Gerente + Salario Neto: " + (OPER.Salario_Neto + ((OPER.Salario_Neto * 10) / 100)));
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine("----------------------------------");
                                }


                            }
                            break;
                        }


                    case 4:
                        {

                            Console.WriteLine("Volviendo al menu Principal");
                            Console.ReadLine();
                            break;
                        }
                }

            } while (opcion != 4);
        }
    }
}
