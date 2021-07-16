using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_Programacion_2
{
    class MENU
    {
        
        public void MENU_principal()
        {
            int Opcion;
           do{
                do
                {
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("------Empresas -Will- donde el futuro esta a la alcance de tus manos----------");
                    Console.WriteLine("------------------");
                    Console.WriteLine("1.- Gerente");
                    Console.WriteLine("2.- Administractivo");
                    Console.WriteLine("3.- Operativo");
                    Console.WriteLine("4.- Salir");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Digite la opción: ");

                       Opcion = Convert.ToInt32(Console.ReadLine());


                    if (Opcion < 1 || Opcion > 4)
                    {
                        Console.WriteLine("Ingrese una opción válida del 1 al 5");
                    }

                } while (Opcion < 1 || Opcion > 4);

               if(Opcion == 1){
                   Console.Clear();
                        Console.WriteLine("----Bienvenido a empleado Gerencial----");
                        Console.WriteLine("1->Crear Empleado");
                        Console.Write("->");
                        int opcion = int.Parse(Console.ReadLine());

                        Console.Clear();
                        Console.WriteLine("----CREANDO EMPLEADO GERENCIAL---");

                        Random R = new Random();
                        string Codigo = "GER" + R.Next(1000, 9999);

                        Console.Write("Ingresar la cedula");
                        double Cedula = int.Parse(Console.ReadLine());

                        Console.Write("Ingresar el Nombre:");
                        string Nombre = Console.ReadLine();

                        Console.Write("Ingresar el Apellido:");
                        string Apellido = Console.ReadLine();

                        Console.Write("Ingresar el Email:");
                        string Email = Console.ReadLine();

                        Console.Write("Ingresar el Telefono:");
                        double Telefono = Convert.ToDouble(Console.ReadLine());

                        string Departamento = "GERENCIAL";

                        Console.Write("Ingresar el Cargo:");
                        string Cargo = Console.ReadLine();

                        Console.Write("Ingresar el Precio por horas:");
                        double Precio_por_horas = Convert.ToDouble(Console.ReadLine());


                        Console.Write("Ingresar las Horas trabajadas:");
                        double Horas_trabajadas = Convert.ToDouble(Console.ReadLine());


                        double Salario_neto = Precio_por_horas * Horas_trabajadas;

                        GERENCIAL empleadogerencial = GERENCIAL.GetGERENTE(Codigo, Cedula, Nombre, Apellido, Email, Telefono, Departamento, Cargo, Precio_por_horas, Horas_trabajadas, Salario_neto);
                        empleadogerencial.ver_Emple_Ger();
                        Console.ReadKey();
                        empleadogerencial.cobrar_empleado();
                        Console.ReadKey();
                        empleadogerencial.Recibo_Empleado();
                         
                  }
                  
                             
               
               else if(Opcion==2 || Opcion==3){

                   IEMPLEADOS IE = FABRICA.GetIEMPLEADOS(Opcion);
                   IE.Creacion_Empleados();
               }

           }while (Opcion !=4);
           Console.WriteLine("muchas Gracias por utilizarme");
           Console.ReadKey();
        } 
        
    }
}
