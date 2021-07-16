using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_Programacion_2
{
    class Almacen_ADMINISTRATIVO
    {
        string codigo;
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        double cedula;  public double Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string apellido;
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        double telefono;
        public double Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        string departamento;
        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }
        string cargo;
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        double precio_por_hora;
        public double Precio_por_hora
        {
            get { return precio_por_hora; }
            set { precio_por_hora = value; }
        }
        double horas_trabajadas;
        public double Horas_trabajadas
        {
            get { return horas_trabajadas; }
            set { horas_trabajadas = value; }
        }
        double salario_Neto;
        public double Salario_Neto
        {
            get { return salario_Neto; }
            set { salario_Neto = value; }
        }
    }
}
