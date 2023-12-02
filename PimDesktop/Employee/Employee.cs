using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDesktop.Employee
{
    public class EmployeeInfo
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string address { get; set; }
        public string cpf { get; set; }
        public string responsability { get; set; }
        public int departament { get; set; }
        public string salary { get; set; }
        public decimal baseSalary { get; set; }
        public decimal bonusSalary { get; set; }
        public decimal benefitsSalary { get; set; }
        public decimal taxesDiscount { get; set; }
        public decimal secureDiscount { get; set; }
        public decimal otherDiscount { get; set; }
    }

    public class EmployeeDataTable
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereço { get; set; }
        public string Cpf { get; set; }
        public string Cargo { get; set; }
        public int Departamento { get; set; }
        public string Salário { get; set; }
    }

    public class EmployeeHistoric
    {
        public int idEmployee { get; set; }
        public string date { get; set; }
        public string dateRegister { get; set; }
        public string salary { get; set; }
        public string information { get; set; }
    }
}
