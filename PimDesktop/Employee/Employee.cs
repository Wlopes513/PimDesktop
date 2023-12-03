using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

    public class EmployeeCreate
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Address { get; set; }
        [Required, RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Por favor insira um valor válido para CPF, como: 111.111.111-00")]
        public string Cpf { get; set; }
        [Required]
        [Range(1, 10000)]
        public int Departament { get; set; }
        [Required]
        public string Responsability { get; set; }
        [Required, RegularExpression(@"^-?\d+(\.\d+)?$", ErrorMessage = "Por favor insira um valor válido para Salário Base, como: 110.00")]
        public string BaseSalary { get; set; }
        [Required, RegularExpression(@"^-?\d+(\.\d+)?$", ErrorMessage = "Por favor insira um valor válido para Bônus, como: 110.00")]
        public string BonusSalary { get; set; }
        [Required, RegularExpression(@"^-?\d+(\.\d+)?$", ErrorMessage = "Por favor insira um valor válido para Benefícios, como: 110.00")]
        public string BenefitsSalary { get; set; }
        [Required, RegularExpression(@"^-?\d+(\.\d+)?$", ErrorMessage = "Por favor insira um valor válido para Taxas, como: 110.00")]
        public string TaxesDiscount { get; set; }
        [Required, RegularExpression(@"^-?\d+(\.\d+)?$", ErrorMessage = "Por favor insira um valor válido para Seguros, como: 110.00")]
        public string SecureDiscount { get; set; }
        [Required, RegularExpression(@"^-?\d+(\.\d+)?$", ErrorMessage = "Por favor insira um valor válido para Outros Descontos, como: 110.00")]
        public string OtherDiscount { get; set; }
    }
}
