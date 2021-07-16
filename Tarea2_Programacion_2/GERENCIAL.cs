using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_Programacion_2
{
    class GERENCIAL: Almacen_GERENCIAL
    {
       
        private static GERENCIAL GERENTE;
       

     

        private GERENCIAL( string codigo, double cedula, string Nombre, string Apellido, string Email, double Telefono, string Departamento, string Cargo, double Precio_por_hora, double Horas_trabajadas, double Salario_Neto)
        {
          
            this.Codigo = codigo;
            this.Cedula = cedula;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Email = Email;
            this.Telefono = Telefono;
            this.Departamento = Departamento;
            this.Cargo = Cargo;
            this.Precio_por_hora = Precio_por_hora;
            this.Horas_trabajadas = Horas_trabajadas;
            this.Salario_Neto = Salario_Neto;


        }

        public static GERENCIAL GetGERENTE( string codigo,double cedula, string Nombre, string Apellido, string Email, double Telefono, string Departamento, string cargo, double Precio_por_hora, double Horas_trabajadas, double Salario_Neto)
        {
            if (GERENTE == null)
            {
                GERENTE = new GERENCIAL(codigo, cedula, Nombre, Apellido, Email, Telefono, Departamento, cargo, Precio_por_hora, Horas_trabajadas, Salario_Neto);

            }
            return GERENTE;

        }

        public void ver_Emple_Ger()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("UNICO GERENTE EN LA COMPAÑIA");
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("Codigo: "+ Codigo);
            Console.WriteLine("Cedula: " + Cedula);          
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Telefono: " + Telefono); 
            Console.WriteLine("Departamento: " + Departamento);
            Console.WriteLine("Cargo: " + Cargo);
            Console.WriteLine("Precio por horas: " + Precio_por_hora);
            Console.WriteLine("Horas trabajadas: " + Horas_trabajadas);
            Console.WriteLine("Salario Neto: " + Salario_Neto);
            
            
        }
        public void cobrar_empleado()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("El Gerente esta cobrando");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Codigo: " + Codigo);
            Console.WriteLine("Cedula: " + Cedula);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Salario Neto: " + Salario_Neto);
            Console.WriteLine("Bono del Gerente + Salario Neto: " + (Salario_Neto +((Salario_Neto*50)/100)));
            
        }
        public void Recibo_Empleado()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Recibo de pago");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Codigo: " + Codigo);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Categoria: " + Departamento +" con 50% a cobrar");
            Console.WriteLine("Precio por horas: " + Precio_por_hora);
            Console.WriteLine("Horas trabajadas: " + Horas_trabajadas);
            Console.WriteLine("Salario Neto: " + Salario_Neto);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("----------------------------------");
        }

    }
}
