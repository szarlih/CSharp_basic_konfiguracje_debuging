
namespace _1_konfiguracje_debuging
{
    using _1_konfiguracje_debuging.Interfaces;
    using System;

    public class StandardFlow : Flow, ISelfIntroduction
    {
        public StandardFlow()
        {
            _name = "Hello world";
        }

        public double CalculateSalary(double standard, double additional)
        {
            return standard + additional;
        }

        public int CalculateSalary(double standard)
        {
            return (int)standard;
        }

        public string name => _name;
    }
}
