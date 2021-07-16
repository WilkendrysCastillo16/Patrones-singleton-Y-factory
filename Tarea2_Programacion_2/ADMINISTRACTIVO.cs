using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_Programacion_2
{
    class ADMINISTRACTIVO : IEMPLEADOS
    {
        private List<Almacen_ADMINISTRATIVO> ADM;
        private int opcion;
        public void Creacion_Empleados()
        {
            ADM = new List<Almacen_ADMINISTRATIVO>();
            Random R = new Random();

            do
            {
                do
                {
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Menu empleado Administrativo");
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


                            Almacen_ADMINISTRATIVO AA = new Almacen_ADMINISTRATIVO();

                            AA.Codigo = "ADM" + R.Next(1000, 9999);

                            Console.Write("Cedula");
                            AA.Cedula = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Nombre: ");
                            AA.Nombre = Console.ReadLine();

                            Console.Write("Apellido: ");
                            AA.Apellido = Console.ReadLine();

                            Console.Write("Email: ");
                            AA.Email = Console.ReadLine();

                            Console.Write("Telefono: ");
                            AA.Telefono = Convert.ToDouble(Console.ReadLine());

                            AA.Departamento = "Administractivo ";

                            Console.Write("Cargo: ");
                            AA.Cargo = Console.ReadLine();

                            Console.Write("precio_por_hora: ");
                            AA.Precio_por_hora = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Horas_trabajadas: ");
                            AA.Horas_trabajadas = Convert.ToInt32(Console.ReadLine());

                            AA.Salario_Neto = AA.Horas_trabajadas * AA.Precio_por_hora;

                            ADM.Add(AA);



                            break;
                        }



                    case 2:
                        {

                            foreach (Almacen_ADMINISTRATIVO AG in ADM)
                            {
                                Console.WriteLine("------------------------");

                                Console.WriteLine("Codigo: " + AG.Codigo);
                                Console.WriteLine("Nombre: " + AG.Nombre);
                                Console.WriteLine("Nombre: " + AG.Apellido);
                                Console.WriteLine("Nombre: " + AG.Email);
                                Console.WriteLine("Nombre: " + AG.Telefono);
                                Console.WriteLine("Modelo: " + AG.Departamento);
                                Console.WriteLine("Cargo: " + AG.Cargo);
                                Console.WriteLine("Horas_laboradas: " + AG.Precio_por_hora);
                                Console.WriteLine("Precio_por_hora: " + AG.Horas_trabajadas);
                                Console.WriteLine("Salario Neto: " + (AG.Horas_trabajadas * AG.Precio_por_hora));
                                
                            }


                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("Codigo a buscar: ");
                            string CodigoBuscar = Console.ReadLine();

                            foreach (Almacen_ADMINISTRATIVO AG in ADM)
                            {
                                if (AG.Codigo == CodigoBuscar)
                                {
                                    Console.WriteLine("------------------------");
                                    Console.WriteLine("----Cobrando----------");
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine("Recibo de pago");
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine("Codigo: " + AG.Codigo);
                                    Console.WriteLine("Nombre: " + AG.Nombre);
                                    Console.WriteLine("Categoria: " + AG.Departamento + " con 50% a cobrar");
                                    Console.WriteLine("Precio por horas: " + AG.Precio_por_hora);
                                    Console.WriteLine("Horas trabajadas: " + AG.Horas_trabajadas);
                                    Console.WriteLine("Salario Neto: " + AG.Salario_Neto);
                                    Console.WriteLine("Bono del Gerente + Salario Neto: " + (AG.Salario_Neto + ((AG.Salario_Neto * 25) / 100)));
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
