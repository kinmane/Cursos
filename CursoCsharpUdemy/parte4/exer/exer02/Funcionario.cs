using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parte4.exer.exer02
{
    public class Funcionario
    {
        string Nome;
        double GrossSalary, Tax, NetSalary;
        
        public NetSalary()
        {
            return GrossSalary - Tax;
        }

        public void Salary(double percent)
        {
            return (GrossSalary * percent) / 100;
        }
    }
}